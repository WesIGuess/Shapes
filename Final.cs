using Shapes3D;

namespace program {
  static class Program {
    public static void Main(string[] args) {
      string filepath = args[0];
      double total = 0;

     foreach (string line in System.IO.File.ReadLines(filepath)) {
        string[] lineData = line.Split(',');

        Shape3D myShape;

        switch (lineData[0]) {
          case "sphere":
            myShape = new Sphere(
              Convert.ToDouble(lineData[2])
            );
          break;

          case "cylinder":
            myShape = new Cylinder(
              Convert.ToDouble(lineData[2]),
              Convert.ToDouble(lineData[3])
            );
          break;

          case "cube":
            myShape = new Cube(
              Convert.ToDouble(lineData[2])
            );
          break;
           case "cuboid":
            myShape = new Cuboid(
              Convert.ToDouble(lineData[2]),
              Convert.ToDouble(lineData[3]),
              Convert.ToDouble(lineData[4])
            );
          break;

          default:
            throw new FormatException($"This is not a valid shape please try again ");
        } // switch


        //THIS IS MY MAJOR ISSUE I BELIEVE//
        if (lineData[1] == "area") {
          total += myShape.GetSurfaceArea(
             Convert.ToDouble(lineData[2]),
              Convert.ToDouble(lineData[3]),
              Convert.ToDouble(lineData[4])
          );
        } else if (lineData[1] == "volume") {
          total += myShape.GetVolume(
            Convert.ToDouble(lineData[1]),
            Convert.ToDouble(lineData[2]));
        }

      }

      Console.WriteLine($"Your total measurements is {total:0,0.00}");
    }
  }
}

