using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Property
{
    //속성을 참고하는 다른 속성이 존재할때, 참고되는 속성이 변경되면 참고하는 속성이 유효한지 확인후 반환
    public class PersonValueChange
    {
        private string firstName;
        public string FirstName
        {
            get => firstName;
            set
            {
                firstName = value;
                fullName = null;
            }
        }

        private string lastName;
        public string LastName
        {
            get => lastName;
            set
            {
                lastName = value;
                fullName = null;
            }
        }

        private string fullName;
        public string FullName
        {
            get
            {
                if (fullName == null)
                    fullName = $"{FirstName} {LastName}";
                return fullName;
            }
        }
    }
}
