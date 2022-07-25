namespace CusteomDecon
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

    public class ExampleClassDeconstruction
    {
        public static void ClassDeconstruction()
        {
            var p = new Person("John", "Quincy", "Adams", "Boston", "MA");
            Console.WriteLine(p.GetType());
            // Deconstruct the person object.
            var (fName, lName, city, state) = p;
            Console.WriteLine($"Hello {fName} {lName} of {city}, {state}!");

            var (fName2, _, city2, _) = p;
            Console.WriteLine($"Hello {fName2} of {city2}!");

        }
    }
    // The example displays the following output:
    //    Hello John Adams of Boston, MA!

}
