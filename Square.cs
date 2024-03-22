namespace Practice;


public class Square 
{
    public Square(int sideLength)
    {
        this.SideLength = sideLength;
    }

    // Property
    public int SideLength { get; set; }

    public double GetDiagonalLenght()
    {
        return Math.Sqrt(2) * this.SideLength;
    } 

    public int GetPerimeter()
    {
        return 4 * this.SideLength;
    }

    public int GetArea()
    {
        return this.SideLength * this.SideLength;
    }
}
