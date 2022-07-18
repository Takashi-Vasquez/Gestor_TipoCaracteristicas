using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;


namespace Gestor_TipoCaracteristicas.Entities;

[Table("Tenant")]
public class Tenant
{
    [Key]
    [Column("TenantId")]
    [JsonPropertyName("tenantId")]
    public int Id { get; set; }

    [Column("ShortName", TypeName = "varchar(5)")]
    [StringLength(5, ErrorMessage = "ShortName can't be longer than 5 characters")]
    [Required(ErrorMessage = "ShortName is required")]
    [JsonPropertyName("shortName")]
    public string ShortName { get; set; } = string.Empty;

    [Column("Name", TypeName = "varchar(100)")]
    [StringLength(100, ErrorMessage = "Name can't be longer than 100 characters")]
    [Required(ErrorMessage = "Name is required")]
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [Column("NotificationEmail", TypeName = "varchar(150)")]
    [Required(ErrorMessage = "The notification email address is required")]
    [EmailAddress(ErrorMessage = "Invalid Notification Email Address")]
    [JsonPropertyName("notificationEmail")]
    public string NotificationEmail { get; set; } = string.Empty;

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