
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;


namespace Gestor_TipoCaracteristicas.Entities
{
    [Table("Asset")]
    public class Asset
    {
        [Key]
        [Column("AssetId")]
        [JsonPropertyName("assetId")]
        public int Id { get; set; }

        [ForeignKey(nameof(AssetClass))]
        [JsonPropertyName("assetClassId")]
        public int AssetClassId { get; set; }
        public AssetClass? AssetClass { get; set; }

        [ForeignKey(nameof(AssetType))]
        [JsonPropertyName("assetTypeId")]
        public int AssetTypeId { get; set; }
        public AssetType? AssetType { get; set; }

        [ForeignKey(nameof(Currency))]
        [JsonPropertyName("currencyId")]
        public int CurrencyId { get; set; }
        public Currency? Currency { get; set; }

        [ForeignKey(nameof(Brand))]
        [JsonPropertyName("brandId")]
        public int BrandId { get; set; }
        public Brand? Brand { get; set; }

        [ForeignKey(nameof(Provider))]
        [JsonPropertyName("providerId")]
        public int ProviderId { get; set; }
        public Provider? Provider { get; set; }

        [Column("CompanyId")]
        [JsonPropertyName("companyId")]
        public int CompanyId { get; set; }

        [Column("SedeId")]
        [JsonPropertyName("sedeId")]
        public int SedeId { get; set; }

        [Column("ClientId")]
        [JsonPropertyName("clientId")]
        public int? ClientId { get; set; }

        [Column("AssetCode")]
        [JsonPropertyName("assetCode")]
        public string AssetCode { get; set; } = string.Empty;

        [Column("Cost", TypeName = "decimal(10,2)")]
        [JsonPropertyName("cost")]
        public decimal? Cost { get; set; }

        [Column("Model", TypeName = "varchar(50)")]
        [Required(ErrorMessage = "Model is required")]
        [StringLength(50, ErrorMessage = "Model can't be longer than 50 characters")]
        [JsonPropertyName("model")]
        public string? Model { get; set; }

        [Column("SerialNumber", TypeName = "varchar(50)")]
        [Required(ErrorMessage = "SerialNumber is required")]
        [StringLength(50, ErrorMessage = "SerialNumber can't be longer than 50 characters")]
        [JsonPropertyName("serialNumber")]
        public string? SerialNumber { get; set; }

        [Column("Condition")]
        [Required(ErrorMessage = "Condition is required")]
        [JsonPropertyName("condition")]
        public int Condition { get; set; }

        [Column("Invoice", TypeName = "varchar(50)")]
        [StringLength(50, ErrorMessage = "Invoice can't be longer than 50 characters")]
        [JsonPropertyName("invoice")]
        public string? Invoice { get; set; }

        [Column("BuyDate", TypeName = "Datetime")]
        [Required(ErrorMessage = "BuyDate is required")]
        [JsonPropertyName("buyDate")]
        public DateTime? BuyDate { get; set; }

        [Column("Observation", TypeName = "varchar(50)")]
        [Required(ErrorMessage = "Observation is required")]
        [StringLength(50, ErrorMessage = "Observation can't be longer than 50 characters")]
        [JsonPropertyName("observation")]
        public string? Observation { get; set; }

        [Column("LoanDocument", TypeName = "varchar(50)")]
        [StringLength(50, ErrorMessage = "LoanDocument can't be longer than 50 characters")]
        [JsonPropertyName("loanDocument")]
        public string? LoanDocument { get; set; }

        [Column("ContractNumber", TypeName = "varchar(50)")]
        [StringLength(50, ErrorMessage = "ContractNumber can't be longer than 50 characters")]
        [JsonPropertyName("contractNumber")]
        public string? ContractNumber { get; set; }

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
