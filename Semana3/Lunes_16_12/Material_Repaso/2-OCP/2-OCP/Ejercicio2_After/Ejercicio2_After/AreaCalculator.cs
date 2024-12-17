using System;
using System.Collections.Generic;

namespace Ejercicio2_After
{
  public class AreaCalculator
  {
    public string Area(List<IShape> shapes) // List<rectangle>
    {
      string area = "";
      foreach (var shape in shapes)
      {
        area += shape.Area();
        area += Environment.NewLine;
      }
      return area;
    }
  }
}