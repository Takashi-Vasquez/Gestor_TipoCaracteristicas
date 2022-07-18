using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Gestor_TipoCaracteristicas.Entities;

namespace Gestor_TipoCaracteristicas.Entities
{
    public class CaracteristicasActivo
    {
        [Key]
        [Column("CaracteristicasActivoId")]
        [JsonPropertyName("caracteristicasActivoId")]
        public int Id { get; set; }

        [ForeignKey(nameof(CaracteristicasTipoActivo))]
        [JsonPropertyName("caracteristicasTipoActivoId")]
        public int CaracteristicasTipoActivoId { get; set; }
        public CaracteristicasTipoActivo? CaracteristicasTipoActivo { get; set; } 
        
        [ForeignKey(nameof(TipoActivo))]
        [JsonPropertyName("tipoActivoId")]
        public int TipoActivoId { get; set; }
        public TipoActivo? TipoActivo { get; set; }

        [Column("Name", TypeName = "varchar(50)")]
        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, ErrorMessage = "Name can't be longer than 50 characters")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [Column("Description", TypeName = "varchar(50)")]
        [Required(ErrorMessage = "Description is required")]
        [StringLength(50, ErrorMessage = "Description can't be longer than 50 characters")]
        [JsonPropertyName("description")]
        public string Description { get; set; }

        [Column("Comment", TypeName = "varchar(50)")]
        [Required(ErrorMessage = "Comment is required")]
        [StringLength(50, ErrorMessage = "Comment can't be longer than 50 characters")]
        [JsonPropertyName("comment")]
        public string Comment { get; set; }

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
