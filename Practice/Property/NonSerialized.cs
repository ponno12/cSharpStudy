using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Property
{
    public class NonSerializedIdPerson
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        //non serialized 특성이 선언되어있으면 ID는 상속받지도 하지도 않는 고유한 값으로 사용
        //사람마다 다른값을 사용함을 명시
        //필드에만 사용가능
        [field: NonSerialized]
        public int Id { get; set; }

        public string FullName => $"{FirstName} {LastName}";
    }
}
