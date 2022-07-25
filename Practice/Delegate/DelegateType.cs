using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Delegate
{
    public class DelegateTypeExample
    {
        // void 반환받는 대리자들을 선언하는 방식, 좀더 안정하고 구체적인 대리자 형식 선언가능
        public delegate void Action();
        public delegate void Action<in T>(T arg);
        public delegate void Action<in T1, in T2>(T1 arg1, T2 arg2);
            
        // 반환형식이 있는 대리자들, out이나 ref를 매개변수로 받는 경우에도 func를 사용해야한다.
        public delegate TResult Func<out TResult>();
        public delegate TResult Func<in T1, out TResult>(T1 arg);
        public delegate TResult Func<in T1, in T2, out TResult>(T1 arg1, T2 arg2);

        //단일 값을 반환하는 특수 대리자로 Prediccate가 있다.
        public delegate bool Predicate<in T>(T obj);
        public static void DelegateType()
        {

        }
    }
}
