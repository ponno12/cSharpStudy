using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Practice.Fundamentals
{


    public class PatternMatching
    {
        //형식 테스트
        public static T MidPoint<T>(IEnumerable<T> sequence)
        {
            //sequence가 IList일 경우 중간에 있는 값을 반환, list에 sequence값을 대입
            if (sequence is IList<T> list)
            {
                return list[list.Count / 2];
            }
            // n
            else if (sequence is null)
            {
                throw new ArgumentNullException(nameof(sequence), "Sequence can't be null.");
            }
            else
            {
                //IList가 아닌 IEnumable을 전부 지원
                //skip 메소드를 넣으면 매개변수만큼 건너띄고 처음걸 가져오는 방향으로 구현되어있음
                int halfLength = sequence.Count() / 2 - 1;
                if (halfLength < 0) halfLength = 0;
                return sequence.Skip(halfLength).First();
            }
        }
        //State, Opearation를 따로 만들어야 해서 나중에 테스트 해보자
        // https://docs.microsoft.com/ko-kr/dotnet/csharp/fundamentals/functional/pattern-matching


        /*//개별 값 비교
        public State PerformOperation(Operation command) =>
           command switch
           {
               Operation.SystemTest => RunDiagnostics(),
               Operation.Start => StartSystem(),
               Operation.Stop => StopSystem(),
               Operation.Reset => ResetToReady(),
               _ => throw new ArgumentException("Invalid enum value for command", nameof(command)),
           };
        public State PerformOperation(string command) =>
           command switch
           {
               "SystemTest" => RunDiagnostics(),
               "Start" => StartSystem(),
               "Stop" => StopSystem(),
               "Reset" => ResetToReady(),
               _ => throw new ArgumentException("Invalid string value for command", nameof(command)),
           };*/

        /*public static void Main()
        {
            int? maybe = 12;

            // is int 형식으로 하게 되면 앞에 있는것을 뒤로 보내주는듯 원래 이즈는 단순하게 bool값만 
            if (maybe is int number)
            {
                Console.WriteLine($"The nullable int 'maybe' has the value {number}");
            }
            else
            {
                Console.WriteLine("The nullable int 'maybe' doesn't hold a value");
            }

            if (maybe is int)
            {
                Console.WriteLine($"The nullable int 'maybe' has the value int");
            }
            else
            {
                Console.WriteLine("The nullable int 'maybe' doesn't hold a value");
            }
        }*/

    }
}
