namespace TrabajoFinal.Model
{
    public class Arquero: ISuperheroe
    {
        public string Nombre { get; set; }
        public int  Fuerza { get; set; }
        public int Salud {  get; set; }
        public string PoderEspecial { get; set; }
        public string Tipo { get; set; }
        public Arquero(string name) 
        {
            Nombre = name;
            Fuerza = 5; 
            Salud = 3;
            PoderEspecial = "Dispara lluvia de flechas";
            Tipo = "Arquero";
        }

        public string Atacar() 
        { 
            return "Tira flechas"; 
        }
        public string Defender()
        {
            return "Rueda y esquiva el ataque";
        }
    }
}
