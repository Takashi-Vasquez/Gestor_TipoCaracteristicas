using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Gestor_TipoCaracteristicas.Entities;

namespace Gestor_TipoCaracteristicas.Entities
{
    [Table("PropertyAssetType")]
    public class PropertyAssetType
    {
        [Key]
        [Column("PropertyAssetTypeId")]
        [JsonPropertyName("propertyAssetTypeId")]
        public int Id { get; set; }

        [ForeignKey(nameof(PropertyType))]
        [JsonPropertyName("propertyTypeId")]
        public int PropertyTypeId { get; set; }
        public PropertyType? PropertyType { get; set; }

        [ForeignKey(nameof(AssetType))]
        [JsonPropertyName("assetTypeId")]
        public int AssetTypeId { get; set; }
        public AssetType? AssetType { get; set; }

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
