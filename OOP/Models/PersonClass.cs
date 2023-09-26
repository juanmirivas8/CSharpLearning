namespace OOP.Models;

public class PersonClass
{
    private string _name = string.Empty; //Change the default value
    public string Name
    {
        get {
            if (_name.Equals("")) return "Nobody";
            else return _name;     
            }
        //private set { _name = value; } // you can change the visibility of properties to be more restrictive
        init => _name = value.Equals("") ? "Initialized as nobody" : value; // init only can be used in the constructor - With expression-bodied member
    }


    public int Age { get; set; }

    public PersonClass(string name, int age = 1) //Optional parameters must appear last
    {
        Name = name;
        Age = age;
    }

    public PersonClass():this("Juan") // Use an already owned ctor
    {

    }

}
