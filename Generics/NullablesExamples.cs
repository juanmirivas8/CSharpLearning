namespace Generics;

public static class NullablesExamples
{
    public static void RunNullableTheoryExplained()
    {
        DateTime? nullableDate = null;
        
        Console.WriteLine($"Value types like {typeof(DateTime)} can be made nullable by using the Nullable<T> struct or by placing an ? after the type" +
                          $"\nNullable<T> is a struct that has a bool HasValue and a T Value field. " +
                          $"\nWhen HasValue is false, Value is undefined. " +
                          $"\nWhen HasValue is true, Value is the value of the nullable type." +
                          $"\nExample -- DateTime? nullableDate = null; --  : {nameof(nullableDate)}. {nameof(nullableDate.HasValue)}: {nullableDate.HasValue}");
        Console.WriteLine("-------------------------------------------------------------------------------------");
        Console.WriteLine(" What we can infer from the previous sentence are the following:" +
                          "\n - When we initialize a nullable type with null, in reality the compiler is not initializing it with null, but with a new instance of Nullable<T> with HasValue set to false" +
                          "\nand Value set to the default value of the type.");
        Console.WriteLine(" - Because it is a struct is not possible to set the Value. -- nullableDate.Value = DateTime.Now; (NOT POSSIBLE)");
        //nullableDate.Value = DateTime.Now; not possible
        nullableDate = DateTime.Now;
        
        Console.WriteLine(" - We can reuse the declaration by simply assigning a new value to the variable like -- nullableDate = DateTime.Now; --" +
                          "\n - This is the same as change an int, char or double as structs are value types.");
        
        Console.WriteLine("-------------------------------------------------------------------------------------");
        
        Console.WriteLine($"Notice that we cannot make a nullable of a class -- Nullable<{typeof(PersonClass)}> person = null;" +
                          $"\n but we can -- PersonClass? person = null; -- This is because classes are reference types and accept nullables by default.");
        //Nullable<PersonClass> person = null; not possible
        PersonClass? nullablePerson = ReturnNullPerson();
        PersonClass person = ReturnNullPerson(); // Gives a warning for assigning a nullable to a non-nullable type

        if (nullablePerson.Age == 0) // Gives a warning for using a nullable type without checking if it has a value first
        {
            
        }
        
        if(person.Age == 0) // Gives a warning for using a non-nullable type that has been assigned a possible nullable without checking if it has a value first
        {
            
        }
        Console.WriteLine(" The diference between nullable and non-nullable types (See line above this in code) is that the compiler will" +
                          "\n give you a warning if you try to use a nullable type without checking if it has a value first, or if a certain" +
                          "\n method returns a nullable type when it sholudn't or you don`t check if it has a value first.");
        
        Console.WriteLine("In general the use or not of nullables is only a matter of good practices and code readability. The compiler" +
                          "\n will only give you warnings and try to help you avoid null reference exceptions by forcing you to check.");
    }

    public static void RunNullableOperatorsExplained()
    {
        //TODO
    }
    
    private class PersonClass
    {
        public int Age;
        public string Name;

        public PersonClass()
        {
            Age = 18;
            Name = "John";
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }
    }
    
    private static PersonClass? ReturnNullPerson()
    {
        return null;
    }
    
    private static PersonClass ReturnNullPerson2()
    {
        return null; // Gives a warning for returning a nullable type when it should be non-nullable
    }
}