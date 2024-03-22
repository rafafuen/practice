namespace Practice;


public class Circle
{
    public Circle (int radiusLenght)
    {
        this.RadiusLenght = radiusLenght;
    }


    // Property
    public int RadiusLenght { get; set; }

    public double GetDiameterLenght()
    {
        return this.RadiusLenght +  this.RadiusLenght;
    }

    public double GetArea()
    {
        return Math.PI * Math.Pow(this.RadiusLenght, 2); 
    }

    public double GetCircumference()
    {
        return Math.PI * this.GetDiameterLenght();
    }
}
