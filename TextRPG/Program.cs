using System;

namespace TextRPG
{
    internal class Program
    {
        private enum PlayerType
        {
            None = 0,
            Knight = 1,
            Archer = 2,
            Mage = 3,
        }

        private enum MonsterType
        {
            None,
            Slime,
            Orc,
            Skeleton
        }

        private struct Player
        {
            public int hp;
            public int attack;
        }
        private struct Monster
        {
            public int hp;
            public int attack;
        }

        private static void Main(string[] args)
        {
            PlayerType choice = PlayerType.None;
            while (true)
            {
                choice = ChooseClass();
                if (choice != PlayerType.None)
                {
                    //캐릭터 생성
                    //구조체
                    Player player;
                    CreatePlayer(choice, out player);
                    EnterGame(ref player);

                    //필드로 가서 몬스터랑 싸운다.

                }
            }
        }
        private static PlayerType ChooseClass()
        {
            PlayerType choice = PlayerType.None;
            Console.WriteLine("직업을 선택하세요!!");
            Console.WriteLine("[1] 기사");
            Console.WriteLine("[2] 궁수");
            Console.WriteLine("[3] 법사");

            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    choice = PlayerType.Knight;
                    break;

                case "2":
                    choice = PlayerType.Archer;
                    break;

                case "3":
                    choice = PlayerType.Mage;
                    break;
            }
            return choice;
        }
        private static void EnterGame(ref Player player)
        {   
            while (true)
            {
                Console.WriteLine("마을에 접속했습니다");
                Console.WriteLine("[1] 필드로 간다");
                Console.WriteLine("[2] 로비로 돌아가기");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        EnterField(ref player);
                        break;

                    case "2":
                        //return은 swith를 빠져나오는게 아니라 EnterGame()자체를 빠져나온다.
                        return;

                    default:
                        break;
                }
            }
        }

        private static void EnterField(ref Player player)
        {
            while (true)
            {
                Console.WriteLine("필드에 접속했습니다");
                Monster monster;
                //랜덤으로 1~3 몬스터중 하나 리스폰
                CreateMonster(out monster);
                Console.WriteLine("[1] 전투모드로 돌입");
                Console.WriteLine("[2] 일정 확률로 마을로 도망");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Fight(ref player,ref monster );
                        break;

                    case "2":
                        Random rand = new Random();
                        int randValue = rand.Next(0, 101);
                        if (randValue <= 33)
                        {
                            Console.WriteLine("또망치는데 성공했습니다");
                            return;
                            
                        }
                        else 
                        {
                            Fight(ref player, ref monster);
                            break;
                        }

                    default:
                        break;
                }
            }
            
        }

        private static void Fight(ref Player player, ref Monster monster)
        {
            while (true)
            {
                //플레이어가 몬스터 공격
                monster.hp -= player.attack;
                if(monster.hp<= 0)
                {
                    Console.WriteLine("승리했습니다");
                    Console.WriteLine($"남은체력{player.hp}");
                    break;
                }
                //몬스터가 플레이어 공격
                player.hp -= monster.attack;
                if (player.hp <= 0)
                {
                    Console.WriteLine("패배했습니다");
                    break;
                }
            }
        }

        private static void CreateMonster(out Monster monster)
        {
            Random rand = new Random();
            int randMonster = rand.Next(1, 4);
            switch (randMonster)
            {
                case (int)MonsterType.Slime:
                    Console.WriteLine("슬라임이 스폰되었습니다");
                    monster.hp = 20;
                    monster.attack = 3;
                    break;
                case (int)MonsterType.Orc:
                    Console.WriteLine("오크가 스폰되었습니다");
                    monster.hp = 40;
                    monster.attack = 15;
                    break;
                case (int)MonsterType.Skeleton:
                    Console.WriteLine("해골병사가 스폰되었습니다");
                    monster.hp = 50;
                    monster.attack = 3;
                    break;
                default:
                    monster.hp = 0;
                    monster.attack = 0;
                    break;

            }
        }

        private static void CreatePlayer(PlayerType choice, out Player player)
        {
            //out을 받았으면 무조건 사용해야한다.

            switch (choice)
            {
                case PlayerType.Knight:
                    player.hp = 100;
                    player.attack = 10;
                    break;

                case PlayerType.Archer:
                    player.hp = 50;
                    player.attack = 15;
                    break;

                case PlayerType.Mage:
                    player.hp = 20;
                    player.attack = 20;
                    break;

                default:
                    player.hp = 0;
                    player.attack = 0;
                    break;
            }
            Console.WriteLine($"HP{player.hp} Attack{player.attack}");
        }

        
    }
}