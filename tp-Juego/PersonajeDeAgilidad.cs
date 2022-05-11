using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_Juego
{
    internal class PersonajeDeAgilidad : Personaje
    {
        public PersonajeDeAgilidad(string Name,int Strength, int Agility, int Magic)
        {
            Nombre = Name;
            Fuerza = Strength;
            Agilidad = Agility;
            Magia = Magic;
        }
        public override int CalcularDanio()
        {
            return Fuerza / 2 * Agilidad * Magia / 2;
        }
        public override void Atacar()
        {
            Console.WriteLine($"{Nombre} hizo {CalcularDanio()} de daño");
        }
    }
}
