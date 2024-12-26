﻿namespace TrabajoFinal.Model
{
    public class Guerrero : ISuperheroe
    {
        public string Nombre { get; set; }
        public int Fuerza { get; set; }
        public int Salud { get; set; }
        public string PoderEspecial { get; set; }
        public Guerrero(string name)
        {
            Nombre = name;
            Fuerza = 15;
            Salud = 11;
            PoderEspecial = "Frenesí asesino";
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
