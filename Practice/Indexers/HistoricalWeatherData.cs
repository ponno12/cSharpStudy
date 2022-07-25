


using CityDataMeasurements =
    System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<System.DateTime, Practice.Indexers.Measurements>>;
using DateMeasurements =
    System.Collections.Generic.Dictionary<System.DateTime, Practice.Indexers.Measurements>;

namespace Practice.Indexers
{
    public class HistoricalWeatherData
    {
        readonly CityDataMeasurements storage = new CityDataMeasurements();

        public Measurements this[string city, DateTime date]
        {
            get
            {
                var cityData = default(DateMeasurements);

                if (!storage.TryGetValue(city, out cityData))
                    throw new ArgumentOutOfRangeException(nameof(city), "City not found");

                // strip out any time portion:
                var index = date.Date;
                var measure = default(Measurements);
                if (cityData.TryGetValue(index, out measure))
                    return measure;
                throw new ArgumentOutOfRangeException(nameof(date), "Date not found");
            }
            set
            {
                var cityData = default(DateMeasurements);

                if (!storage.TryGetValue(city, out cityData))
                {
                    cityData = new DateMeasurements();
                    storage.Add(city, cityData);
                }

                // Strip out any time portion:
                var index = date.Date;
                cityData[index] = value;
            }
        }
    }
}
