
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using System.Text.Json.Serialization;


namespace Gestor_TipoCaracteristicas.Entities
{
    [Table("ClaseActivo")]
    public class ClaseActivo
    {
        [Key]
        [Column("ClaseActivoId")]
        [JsonPropertyName("claseActivoId")]
        public int Id { get; set; }

        [Column("Name", TypeName = "varchar(50)")]
        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, ErrorMessage = "Name can't be longer than 50 characters")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

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
