// 예제(5) 레코드에 Constructor/Deconstructor 사용

/* Record C# 9.0에서 추가된 기능
 * 기본적으로 값비교를 할때 사용함 class 는 참조 비교
 * 불변성또한 가지고 있지만 with을 통해 특정값 변환 가능
 * Entity core랑은 호환이 좋지않아 사용않는게 좋음
 */
public record PersonRecord
{
    public string Name { get; init; }
    public int Age { get; init; }
    public PersonRecord(string name, int age)
        => (this.Name, this.Age) = (name, age);
    public void Deconstruct(out string name, out int age)
        => (name, age) = (Name, Age);
    ~PersonRecord() =>  Console.WriteLine($"소멸자 호출 {Name} & {Age}");
    
}

//예제(6) Positional record
//public record PersonRecord(string Name, int Age);

// 예제(7) 
class RecordPrac
{
    /*static void Main(string[] args)
    {
        // Constructor 사용
        PersonRecord tom = new PersonRecord("Tom", 30);

    // Deconstructor 사용
   var (name, age) = tom;

    Console.WriteLine($"{name}, {age}");
}*/
}