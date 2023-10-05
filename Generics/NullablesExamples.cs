namespace Generics;

public static class NullablesExamples
{
    public static void Run()
    {
        Console.WriteLine("T? is a shorthand for Nullable<T>");
        
        Nullable<DateTime> nullableDate = null;
        PersonClass? nullablePersonClass = new(); // Type inference
        
    }
    
    private class PersonClass
    {
        public int age;
        public string name;

        public PersonClass()
        {
            age = 18;
            name = "John";
        }

        public override string ToString()
        {
            return $"Name: {name}, Age: {age}";
        }
    }
}