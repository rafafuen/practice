namespace Practice;
public class Foo
{
    public int Number { get; set; }
    public void Increment()
    {
        this.Number++;
    }

    public void WriteNumber()
    {
        Console.WriteLine(this.Number);
    }
}
