namespace TrabajoFinal.Model
{
    public class Mago : ISuperheroe
    {
        public string Nombre { get; set; }
        public int Fuerza { get; set; }
        public int Salud { get; set; }
        public string PoderEspecial { get; set; }
        public string Tipo { get; set; }
        public Mago(string name)
        {
            Nombre = name;
            Fuerza = 8;
            Salud = 8;
            PoderEspecial = "Explosión Solar";
            Tipo = "Mago";
        }

        public string Atacar()
        {
            return "Rayo de luz";
        }
        public string Defender()
        {
            return "Invocar escudo de mana";
        }
    }
}
