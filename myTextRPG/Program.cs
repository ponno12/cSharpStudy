using System;

namespace myTextRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("캐릭터 직업을 선택하세요");
                string input = Console.ReadLine();
            }

            Player player = new Knight();
            Player player2 = new Archer();
            Monster monster = new Orc();

            int damage = player.GetAttack();
            monster.OnDamaged(damage);
            
        }
    }
}