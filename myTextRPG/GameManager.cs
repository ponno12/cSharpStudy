using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myTextRPG
{
    
    public enum GameMode
    {
        None,
        Lobby,
        Town,
        Field,
        
    }
    class GameManager
    {
        private GameMode mode = GameMode.None;
        private Player player = null;
        public void Proecess()
        {
            switch (mode)
            {
                case GameMode.Lobby:
                    ProcessLobby();
                    break;
                case GameMode.Town:
                    ProcessTown();
                    break;
                case GameMode.Field:
                    break;
            }
        }

        public void ProcessTown()
        {
            Console.WriteLine("마을에 입장했습니다.");
            Console.WriteLine("[1] 필드로가기");
            Console.WriteLine("[2] 로비로 돌아가기");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    mode = GameMode.Field;
                    break;
                case "2":
                    mode = GameMode.Lobby;
                    break;
                default:
                    break;
            }
        }

        private void ProcessLobby()
        {   
            Console.WriteLine("직업을 선택하세요");
            Console.WriteLine("[1] 기사");
            Console.WriteLine("[2] 궁수");
            Console.WriteLine("[3] 법사");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    new Knight();
                    mode = GameMode.Town;
                    break;

                case "2":
                    new Archer();
                    mode = GameMode.Town;
                    break;

                case "3":
                    new Mage();
                    mode = GameMode.Town;
                    break;
                
                default:
                    break;
            }
        }
    }
}
