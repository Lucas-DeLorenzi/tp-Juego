using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_Juego
{
    internal class PersonajeDeMagia : Personaje
    {
        public PersonajeDeMagia(string Name, int Strength, int Agility, int Magic)
        {
            Nombre = Name;
            Fuerza = Strength;
            Agilidad = Agility;
            Magia = Magic;
        }
        public PersonajeDeMagia(string Name, int Agility, int Strength)
        {
            Nombre = Name;
            Fuerza = Strength;
            Agilidad = Agility;
            Magia = 60;
        }
        public override int CalcularDanio()
        {
            return Fuerza + Agilidad + Magia * 4;
        }
        public override void Atacar()
        {
            Console.WriteLine($"{Nombre} hizo {CalcularDanio()} de daño gracias a su magia");
        }
    }
}
