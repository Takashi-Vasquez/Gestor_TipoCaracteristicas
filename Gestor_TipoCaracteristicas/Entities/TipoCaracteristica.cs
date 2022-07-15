
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gestor_TipoCaracteristicas.Entities;

[Table("TipoCaracteristica")]
public class TipoCaracteristica
{
    [Key]
    [Column("Id")]
    public int Id { get; set; }

    [Required]
    [Column("Equipo"), DataType("nvarchar")]
    [StringLength(20)]
    //[Column("Equipo")]
    public string? Equipo { get; set; }

    [Required]
    [Column("Abreviatura"), DataType("nvarchar")]
    [StringLength(10, MinimumLength = 3)]
    //[Column("Abreviatura")]
    public string? Abreviatura { get; set; }

    [ForeignKey("Modelo")]
    [Column("ModeloId")]
    public int ModeloId { get; set; }
    public Modelo Modelo { get; set; }

}
