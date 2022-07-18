using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;


namespace Gestor_TipoCaracteristicas.Entities;

[Table("Company")]
public class Company
{
    [Key]
    [Column("CompanyId")]
    [JsonPropertyName("companyId")]
    public int Id { get; set; }

    [Column("Name", TypeName = "varchar(100)")]
    [StringLength(100, ErrorMessage = "Name can't be longer than 100 characters")]
    [Required(ErrorMessage = "Name is required")]
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [Column("Email", TypeName = "varchar(100)")]
    [EmailAddress(ErrorMessage = "Invalid Email Address")]
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    [Column("PhoneNumber", TypeName = "nvarchar(20)")]
    [JsonPropertyName("phoneNumber")]
    [Phone(ErrorMessage = "Invalid Phone Number")]
    public string? PhoneNumber { get; set; }

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