using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;


namespace Gestor_TipoCaracteristicas.Entities;

[Table("User")]
public class User
{
    [Key]
    [Column("UserId")]
    [JsonPropertyName("userId")]
    public int Id { get; set; }

    [ForeignKey(nameof(TenantCompany))]
    [Required(ErrorMessage = "TenantCompanyId is required")]
    [JsonPropertyName("tenantCompanyId")]
    public int TenantCompanyId { get; set; }
    public TenantCompany? TenantCompany { get; set; }

    [ForeignKey(nameof(UserRole))]
    [Required(ErrorMessage = "UserRoleId is required")]
    [JsonPropertyName("userRoleId")]
    public int UserRoleId { get; set; }
    public UserRole? UserRole { get; set; }

    [ForeignKey(nameof(UserPosition))]
    [Required(ErrorMessage = "UserPositionId is required")]
    [JsonPropertyName("userPositionId")]
    public int UserPositionId { get; set; }
    public UserPosition? UserPosition { get; set; }

    [Column("ActiveDirectoryId", TypeName = "uniqueidentifier")]
    [Required(ErrorMessage = "AD Guid is required")]
    [JsonPropertyName("activeDirectoryId")]
    public Guid ActiveDirectoryId { get; set; }

    [Column("Username", TypeName = "varchar(100)")]
    [Required(ErrorMessage = "Username is required")]
    [StringLength(100, ErrorMessage = "Username can't be longer than 100 characters")]
    [JsonPropertyName("username")]
    public string Username { get; set; } = string.Empty;

    [Column("FirstName", TypeName = "varchar(50)")]
    [Required(ErrorMessage = "Firstname is required")]
    [StringLength(50, ErrorMessage = "FirstName can't be longer than 50 characters")]
    [JsonPropertyName("firstName")]
    public string FirstName { get; set; } = string.Empty;

    [Column("PaternalLastName", TypeName = "varchar(50)")]
    [Required(ErrorMessage = "PaternalLastName is required")]
    [StringLength(50, ErrorMessage = "PaternalLastName can't be longer than 50 characters")]
    [JsonPropertyName("paternalLastName")]
    public string PaternalLastName { get; set; } = string.Empty;

    [Column("MaternalLastName", TypeName = "varchar(50)")]
    [Required(ErrorMessage = "MaternalLastName is required")]
    [StringLength(50, ErrorMessage = "MaternalLastName can't be longer than 50 characters")]
    [JsonPropertyName("maternalLastName")]
    public string MaternalLastName { get; set; } = string.Empty;

    [Column("Email", TypeName = "varchar(150)")]
    [Required(ErrorMessage = "The email address is required")]
    [EmailAddress(ErrorMessage = "Invalid Email Address")]
    [JsonPropertyName("email")]
    public string Email { get; set; } = string.Empty;

    [Column("PhoneNumber", TypeName = "nvarchar(20)")]
    [JsonPropertyName("phoneNumber")]
    [Phone(ErrorMessage = "Invalid Phone Number")]
    public string? PhoneNumber { get; set; }

    [Column("DocumentNumber", TypeName = "nvarchar(15)")]
    [StringLength(15, ErrorMessage = "Document Number can't be longer than 15 characters")]
    [JsonPropertyName("documentNumber")]
    public string? DocumentNumber { get; set; }

    [Column("DocumentType", TypeName = "tinyint")]
    [Required(ErrorMessage = "DocumentType is required")]
    [JsonPropertyName("documentType")]
    public byte DocumentType { get; set; }

    [Column("AvatarUrl", TypeName = "varchar(300)")]
    [Required(ErrorMessage = "AvatarUrl is required")]
    [StringLength(300, ErrorMessage = "AvatarUrl can't be longer than 300 characters")]
    [JsonPropertyName("avatarUrl")]
    public string? AvatarUrl { get; set; } = string.Empty;

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