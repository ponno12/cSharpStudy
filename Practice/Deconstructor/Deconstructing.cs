namespace Practice
{

    class Deconstructing
    {
        // 참조 docs : https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/functional/deconstruct
        private static (string, int, double) QueryCityData(string name)
        {
            if (name == "New York City")
                return (name, 8175133, 468.48);

            return ("", 0, 0);
        }
        //튜플 및 기타 형식 분해
        /*public static void Main()
        {
            var result = QueryCityData("New York City");

            var city = result.Item1;
            var population = result.Item2;
            var area = result.Item3;

            // 위와 같은 결과를 밑의 한줄짜리 코드로도 얻기가능

            var (city2, population2, area2) = QueryCityData("New York City");
            //var 대신 직접적인 형식 대입도 가능
            (string city3, var population3, var area3) = QueryCityData("New York City");
        }*/
    }
}
