using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleGatePrac
{
    class InputManager
    {
        public delegate void OnInputKey();
        public event OnInputKey InputKey;  // public 접근 한정자까지 똑같이 맞춰주어야 함

        public void Update()
        {
            
            if (Console.KeyAvailable == false)
                return;

            ConsoleKeyInfo info = Console.ReadKey();
            if (info.Key == ConsoleKey.A)  // A 키가 눌리면 이벤트 호출
            {
                InputKey();  // 구독자들에게 메세지 뿌리기 👉 옵저버 패턴
            }
        }
    }
}
 