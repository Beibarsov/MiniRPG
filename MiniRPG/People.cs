using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRPG
{
    class People
    {
        int hp;
        int exp;
        int gold;
        int damage;
        Random rnd = new Random();

        //Конструкт без заданных значений. В таком случае значения генерируются
        public People()
        {
            hp = rnd.Next(1, 5);
            exp = rnd.Next(1, 5);
            gold = rnd.Next(1, 5);
            Console.WriteLine("Генерируется монстр с {0} хп, {1} опытом и {2} денег", hp, exp, gold);
        }

        public People(int hp, int exp, int gold, int damage)
        {
            this.hp = hp;
            this.exp = exp;
            this.gold = gold;
            this.damage = damage; 
        }

        public int Hp
        {
            get { return hp; }
            set
            {
                hp = value;
                if (hp <= 0) throw new System.Exception();
            }
        }

        public int Exp
        {
            get { return exp; }
            set { exp = value; }
        }

        public int Gold
        {
            get { return gold; }
            set { gold = value; }
        }

        public int Damage
        {
            get { return damage; }
            set { damage = value; }
        }

        public void HasBeenDamaged(int damage)
        {
            try
            {
                Hp -= damage;
                Console.WriteLine("Нанесено {0} повреждений, осталось {1}", damage, Hp);
            }
            catch (Exception)
            {
                Console.WriteLine("Герой мертв");
            }
            
            
        }

        public void HeroAtack(People enemy)
        {
            try
            { 
            enemy.Hp -= Damage;
            Console.WriteLine("Осталось {0}, нанесено {1}", enemy.Hp, Damage);
            }
            catch (Exception e)
            {
                Console.WriteLine("Противник мертв, ведь нанесено {0} урона", Damage);
            }
        }



    }
}
