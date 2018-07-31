using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MiniRPG
{
    class Enemy
    {
        int hp;
        int exp;
        int gold;
        Random rnd = new Random();

        //Конструкт без заданных значений. В таком случае значения генерируются
        public Enemy()
        {
            hp = rnd.Next(1, 5);
            exp = rnd.Next(1, 5);
            gold = rnd.Next(1, 5);
        }

        public Enemy(int hp, int exp, int gold)
        {
            this.hp = hp;
            this.exp = exp;
            this.gold = gold;
        }

        public int Hp
        {
            get { return hp; }
            set
            {
                hp = value;
                if (hp < 0) throw new System.Exception();
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
    }
}