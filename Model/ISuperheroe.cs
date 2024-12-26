namespace TrabajoFinal.Model
{
    public interface ISuperheroe
    {
        string Nombre { get; set; }
        int Fuerza { get; set; }
        int Salud { get; set; }
        string PoderEspecial { get; set; }

        string Atacar();
        string Defender();

    }
}
