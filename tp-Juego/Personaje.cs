using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_Juego
{
    abstract class Personaje : IMoverse
    {
        protected string Nombre = "";
        protected int Fuerza;
        protected int Agilidad;
        protected int Magia;
        public abstract int CalcularDanio();
        public abstract void Atacar();
        public void MoverseEjeX(int amount)
        {
            int ValorEjeX = amount;
            if (ValorEjeX < 0)
            {
                Console.WriteLine($"{Nombre} se desplazo {ValorEjeX} pasos hacia la izquierda");
            } 
            else if (ValorEjeX > 0)
            {
                Console.WriteLine($"{Nombre} se desplazo {ValorEjeX} pasos hacia la derecha");
            }
            else
            {
                Console.WriteLine($"{Nombre} no se ha desplazado lateralmente");
            }
        }
        public void MoverseEjeY(int amount)
        {
            int ValorEjeY = amount;
            if (ValorEjeY < 0)
            {
                Console.WriteLine($"{Nombre} se desplazo {ValorEjeY} pasos hacia abajo");
            }
            else if (ValorEjeY > 0)
            {
                Console.WriteLine($"{Nombre} se desplazo {ValorEjeY} pasos hacia arriba");
            }
            else
            {
                Console.WriteLine($"{Nombre} no se ha desplazado verticalmente");
            }
        }
    }
}
