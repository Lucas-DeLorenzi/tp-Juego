namespace tp_Juego
{
    public class Program
    {
        public static void Main()
        {
            PersonajeDeFuerza Fuerte = new("Leono", 50, 80);
            PersonajeDeMagia Mago = new("Harry", 15, 40, 35);
            PersonajeDeAgilidad Agil = new("Bolt", 20, 95, 35);
            PersonajeDeAgilidad Agil2 = new("Rayo", 75, 50, 35);
            Enemigo Enemigo = new(100, 8);
            List<Personaje> Personajes = new();
            Personajes.Add(Mago);
            Personajes.Add(Agil);
            Personajes.Add(Fuerte);
            Personajes.Add(Agil2);
            Turno.Atacarse(Personajes);
            Turno.MoverFichas(Enemigo);
        }
    }
}