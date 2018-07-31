using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "MiniRPG v0.0.1";
            Console.WriteLine("Начало");
            //Создаём объект героя
            People myHero = new People(10, 0, 0, 2);
            People  myEnemy = new People();
            myHero.HasBeenDamaged(1);
            myHero.HeroAtack(myEnemy);
        }
    }
}
