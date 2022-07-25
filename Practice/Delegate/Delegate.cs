using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Delegate
{
    public class DelegateExample
    {
        // in 한정자를 사용하면 참조로 전달되지만 수정되진 않음 const 같은 역할
        // 다음과 같이 선언해서 사용
        public delegate int Comparison<in T>(T left, T right);


        public static void DelegateBasic()
        {
            string left = "", right = "";
            //comparer과 comparer2는 같음, delegate경우 new 연산자 사용없이 바로 선언가능
            Comparison<string> comparer = new Comparison<string>(CompareLength);
            Comparison<string> comparer2 = CompareLength;

            int result = comparer(left, right);

        }
        private static int CompareLength(string left, string right) =>
        left.Length.CompareTo(right.Length);
    }
}
