using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;



namespace Gestor_TipoCaracteristicas.Entities;

[Table("TenantCompany")]
public class TenantCompany
{
    [Key]
    [Column("TenantCompanyId")]
    [JsonPropertyName("tenantCompanyId")]
    public int Id { get; set; }

    [ForeignKey(nameof(Tenant))]
    [JsonPropertyName("tenantId")]
    public int TenantId { get; set; }
    public Tenant? Tenant { get; set; }

    [ForeignKey(nameof(Company))]
    [JsonPropertyName("companyId")]
    public int CompanyId { get; set; }
    public Company? Company { get; set; }

    [Required(ErrorMessage = "CompanyType is required")]
    [JsonPropertyName("companyType")]
    public int CompanyType { get; set; }

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