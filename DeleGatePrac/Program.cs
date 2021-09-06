using System;

namespace DeleGatePrac
{
    class Program
    {
        static void OnInputTest()
        {
            Console.WriteLine("Input Received!");
        }

        static void Main(string[] args)
        {
            InputManager inputManager = new InputManager();
            inputManager.InputKey += OnInputTest;
            Type type = inputManager.GetType();
            var fields = type.GetFields(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic);
            while (true)
            {
                inputManager.Update();
            }

            // inputManager.InputKey(); 컴파일 에러! 외부에서 호출 불가능
        }
    }
}
