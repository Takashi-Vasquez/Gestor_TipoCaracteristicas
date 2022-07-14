
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Maestro_TipoCaracteristicas.Entities;

[Table("TipoCaracteristica")]
public class TipoCaracteristica
{
    [Key]
    [Column("Id")]
    public int Id { get; set; }
    [Column("Equipo")]
    public string Equipo { get; set; }
    [Column("Abreviatura")]
    public string Abreviatura { get; set; }

}
