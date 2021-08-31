using System;

namespace TextRPG
{
    class Program
    {
        enum ClassType
        {
            None = 0,
            Knight = 1,
            Archer = 2,
            Mage = 3,
        }

        struct Player
        {
            public int hp;
            public int attack;
            
        }

        static ClassType ChooseClass()
        {
            ClassType choice = ClassType.None;
            Console.WriteLine("직업을 선택하세요!!");
            Console.WriteLine("[1] 기사");
            Console.WriteLine("[2] 궁수");
            Console.WriteLine("[3] 법사");
            

            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    choice = ClassType.Knight;
                    break;
                case "2":
                    choice = ClassType.Archer;
                    break;
                case "3":
                    choice = ClassType.Mage;
                    break;
            }
            return choice;
        }
        static void Main(string[] args)
        {
            ClassType choice = ClassType.None;
            while (true)
            {
                choice = ChooseClass();
                if(choice != ClassType.None)
                {
                    Player player;
                    
                    //캐릭터 생성
                    
                    //구조체


                    CreatePlayer(choice, out player);

                    //기사(100/10) 궁수(75/7) 법사(50/15)

                    Console.WriteLine($"HP{player.hp} Attack{player.attack}");
                    //필드로 가서 몬스터랑 싸운다.



                }

            }   
        }

         static void CreatePlayer(ClassType choice ,out Player player)
        {
            //out을 받았으면 무조건 사용해야한다.
            
            
            switch (choice)
            {
                case ClassType.Knight:
                    player.hp = 100;
                    player.attack = 10;
                    break;
                case ClassType.Archer:
                    player.hp = 50;
                    player.attack = 15;
                    break;
                case ClassType.Mage:
                    player.hp = 20;
                    player.attack = 20;
                    break;
                default:
                    player.hp = 0;
                    player.attack = 0;
                    break;
            }

        }
    }
}
