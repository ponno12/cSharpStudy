using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Property
{
    public class InitializePropertyExample
    {

        public class Contact
        {
            public string Name { get; }
            public string Address { get; private set; }

            public Contact(string contactName, string contactAddress)
            {
                // 두 속성다 접근가능함
                Name = contactName;
                Address = contactAddress;
            }

            // Name은 읽기만 구현되어 있으므로 쓰기시 컴파일에러.
            // public void ChangeName(string newName) => Name = newName; 불가능
            public void ChangeAddress(string newAddress) => Address = newAddress;
        }

        
        public class Contact2
        {
            public string Name { get; private set; }

            public string Address { get; }

            private Contact2(string contactName, string contactAddress)
            {
                Name = contactName;
                Address = contactAddress;
            }

            public static Contact2 CreateContact(string name, string address)
            {
                return new Contact2(name, address);
            }
        }
        public static void InitializeProperty()
        {
            //데이터 선언
            string[] names = {"Terry Adams","Fadi Fakhouri", "Hanying Feng",
                            "Cesar Garcia", "Debra Garcia"};
            string[] addresses = {"123 Main St.", "345 Cypress Ave.", "678 1st Ave",
                                "12 108th St.", "89 E. 42nd St."};

            var query1 = from i in Enumerable.Range(0, 5)
                         select new Contact(names[i], addresses[i]);

            var list = query1.ToList();
            foreach (var contact in list)
            {
                Console.WriteLine("{0}, {1}", contact.Name, contact.Address);
            }

            var query2 = from i in Enumerable.Range(0, 5)
                         select Contact2.CreateContact(names[i], addresses[i]);

            var list2 = query2.ToList();

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
