namespace Examen_final.Models;

public class InfoGeneralCliente
{
    public int Id { get; set; }
    public string TipoInformacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public DateTime FechaActualizacion { get; set; }
    public string UsuarioCreador { get; set; }
    public string EstadoInformacion { get; set; }
    public int ClienteId { get; set; }
    public Cliente Cliente { get; set; }
}
