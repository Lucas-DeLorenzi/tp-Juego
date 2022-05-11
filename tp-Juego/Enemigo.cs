using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_Juego
{
    internal class Enemigo : IMoverse
    {
        protected int Vida;
        protected int Nivel;

        public Enemigo( int life, int level)
        {
            Vida = life;
            Nivel = level;
        }

        public void MoverseEjeX(int amount)
        {
            int ValorEjeX = amount;
            if (ValorEjeX < 0)
            {
                Console.WriteLine($"Enemigo se desplazo {ValorEjeX} pasos hacia la izquierda");
            }
            else if (ValorEjeX > 0)
            {
                Console.WriteLine($"Enemigo se desplazo {ValorEjeX} pasos hacia la derecha");
            }
            else
            {
                Console.WriteLine($"Enemigo no se ha desplazado lateralmente");
            }
        }
        public void MoverseEjeY(int amount)
        {
            int ValorEjeY = amount;
            if (ValorEjeY < 0)
            {
                Console.WriteLine($"Enemigo se desplazo {ValorEjeY} pasos hacia abajo");
            }
            else if (ValorEjeY > 0)
            {
                Console.WriteLine($"Enemigo se desplazo {ValorEjeY} pasos hacia arriba");
            }
            else
            {
                Console.WriteLine($"Enemigo no se ha desplazado verticalmente");
            }
        }
    }
}
