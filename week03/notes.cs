using System.ComponentModel;
using System.Runtime.ExceptionServices;

public class person
{
    private string _firstName;
    private string _lastName;

    public string GetInformalSignature()
    {
        return "thanks, " + _firstName;
    }

    public string GetFormalSignature()
    {
        return "Sincerely, " + GetFullName;
    }

    private string GetFullName()
    {
        return _firstName + " " + _lastName;
    }

    // This is a getter
    public string GetFirstName()
    {
        return _firstName;
    }
    // This is a setter
    public void SetFirstName(string firstName)
    {
        _firstName = firstName;
    }
    // This is how it would be called from another part of the program
    //person p = new person();
    //p.SetFirstName("Peter");

    //Console.WriteLine(p.GetFirstName());


    // Constructors
    public class Person
    {
        private string _title;
        private string _firstName;
        private string _lastName;

        public Person()
        {
            _title = "";
            _firstName = first;
            _lastName = last;
        }

        public Person(string title, string first, string last)
        {
            _title = title;
            _firstName = first;
            _lastName = last;
        }
    }

    Person p1 = new Person();
    Person p2 = new Person("Jane", "Doe");
    Person p3 = new Person("Mrs", "Jane", "Doe");
}