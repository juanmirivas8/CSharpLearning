namespace Generics;

public class ConstraintsExamples
{
    public void ConstructorConstraint<T>() where T : new()
    {
        var instance = new T(); // Would not compile if T did not have a parameterless constructor
    }
    
    public void StructConstraint<T>() where T : struct
    {
        var instance = new T(); // Would not compile if T was a value type
    }
    
    public void ClassConstraint<T>() where T : class,new()
    {
        var instance = new T(); 
    }
    
    public void BaseClassConstraint<T>() where T : BaseClass,new()
    {
        var instance = new T();
    }
    
    public class BaseClass
    {
        public BaseClass()
        {
            
        }
    }
    
    public class AnotherClass
    {
        
    }
}