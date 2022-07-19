using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Gestor_TipoCaracteristicas.Entities;

namespace Gestor_TipoCaracteristicas.Entities
{
    [Table("PropertyAsset")]
    public class PropertyAsset
    {
        [Key]
        [Column("PropertyAssetId")]
        [JsonPropertyName("propertyAssetId")]
        public int Id { get; set; }

        [ForeignKey(nameof(PropertyAssetType))]
        [JsonPropertyName("propertyAssetTypeId")]
        public int PropertyAssetTypeId { get; set; }
        public PropertyAssetType? PropertyAssetType { get; set; } 
        
        [ForeignKey(nameof(Asset))]
        [JsonPropertyName("assetId")]
        public int AssetId { get; set; }
        public Asset? Asset { get; set; }

        [Column("Name", TypeName = "varchar(50)")]
        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, ErrorMessage = "Name can't be longer than 50 characters")]
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [Column("Description", TypeName = "varchar(50)")]
        [Required(ErrorMessage = "Description is required")]
        [StringLength(50, ErrorMessage = "Description can't be longer than 50 characters")]
        [JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;

        [Column("Comment", TypeName = "varchar(50)")]
        [Required(ErrorMessage = "Comment is required")]
        [StringLength(50, ErrorMessage = "Comment can't be longer than 50 characters")]
        [JsonPropertyName("comment")]
        public string Comment { get; set; } = string.Empty;

        [Column("Status", TypeName = "tinyint")]
        [Required(ErrorMessage = "Status is required")]
        [JsonPropertyName("status")]
        public byte Status { get; set; }

        [Column("CreatedDate", TypeName = "datetime")]
        [Required(ErrorMessage = "CreatedDate is required")]
        [JsonPropertyName("createdDate")]
        public DateTime CreatedDate { get; set; }

        [Column("CreatedUser", TypeName = "nvarchar(36)")]
        [JsonPropertyName("createdUser")]
        public string? CreatedUser { get; set; }

        [Column("UpdatedDate", TypeName = "datetime")]
        [JsonPropertyName("updatedDate")]
        public DateTime? UpdatedDate { get; set; }

        [Column("UpdatedUser", TypeName = "nvarchar(36)")]
        [JsonPropertyName("updatedUser")]
        public string? UpdatedUser { get; set; }



       
    }
}
