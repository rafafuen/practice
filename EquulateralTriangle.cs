namespace Practice;


public class EquilateralTriangle
{
    public EquilateralTriangle(int sideLength)
    {
        this.SideLength = sideLength;
    }

    public int SideLength{get; set;}

    public int GetPerimeter()
    {
        return this.SideLength * 3;
    }

    public double GetArea()
    {
        return (Math.Sqrt(3) / 2 * this.SideLength) * (this.SideLength / 2.0);
    }
}
