using Practice.MethodExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class ProgramTest
    {
        public static async Task Main()
        {

            //메소드 상속
            //TestMotorcycle.Method();

            //메소드 참조 매개변수
            //RefSwapExample.RefSwap();

            //메소도 배열 매개변수
            //ParamsExample.Param();

            //Async메소드
            
            await AsyncMethodExample.AsyncMethod();
        }

        
    }
    
}