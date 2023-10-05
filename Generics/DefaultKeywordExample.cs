namespace Generics;

public static class DefaultKeywordExample
{
    public static void Run()
    {
        int intDefault = default;
        string stringDefault = default;
        
        Console.WriteLine($"intDefault: {intDefault} | stringDefault: {stringDefault}");
        Console.WriteLine("As we can see with primitives, default keyword returns the default value of the type.");
        
        Console.WriteLine("-------------------------------------------------------------------------------------");
        
        PersonClass personClassDefault = default(PersonClass);
        PersonStruct personStructDefault = default; // Type inference
        PersonStruct? personStructNullableDefault = default; 
        Console.WriteLine($"personClassDefault: {personClassDefault} | personStructDefault: {personStructDefault}" +
                          $" | personStructNullableDefault: {personStructNullableDefault}");
        Console.WriteLine("With reference types (classes), default keyword returns null. With value types (structs), " +
                          "default keyword returns a new instance of the type with all fields set to their default values."
                          + "\n With nullable value types, default keyword returns null.");
        
        Console.WriteLine("-------------------------------------------------------------------------------------");
        Console.WriteLine("In fact almost all primitive types in C# are structs hiding behind keywords. For example, " +
                          "int is actually System.Int32, string is actually System.String, etc.");
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

    private struct PersonStruct
    {
        public int age;
        public string name;

        public PersonStruct()
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

