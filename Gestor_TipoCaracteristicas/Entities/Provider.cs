using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;


namespace Gestor_TipoCaracteristicas.Entities;

[Table("Provider")]
public class Provider
{
    [Key]
    [Column("ProviderId")]
    [JsonPropertyName("providerId")]
    public int Id { get; set; }

    [ForeignKey(nameof(Bank))]
    [Required(ErrorMessage = "BankId is required")]
    [JsonPropertyName("bankId")]
    public int BankId { get; set; }
    public Bank? Bank { get; set; }

    [ForeignKey(nameof(Currency))]
    [Required(ErrorMessage = "CurrencyId is required")]
    [JsonPropertyName("currencyId")]
    public int CurrencyId { get; set; }
    public Currency? Currency { get; set; }

    [Column("ContactName", TypeName = "varchar(100)")]
    [Required(ErrorMessage = "ContactName is required")]
    [StringLength(100, ErrorMessage = "ContactName can't be longer than 100 characters")]
    [JsonPropertyName("contactName")]
    public string ContactName { get; set; } = string.Empty;

    [Column("BusinessName", TypeName = "varchar(100)")]
    [Required(ErrorMessage = "BusinessName is required")]
    [StringLength(100, ErrorMessage = "BusinessName can't be longer than 100 characters")]
    [JsonPropertyName("businessName")]
    public string BusinessName { get; set; } = string.Empty;

    [Column("Address", TypeName = "varchar(150)")]
    [Required(ErrorMessage = "Address is required")]
    [StringLength(150, ErrorMessage = "Address can't be longer than 150 characters")]
    [JsonPropertyName("address")]
    public string Address { get; set; } = string.Empty;

    [Column("WebAddress", TypeName = "varchar(100)")]
    [Required(ErrorMessage = "WebAddress is required")]
    [StringLength(100, ErrorMessage = "WebAddress can't be longer than 100 characters")]
    [JsonPropertyName("address")]
    public string WebAddress { get; set; } = string.Empty;

    [Column("Email", TypeName = "varchar(150)")]
    [Required(ErrorMessage = "The email address is required")]
    [EmailAddress(ErrorMessage = "Invalid Email Address")]
    [JsonPropertyName("email")]
    public string Email { get; set; } = string.Empty;

    [Column("CellPhoneNumber", TypeName = "nvarchar(20)")]
    [JsonPropertyName("cellPhoneNumber")]
    [Phone(ErrorMessage = "Invalid CellPhone Number")]
    public string? CellPhoneNumber { get; set; }

    [Column("PhoneNumber", TypeName = "nvarchar(20)")]
    [JsonPropertyName("phoneNumber")]
    [Phone(ErrorMessage = "Invalid Phone Number")]
    public string? PhoneNumber { get; set; }

    [Column("AdditionalComment", TypeName = "varchar(200)")]
    [Required(ErrorMessage = "AdditionalComment is required")]
    [StringLength(200, ErrorMessage = "AdditionalComment can't be longer than 200 characters")]
    [JsonPropertyName("additionalComment")]
    public string? AdditionalComment { get; set; }

    [Column("DocumentNumber", TypeName = "nvarchar(15)")]
    [StringLength(15, ErrorMessage = "Document Number can't be longer than 15 characters")]
    [JsonPropertyName("documentNumber")]
    public string DocumentNumber { get; set; } = string.Empty;

    [Column("BankInterCode", TypeName = "varchar(50)")]
    [Required(ErrorMessage = "BankInterCode is required")]
    [StringLength(50, ErrorMessage = "BankInterCode can't be longer than 50 characters")]
    [JsonPropertyName("bankInterCode")]
    public string BankInterCode { get; set; } = string.Empty;

    [Column("DocumentType", TypeName = "tinyint")]
    [Required(ErrorMessage = "DocumentType is required")]
    [JsonPropertyName("documentType")]
    public byte DocumentType { get; set; }

    [Column("PaymentType", TypeName = "tinyint")]
    [Required(ErrorMessage = "PaymentType is required")]
    [JsonPropertyName("paymentType")]
    public byte PaymentType { get; set; }

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