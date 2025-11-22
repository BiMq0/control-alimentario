using System.ComponentModel.DataAnnotations;
namespace SmartNutriTracker.Back.Models.BaseModels;

public class TipoResultado
{
    [Key]
    public int TipoResultadoId { get; set; }
    public string Nombre { get; set; } = null!;

    public ICollection<Log>? Logs { get; set; }
}