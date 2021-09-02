using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myTextRPG
{

    public enum CreatureType
    {
        None,
        Player =1 ,
        Monster =2 
    }
    public class Creature
    {
        CreatureType _type;


        protected int hp = 0;
        protected int attack = 0;


        protected Creature(CreatureType type)
        {
            _type = type;
        }
        protected void SetInfo(int hp, int attack)
        {
            this.hp = hp;
            this.attack = attack;
        }
        public int GetHp() { return this.hp; }
        public int GetAttack() { return this.attack; }
        public bool IsDead() { return hp <= 0; }
        public void OnDamaged(int damage)
        {
            hp -= damage;
            if (hp < 0)
                hp = 0;
        }
    }
}
