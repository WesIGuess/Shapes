using Shapes3D;
namespace Shapes3D
{
     class Shapes3D{

        //  USE THIS FOR TESTING
     /*public static void Main(string[] args){
        Cube cubeOne = new Cube();
        Console.WriteLine(
cubeOne.GetSurfaceArea(3,200,100)
        );

    }*/}
    
    
    
    public abstract class Shape3D
   
    //abstract class
    {
public abstract double GetSurfaceArea(double? length, double? width, double? height); 
public abstract double GetVolume(double? surfaceArea, double? height); //method
}


//First Shape: Cuboid

public class Cuboid : Shape3D
{
    public override double GetSurfaceArea(double? length, double? width, double? height)
    {
       surfaceArea = (double)(length * width);
       width = length;
       return surfaceArea;
       
      
      
    } 

public override double GetVolume(double? surfaceArea, double? height){
    volume = (double)(surfaceArea * height);
    return volume;
   
}
    public double? length;

    public double? width;

    public double? height;

    public double surfaceArea;

    public double volume;

  

    public Cuboid(double? length, double? width, double? height)

     //length * width * height
    {

        this.width = width;
        this.height = height;
        this.length = length;
    }
}
//second shape : Cube

public class Cube : Shape3D
{
        public override double GetSurfaceArea(double? length, double? width, double? height)
    {
        surfaceArea = (double)(length * length * length);
        width = length;
        height = length;
       return surfaceArea;
       
    } 
    

public override double GetVolume(double? surfaceArea, double? height){
   volume = (double)(surfaceArea * height);
    return volume;
    
}
   public double? length;
   public double? width;
   public double? height;
   public double surfaceArea;

   public double volume;

public Cube(){}
    public Cube(double? length)

    //length * width * height
    {
       this.length = length;
    
    }
}
//Third shape : Cylinder

class Cylinder : Shape3D
{
        public override double GetSurfaceArea(double? length, double? width, double? height)
    {
        surfaceArea = (pi * radius) * (pi * radius);
        return surfaceArea;
    } 

public override double GetVolume(double? surfaceArea, double? height){
    volume = (double)(surfaceArea * height);
    return volume;
}
public double radius;
public double? height; 
 double pi = Math.PI;

 public double surfaceArea;
 

 public double volume;
    public Cylinder(double? radius, double? height)
 

    //[Pi * (Radius Squared)] * Height
    {
        this.radius = (double)radius;
        this.height = height;
    }
    }
   
   //Fourth Shape : Sphere
   
   class Sphere : Shape3D
   {
        public override double GetSurfaceArea(double? length, double? width, double? height)
    {
        surfaceArea = 4 * ((Math.PI * radius) * (Math.PI * radius));
       return surfaceArea;
    } 

public override double GetVolume(double? surfaceArea, double? height){
   volume = 4/3 * ((Math.PI * radius) * (Math.PI * radius) * (Math.PI * radius));
    
    return volume; 
}
    public double radius;
    public double pi = Math.PI;
    public double volume;

    public double surfaceArea;
    public Sphere(double radius)
    {
    //4/3[(pi * Radius) Cubed]
    this.radius = radius;
    }
    
}

}




