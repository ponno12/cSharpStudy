namespace Practice.Fundamentals
{
    //인터페이스에는 인스턴스 메서드, 속성, 이벤트, 인덱서 또는 이러한 네 가지 멤버 형식의 조합이 포함될 수 있습니다.
    #region IEquatable
    interface IEquatable<T>
    {
        bool Equals(T obj);
    }
    public class Car : IEquatable<Car>
    {
        public string? Make { get; set; }
        public string? Model { get; set; }
        public string? Year { get; set; }

        // Implementation of IEquatable<T> interface
        public bool Equals(Car? car)
        {
            return (Make, Model, Year) ==
                (car?.Make, car?.Model, car?.Year);
        }
    }
    #endregion
    #region ICustomer
    public interface ICustomer
    {
        IEnumerable<IOrder> PreviousOrders { get; }

        DateTime DateJoined { get; }
        DateTime? LastOrder { get; }
        string Name { get; }
        IDictionary<DateTime, string> Reminders { get; }
    }
    public interface IOrder
    {
        DateTime Purchased { get; }
        decimal Cost { get; }
    }
    #endregion
    class Interface
    {
        /*static void Main()
        {
            var car1 = new Car() { Make = "현대", Model = "아이오닉", Year = "2019" };
            var car2 = new Car() { Make = "현대", Model = "아이오닉", Year = "2019" };

            Console.WriteLine(car1.Equals(car2)); 
        }*/
    }
}
