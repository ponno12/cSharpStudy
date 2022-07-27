namespace Practice.LINQ
{
    public class LINQEample
    {
        public static  void LINQ()
        {
            //from���� �����ؼ� select�� group���� ��������.
            // ������ ����
            int[] scores = { 90, 71, 82, 93, 75, 82 };

            // ���� ǥ���� ����.
            IEnumerable<int> scoreQuery =
                from score in scores
                where score > 80
                select score;

            //��������
            //���� ������ ���� �����͸� �������ִ°� �ƴ϶� foreach���� ���ư��� �����͸� �������ش�.
            foreach (int i in scoreQuery)
            {
                Console.WriteLine(i + " ");
            }

            // Output: 97 92 81

            // ������ ���� linq
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
            //���� �������´�
            IEnumerable<City> queryMajorCities =
                from city in cities
                where city.Population > 100000
                select city;
            // citeis�ȿ� ���ٴ� ��ð� �����Ƿ� from in cities ���� city�� c�� �ܼ� ǥ��
            IEnumerable<City> queryMajorCities2 = cities.Where(c => c.Population > 100000);

            

            // ������ ���� ������ �ۼ��� ����,���߿��� �� �Ҵ絵 ������
            IEnumerable<int> scoreQuery2 =
                from score in scores
                select score;

            // ���� �� ������ �ᱹ ���� ���� �����Ѵ�.
            int highScore = scoreQuery2.Max();
            highScore = scores.Max();
            //highscore�� �������� �ƴ� �����̱⶧���� ���� ����ȴ�.
            int highestScore = (
                from score in scores
                select score
            ).Max();



            // Linq�� List ��ȯ
            // ���������� 1�� ��ȣ
            cities.Add(new City(100));
            var countries = new List<Country>();
            
            countries.Add(new Country(cities,"Seoul"));
            List<City> largeCitiesList = (
                from country in countries
                from city in country.Cities
                where city.Population > 10000
                select city
            ).ToList();

            // �ؿ��� ���� ������¥�� ���߿� ����ֱ⵵ ����
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

            // LINQ������ ���� ������ �ϴ� ��������� ����
            // https://docs.microsoft.com/ko-kr/dotnet/csharp/linq/write-linq-queries �̾ �н�

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


