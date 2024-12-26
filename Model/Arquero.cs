namespace TrabajoFinal.Model
{
    public class Arquero: ISuperheroe
    {
        public string Nombre { get; set; }
        public int  Fuerza { get; set; }
        public int Salud {  get; set; }
        public string PoderEspecial { get; set; }
        public Arquero(string name) 
        {
            Nombre = name;
            Fuerza = 5; 
            Salud = 10;
            PoderEspecial = "Dispara lluvia de flechas";
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
