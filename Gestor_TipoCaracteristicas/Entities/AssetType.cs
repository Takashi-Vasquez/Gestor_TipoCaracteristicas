
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using System.Text.Json.Serialization;

namespace Gestor_TipoCaracteristicas.Entities
{
    [Table("AssetType")]
    public class AssetType
    {
        [Key]
        [Column("AssetTypeId")]
        [JsonPropertyName("assetTypeId")]
        public int Id { get; set; }

        [Column("Name", TypeName = "varchar(50)")]
        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, ErrorMessage = "Name can't be longer than 50 characters")]
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [Column("Abbrevation", TypeName = "varchar(20)")]
        [Required(ErrorMessage = "Abbrevation is required")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Abbrevation can't be longer than 20 characters")]
        [JsonPropertyName("abbrevation")]
        public string? Abbrevation { get; set; }

        [ForeignKey(nameof(AssetClass))]
        [JsonPropertyName("assetClassId")]
        public int AssetClassId { get; set; }
        public AssetClass? AssetClass { get; set; }

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
