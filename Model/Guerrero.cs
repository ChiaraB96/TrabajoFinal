namespace TrabajoFinal.Model
{
    public class Guerrero : ISuperheroe
    {
        public string Nombre { get; set; }
        public int Fuerza { get; set; }
        public int Salud { get; set; }
        public string PoderEspecial { get; set; }
        public string Tipo { get; set; }
        public Guerrero(string name)
        {
            Nombre = name;
            Fuerza = 15;
            Salud = 5;
            PoderEspecial = "Frenesí asesino";
            Tipo = "Guerrero";
        }

        public string Atacar()
        {
            return "Golpe con espada";
        }
        public string Defender()
        {
            return "Escudo protector";
        }
    }
}
