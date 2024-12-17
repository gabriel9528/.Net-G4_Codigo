namespace Ejercicio2_After
{
  public class Rectangle : IShape
  {
    public double Width { get; set; }
    public double Height { get; set; }

    public string Area()
    {
      return "Rectangulo: " + Width * Height;
    }

  }
}