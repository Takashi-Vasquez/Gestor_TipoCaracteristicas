using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Gestor_TipoCaracteristicas.Entities;

namespace Gestor_TipoCaracteristicas.Entities
{
    [Table("CaracteristicasTipoActivo")]
    public class CaracteristicasTipoActivo
    {
        [Key]
        [Column("CaracteristicasTipoActivoId")]
        [JsonPropertyName("caracteristicasTipoActivoId")]
        public int Id { get; set; }

        [ForeignKey(nameof(TipoActivo))]
        [JsonPropertyName("tipoActivoId")]
        public int TipoActivoId { get; set; }
        public TipoActivo? TipoActivo { get; set; }

        [ForeignKey(nameof(TipoCaracteristica))]
        [JsonPropertyName("tipoCaracteristicaId")]
        public int TipoCaracteristicaId { get; set; }
        public TipoCaracteristica? TipoCaracteristica { get; set; }

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
