
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Gestor_TipoCaracteristicas.Entities;

[Table("PropertyType")]
public class PropertyType
{
    [Key]
    [Column("PropertyTypeId")]
    [JsonPropertyName("propertyTypeId")]
    public int Id { get; set; }

    [Required]
    [Column("Equipment", TypeName = "varchar(50)")]
    [JsonPropertyName("equipment")]
    public string? Equipment { get; set; }

    [Column("Abbrevation", TypeName = "varchar(20)")]
    [Required(ErrorMessage = "Abbrevation is required")]
    [StringLength(20, MinimumLength = 3, ErrorMessage = "Abbrevation can't be longer than 20 characters")]
    [JsonPropertyName("abbrevation")]
    public string? Abbrevation { get; set; }

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
