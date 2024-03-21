namespace VpetsofttNet.Models;

public class Ingreso
{
    public int idingreso { get; set; }
    public DateTime fecingreso { get; set; }
    public DateOnly horaingreso { get; set; }
    public int idcita { get; set; }
    public int idestadoingreso { get; set; }
    public int idtipoingreso { get; set; }
}