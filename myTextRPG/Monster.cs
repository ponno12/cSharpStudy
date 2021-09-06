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
    public class Monster : Creature
    {
        protected MonsterType _type = MonsterType.None;
        protected Monster(MonsterType type) : base(CreatureType.Monster)
        {
            _type = type;
        }
        public MonsterType GetMonsterType() { return _type; }
    }

    public class Slime : Monster
    {
        public Slime() : base(MonsterType.Slime)
        {
            SetInfo(10, 1);
        }
    }
    public class Orc : Monster
    {
        public Orc() : base(MonsterType.Orc)
        {
            SetInfo(20, 3);
        }
    }
    public class Skeleton : Monster
    {
        public Skeleton() : base(MonsterType.Skeleton)
        { 
            SetInfo(15, 2);
        }
    }
}


