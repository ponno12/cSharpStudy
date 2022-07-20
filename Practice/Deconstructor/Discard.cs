using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discard
{
    public class Discard
    {
        public class Person
        {
            public string FirstName { get; set; }
            public string MiddleName { get; set; }
            public string LastName { get; set; }
            public string City { get; set; }
            public string State { get; set; }

            public Person(string fname, string mname, string lname,
                          string cityName, string stateName)
            {
                FirstName = fname;
                MiddleName = mname;
                LastName = lname;
                City = cityName;
                State = stateName;
            }

            // Return the first and last name.
            public void Deconstruct(out string fname, out string lname)
            {
                fname = FirstName;
                lname = LastName;
            }

            public void Deconstruct(out string fname, out string mname, out string lname)
            {
                fname = FirstName;
                mname = MiddleName;
                lname = LastName;
            }

            public void Deconstruct(out string fname, out string lname,
                                    out string city, out string state)
            {
                fname = FirstName;
                lname = LastName;
                city = City;
                state = State;
            }
        }

        /*public static void Main()
        {

            #region QueryCity
            var (_, _, _, pop1, _, pop2) = QueryCityDataForYears("New York City", 1960, 2010);

            Console.WriteLine($"Population change, 1960 to 2010: {pop2 - pop1:N0}");

            static (string, double, int, int, int, int) QueryCityDataForYears(string name, int year1, int year2)
            {
                int population1 = 0, population2 = 0;
                double area = 0;

                if (name == "New York City")
                {
                    area = 468.48;
                    if (year1 == 1960)
                    {
                        population1 = 7781984;
                    }
                    if (year2 == 2010)
                    {
                        population2 = 8175133;
                    }
                    //튜플로 반환된다.
                    return (name, area, year1, population1, year2, population2);
                }

                return ("", 0, 0, 0, 0, 0);
            }
            // The example displays the following output:
            //      Population change, 1960 to 2010: 393,149

            #endregion

            #region Person
            var p = new Person("John", "Quincy", "Adams", "Boston", "MA");

            // Deconstruct the person object.
            var (fName, _, city, _) = p;
            Console.WriteLine($"Hello {fName} of {city}!");
            // The example displays the following output:
            //      Hello John of Boston!
            #endregion

            #region DateTime
            string[] dateStrings = {"05/01/2018 14:57:32.8", "2018-05-01 14:57:32.8",
                      "2018-05-01T14:57:32.8375298-04:00", "5/01/2018",
                      "5/01/2018 14:57:32.80 -07:00",
                      "1 May 2018 2:57:32.8 PM", "16-05-2018 1:00:32 PM",
                      "Fri, 15 May 2018 20:10:57 GMT" };
            foreach (string dateString in dateStrings)
            {
                if (DateTime.TryParse(dateString, out _))
                    Console.WriteLine($"'{dateString}': valid");
                else
                    Console.WriteLine($"'{dateString}': invalid");
            }
            #endregion


        }*/


    }
}
