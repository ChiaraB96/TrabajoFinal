namespace TrabajoFinal.Model
{
    public class EnfermeriaSingleton
    {
        private static readonly EnfermeriaSingleton _instancia = new EnfermeriaSingleton();
        private const int MaxAtenciones = 5;
        private int visitasDisponibles = MaxAtenciones;
        private EnfermeriaSingleton() { }
        public static EnfermeriaSingleton Instancia
        { 
            get 
            { 
                return _instancia; 
            } 
        }
        public bool VisitarEnfermeria(ref int saludActual, int cantidadVisitas)
        {
            if (visitasDisponibles <= 0)
            {
                return false;
            }

            for (int i = 0; i < cantidadVisitas; i++)
            {
                if (visitasDisponibles > 0 && saludActual < 5)
                {
                    saludActual++;
                    visitasDisponibles--;
                }
            }

            return true;
        }

        public int GetVisitasRestantes() => visitasDisponibles;
    }
}
