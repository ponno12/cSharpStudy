using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myTextRPG
{
    public enum MonsterType
    {
        None,
        Slime =1 ,
        Orc =2 ,
        Skeleton =3
    }
    class Monster : Creature
    {
        protected MonsterType _type;
        protected Monster(MonsterType type) : base(CreatureType.Monster)
        {
            _type = type;
        }
    }
}
