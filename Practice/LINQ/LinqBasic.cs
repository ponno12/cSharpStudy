namespace Practice.LINQ
{
    public class LINQEample
    {
        public static  void LINQ()
        {
            //from으로 시작해서 select나 group절로 끝내야함.
            // 데이터 세팅
            int[] scores = { 90, 71, 82, 93, 75, 82 };

            // 쿼리 표현식 정리.
            IEnumerable<int> scoreQuery =
                from score in scores
                where score > 80
                select score;

            //쿼리실행
            //위에 쿼리는 실제 데이터를 가지고있는게 아니라 foreach문이 돌아갈때 데이터를 생성해준다.
            foreach (int i in scoreQuery)
            {
                Console.WriteLine(i + " ");
            }

            // Output: 97 92 81

            // 조건이 들어가는 linq
            IEnumerable<int> highScoresQuery =
                from score in scores
                where score > 80
                orderby score descending
                select score;

            foreach (var item in highScoresQuery.Select((value,i) => new {value, i }))
            {
                Console.Write(item.i + " : ");
                Console.WriteLine(item.value);
                
            }
            for (int i = 0; i < highScoresQuery.Count(); i++)
            {
                Console.WriteLine("hightsocre enum  : " + highScoresQuery.GetEnumerator().Current);
                highScoresQuery.GetEnumerator().MoveNext();
            }
            var cities = new List<City>();
            //둘은 같은형태다
            IEnumerable<City> queryMajorCities =
                from city in cities
                where city.Population > 100000
                select city;
            // citeis안에 고른다는 명시가 있으므로 from in cities 생략 city를 c로 단순 표현
            IEnumerable<City> queryMajorCities2 = cities.Where(c => c.Population > 100000);

            

            // 다음과 같이 쿼리를 작성한 다음,그중에서 값 할당도 가능함
            IEnumerable<int> scoreQuery2 =
                from score in scores
                select score;

            // 밑의 세 변수는 결국 같은 값을 리턴한다.
            int highScore = scoreQuery2.Max();
            highScore = scores.Max();
            //highscore는 쿼리문이 아닌 변수이기때문에 값이 저장된다.
            int highestScore = (
                from score in scores
                select score
            ).Max();



            // Linq로 List 반환
            // 개인적으론 1번 선호
            cities.Add(new City(100));
            var countries = new List<Country>();
            
            countries.Add(new Country(cities,"Seoul"));
            List<City> largeCitiesList = (
                from country in countries
                from city in country.Cities
                where city.Population > 10000
                select city
            ).ToList();

            // 밑에와 같이 쿼리를짜고 나중에 집어넣기도 가능
            IEnumerable<City> largeCitiesQuery =
                from country in countries
                from city in country.Cities
                where city.Population > 10000
                select city;

            List<City> largeCitiesList2 = largeCitiesQuery.ToList();

            // group
            var queryCountryGroups =
                from country in countries
                group country by country.Name[0];
            foreach (var item in queryCountryGroups)
            {
                foreach (var i in item)
                {
                    Console.WriteLine(i.Name);
                }
            }

            // Filtering
            // Where, Join, Order by, from, let 

            //Join
            /*var categoryQuery =
                from cat in categories
                join prod in products on cat equals prod.Category
                select new
                {
                    Category = cat,
                    Name = prod.Name
                };*/

            // LINQ내용이 워낙 많으니 일단 여기까지만 정리
            // https://docs.microsoft.com/ko-kr/dotnet/csharp/linq/write-linq-queries 이어서 학습

        }
        public class City
        {
            public int Population { get; set; }
            public City(int population)
            {
                Population = population;
            }
        }
        public class Country
        {
            public Country(List<City> cities, string name)
            {
                Cities = cities;
                Name = name;
            }

            public List<City> Cities { get; set; }
            public string Name { get; set; }
        }
    }
}


