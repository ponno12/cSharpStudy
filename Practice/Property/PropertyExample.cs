using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Property
{
    public class PersonBase
    {
        //함수 Initialize로 처음 값을 할당하고 다른곳에서 값을 얻을순 있지만 지정은 Person에서만 가능하게
        public PersonBase(string firstName) => this.FirstName = firstName;

        public string LastName { get; set; }
        
        public string FirstName { get; private set; }

        //똑같이 FullName을 설정하는거지만 단일 속성일 경우에는 밑처럼 람다로 바로 처리가능
        //public string FullName { get { return $"{FirstName} {LastName}"; } }
        public string FullName => $"{FirstName} {LastName}";
    }
}
