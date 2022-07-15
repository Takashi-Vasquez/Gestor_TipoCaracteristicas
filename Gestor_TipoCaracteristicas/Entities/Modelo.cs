
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Gestor_TipoCaracteristicas.Entities;

[Table("Modelo")]
public class Modelo
{
    [Key]
    [Column("Id")]
    public int Id { get; set; }
    [Column("Nombre"), DataType("nvarchar")]
    [StringLength(50)]
    //[Column("Nombre")]
    public string? Nombre { get; set; }


}

