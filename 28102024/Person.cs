namespace _28102024;
public abstract class Person
{ 
  
    public int Id { get;  set; }
    public string Name { get; set; }
    
    public Person(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Invalid value");
        Name = name;
      
    }
}

