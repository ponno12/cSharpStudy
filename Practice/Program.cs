using Practice.Delegate;
namespace Practice
{
    public class ProgramTest
    {
        public static void Main()
        {

            // 메소드 상속
            // TestMotorcycle.Method();

            // 메소드 참조 매개변수
            // RefSwapExample.RefSwap();

            // 메소도 배열 매개변수
            // ParamsExample.Param();

            // Async메소드
            // 메인 반환형에 async task 작성해야함
            // await AsyncMethodExample.AsyncMethod();

            // Iterator
            // Iterators.IteratorsExample.Iteraotr();

            // Delegate
            // DelegateSortExample sample = new ();
            // sample.DelegateSort();
            //DelegateLINQExample.DelegateLINQ();

            // LINQ
            //LINQ.LINQEample.LINQ();
            //LINQ.GroupSample1.GroupByBool();

            // Expression Tree
            //ExpressionTrees.ExpressionTreeExample.ExpressionTreeBasic();




            // Lanaguage 에제
            //Language_reference.OperatorOverLoadingExample.OpearatorOverLoading();

            //Extension 예제
            string s = "The quick brown fox jumped over the lazy dog.";
            int i = s.WordCount();
            Console.WriteLine("Word count of s is {0}", i);
            Extensions.Grades g1 = Extensions.Grades.D;
            Extensions.Grades g2 = Extensions.Grades.F;

            Extensions.minPassing = Extensions.Grades.C;
            Console.WriteLine("\r\nRaising the bar!\r\n");
            Console.WriteLine("First {0} a passing grade.", g1.Passing() ? "is" : "is not");
            Console.WriteLine("Second {0} a passing grade.", g2.Passing() ? "is" : "is not");
        }
    }

}