namespace VpetsofttNet.Models;

public class Mascota
{
    public int idmascota { get; set; }
    public String nommascota { get; set; }
    public String colmascota { get; set; }
    public DateTime fecnacmascota { get; set; }
    public int idcliente { get; set; }
    public int idraza { get; set; }
    public int idespecie { get; set; }
    public String num_microchipmascota { get; set; }
    public int idgenmascota { get; set; }
}