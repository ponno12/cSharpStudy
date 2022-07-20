using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Fundamentals
{

    // 에러 종류
    //
    /*ArithmeticException	DivideByZeroException, OverflowException 등의 산술 연산 중에 발생하는 예외에 대한 기본 클래스입니다.
    ArrayTypeMismatchException 제공된 요소의 실제 형식이 배열의 실제 형식과 호환되지 않아 배열이 요소를 저장할 수 없는 경우 throw됩니다.
    DivideByZeroException 정수 값을 0으로 나누려고 시도할 경우 throw됩니다.
    IndexOutOfRangeException 인덱스가 0보다 작거나 배열 경계를 벗어날 때 배열을 인덱싱하려고 시도할 경우 throw됩니다.
    InvalidCastException 런타임에 기본 형식에서 인터페이스 또는 파생 형식으로의 명시적 변환이 실패할 때 throw됩니다.
    NullReferenceException 값이 null인 개체를 참조하려고 시도할 경우 throw됩니다.
    OutOfMemoryException    new 연산자를 사용한 메모리 할당 시도가 실패할 경우 throw됩니다.이 예외는 공용 언어 런타임에 사용할 수 있는 메모리가 모두 사용되었음을 나타냅니다.
    OverflowException   checked 컨텍스트의 산술 연산이 오버플로될 경우 throw됩니다.
    StackOverflowException 보류 중인 메서드 호출이 너무 많아 실행 스택이 모두 사용될 경우 throw됩니다.대개 매우 깊은 재귀나 무한 재귀를 나타냅니다.
    TypeInitializationException*/

    public class ExceptionNError
    {
        static double SafeDivision(double x, double y)
        {
            if (y == 0)
                throw new DivideByZeroException();
            return x / y;
        }

        /*public static void Main()
        {
            // Input for test purposes. Change the values to see
            // exception handling behavior.
            double a = 98, b = 0;
            double result;

            try
            {
                result = SafeDivision(a, b);
                Console.WriteLine("{0} divided by {1} = {2}", a, b, result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Attempted divide by zero.");
            }
        }*/
    }
}
