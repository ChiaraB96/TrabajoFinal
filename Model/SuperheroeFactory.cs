namespace TrabajoFinal.Model
{
    public static class SuperheroeFactory
    {
        public static ISuperheroe CrearSuperheroe(string tipo, string name)
        {
            switch (tipo.ToLower()) 
            {
                case "arquero":
                    return new Arquero(name);
                case "mago":
                    return new Mago(name);
                case "guerrero":
                    return new Guerrero(name);
                default:
                    throw new ArgumentException("Tipo de heroe no existente");
            }
        }
    }
}
