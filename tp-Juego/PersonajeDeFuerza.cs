using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_Juego
{
    internal class PersonajeDeFuerza : Personaje
    {
        public PersonajeDeFuerza(string Name, int Agility, int Magic)
        {
            Nombre = Name;
            Fuerza = 100;
            Agilidad = Agility;
            Magia = Magic;
        }
        public override int CalcularDanio()
        {
            return (Fuerza/Agilidad) * Magia;
        }
        public override void Atacar()
        {
            Console.WriteLine($"{Nombre} hizo {CalcularDanio()} de daño");
        }
    }
}
