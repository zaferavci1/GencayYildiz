

Person p1 = new()
{
    Name = "Zafer",
    Age = 10
};

var (x, y) = p1;



class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void Deconstruct(out string name,out int age)
    {
        name = Name;
        age = Age;
    }
}