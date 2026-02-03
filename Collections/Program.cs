
using Collections;
using Collections.StudentManagement;

//StudentManagement studentManagement = new StudentManagement();
//studentManagement.Start();



Console.WriteLine("--- Integer Stack ---");
Stapel<int> intStapel = new Stapel<int>();
intStapel.Push(1);
intStapel.Push(2);
intStapel.Push(3);

Console.WriteLine($"Stack count: {intStapel.Count}");
intStapel.Display();

int val = intStapel.Pop();
Console.WriteLine($"Popped value: {val}");
Console.WriteLine($"Peek at top: {intStapel.Peek()}");
Console.WriteLine($"Stack count after pop: {intStapel.Count}\n");

//int maxInt = MyCompare.Maximum(0, 1);


//string maxStr = MyCompare.Maximum("Anna", "Zoe");

//var s1 = new Student();
//s1.Id = 1;

//var s2 = new Student();
//s2.Id = 2;

//Student highestStudent = MyCompare.Maximum(s1, s2);
//Console.WriteLine(highestStudent.Id);
class MyStack<T>
{
    private T[] _items = new T[10];
    public void Push(T item)
    {
        _items[0] = item;
    }

    public T Pop()
    {
        return _items[0];
    }
}

class Student : IComparable<Student>
{
    public int Id { get; set; }

    public int CompareTo(Student? other)
    {
        if(other == null) return 1;
        if (this.Id  < other.Id) return -1;
        if (this.Id == other.Id) return 0;
        return 1;
    }
}

class MyCompare
{
    public static T Maximum<T>(T a, T b) where T : IComparable<T>
    {
        return a.CompareTo(b) > 0 ? a : b;
    }
}