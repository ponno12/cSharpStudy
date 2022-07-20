// WorkItem implicitly inherits from the Object class.
// WorkItem은 오브젝트 클래스에서 기반합니다.
public class WorkItem_Inheritance
{
    // Static field currentID stores the job ID of the last WorkItem that
    // has been created.
    // 스태틱필드인 currentId는 마지막으로 생성된 아이디를 기억합니다.
    private static int currentID;

    //Properties.
    protected int ID { get; set; }
    protected string Title { get; set; }
    protected string Description { get; set; }
    protected TimeSpan jobLength { get; set; }

    // Default constructor. If a derived class does not invoke a base-
    // class constructor explicitly, the default constructor is called
    // implicitly.
    // 따로 메개변수를 지정하지 않고 생성할시 아래와 같은 명시된 데이터를 삽입합니다.
    public WorkItem_Inheritance()
    {
        ID = 0;
        Title = "Default title";
        Description = "Default description.";
        jobLength = new TimeSpan();
    }

    // Instance constructor that has three parameters.
    public WorkItem_Inheritance(string title, string desc, TimeSpan joblen)
    {
        this.ID = GetNextID();
        this.Title = title;
        this.Description = desc;
        this.jobLength = joblen;
    }

    // Static constructor to initialize the static member, currentID. This
    // constructor is called one time, automatically, before any instance
    // of WorkItem or ChangeRequest is created, or currentID is referenced.
    static WorkItem_Inheritance() => currentID = 0;

    // currentID is a static field. It is incremented each time a new
    // instance of WorkItem is created.
    protected int GetNextID() => ++currentID;

    // Method Update enables you to update the title and job length of an
    // existing WorkItem object.
    public void Update(string title, TimeSpan joblen)
    {
        this.Title = title;
        this.jobLength = joblen;
    }

    // Virtual method override of the ToString method that is inherited
    // from System.Object.
    public override string ToString() =>
        $"{this.ID} - {this.Title}";
}

// ChangeRequest derives from WorkItem and adds a property (originalItemID)
// and two constructors.
public class ChangeRequest : WorkItem_Inheritance
{
    protected int originalItemID { get; set; }

    // Constructors. Because neither constructor calls a base-class
    // constructor explicitly, the default constructor in the base class
    // is called implicitly. The base class must contain a default
    // constructor.

    // Default constructor for the derived class.
    public ChangeRequest() { }

    // Instance constructor that has four parameters.
    public ChangeRequest(string title, string desc, TimeSpan jobLen,
                         int originalID)
    {
        // The following properties and the GetNexID method are inherited
        // from WorkItem.
        this.ID = GetNextID();
        this.Title = title;
        this.Description = desc;
        this.jobLength = jobLen;

        // Property originalItemId is a member of ChangeRequest, but not
        // of WorkItem.
        this.originalItemID = originalID;
    }

    public static void WorkItem()
    {
        // Create an instance of WorkItem by using the constructor in the
        // base class that takes three arguments.
        WorkItem_Inheritance item = new ("Fix Bugs",
                                    "Fix all bugs in my code branch",
                                    new TimeSpan(3, 4, 0, 0));

        // Create an instance of ChangeRequest by using the constructor in
        // the derived class that takes four arguments.
        ChangeRequest change = new ChangeRequest("Change Base Class Design",
                                                "Add members to the class",
                                                new TimeSpan(4, 0, 0),
                                                1);

        // Use the ToString method defined in WorkItem.
        Console.WriteLine(item.ToString());

        // Use the inherited Update method to change the title of the
        // ChangeRequest object.
        change.Update("Change the Design of the Base Class",
            new TimeSpan(4, 0, 0));

        // ChangeRequest inherits WorkItem's override of ToString.
        Console.WriteLine(change.ToString());
        
            /* Output:
            1 - Fix Bugs
            2 - Change the Design of the Base Class
            */
            
    }
}

