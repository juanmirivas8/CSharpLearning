namespace Generics;

public static class IComparableExample
{
    public static void Run()
    {
        var people = new List<Person>
        {
            new Student { Name = "John", Age = 18, Grade = 12 },
            new Student { Name = "Jane", Age = 19, Grade = 12 },
            new Student { Name = "Joe", Age = 18, Grade = 11 },
            new Student { Name = "Jill", Age = 17, Grade = 12 },
            new Student { Name = "Jack", Age = 18, Grade = 12 },
        };
        
        people.Sort();
        
        foreach (var person in people)
        {
            Console.WriteLine($"{person.Name} is {person.Age} years old");
        }
        
        var students = new List<Student>
        {
            new Student { Name = "John", Age = 18, Grade = 12 },
            new Student { Name = "Jane", Age = 19, Grade = 12 },
            new Student { Name = "Joe", Age = 18, Grade = 11 },
            new Student { Name = "Jill", Age = 17, Grade = 12 },
            new Student { Name = "Jack", Age = 18, Grade = 12 },
        };
        
        students.Sort();
        
        foreach (var student in students)
        {
            Console.WriteLine($"{student.Name} is {student.Age} years old and in grade {student.Grade}");
        }
    }
    private abstract class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public int CompareTo(Person? other)
        {
            return this switch
            {
                Student student when other is Student otherStudent=> student.CompareTo(otherStudent),
                _ => this.Age.CompareTo(other?.Age)
            };
        }
        
        public static bool operator <(Person left, Person right)
        {
            return left.CompareTo(right) < 0;
        }
        
        public static bool operator >(Person left, Person right)
        {
            return left.CompareTo(right) > 0;
        }
    }
    
    private class Student : Person, IComparable<Student>
    {
        public int Grade { get; set; }
        
        public int CompareTo(Student? other)
        {
            return this.Grade.CompareTo(other?.Grade);
        }
    }
}