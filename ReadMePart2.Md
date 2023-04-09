Create a terminal application that reads shape information from a file and prints requested information to the terminal with accuracy up to two decimal places and with the appropriate comma's to denote thousands.
Keep in mind the ideas that we discussed in class including encapsulation. STD in and STD out are not allowed inside libraries and should only return basic data types.
Please remember to name your namespaces, classes, and methods correctly as they will be referenced by grading code.
Shapes3D library

Your namespace no longer should have your name in it. Just Shapes3D.
You can use the same library as assignment 2, but with an additional shape, the Prism. The Prism must be defined using the Polygon class provided in the Shapes library, and must eager-load the Surface Area and Volume. Your Prism class' public methods should not calculate results, only return them.
Note: This means that the public methods that are typically overridden should return the member values that are calculated in the constructor.
This makes our total list:
Shape Name	Shape Code	Measurements
Cuboid (rectangular prism)	cuboid	double width, double height, double depth
Cube (child of cuboid)	cube	double sideLength
Cylinder	cylinder	double radius, double height
Sphere	sphere	double radius
n-gonal prism	prism	double sideLength, int faces, double height
File parser

Create another library called Assignment3 and implement a static class Solver that reads in a csv file containing 3D shapes and their measurements.
The twist is that instead of instantly adding our shapes, we will collect them until our file tells us to calculate the data.
For each shape, add the shape to a list of shapes. When the file requests a calculation, iterate through your list to add up the sum of that measurement. In addition, each line will include a integer to scale those results by.
i.e. The list starts with:
cube,1.4787
cuboid,2.6561,1.9380,3.6978
prism,4.3930,3,4.4710
cube,1.2667
area,3

Once your program gets to line 5, there will be a list with 4 shapes in it. Two cubes, a cuboid, and a prism. Find the area for all 4 shapes and multiply those values by 3, then add that to the total.
Here is an example input file for testing purposes:
cube,1.4787
cuboid,2.6561,1.9380,3.6978
prism,4.3930,3,4.4710
cube,1.2667
area,3
sphere,4.3393
prism,2.2624,5,4.5433
cylinder,4.0880,2.1208
volume,1
prism,1.8479,5,4.3124
cylinder,1.1235,1.0005
sphere,3.3918
area,4
cuboid,4.5097,1.6104,3.7918
prism,3.3981,7,3.9521
prism,2.1530,6,3.3442
sphere,2.1051
area,2
cube,3.2900
sphere,2.8449
prism,3.5020,8,1.2773
area,1
prism,1.2385,6,2.0526
cylinder,3.9727,1.4834
cylinder,4.8613,2.3540
cube,1.6643
area,3

An example of the programs output totaling our example input file:
matthew@neptune:~/Dropbox/projects/teaching/2210 - INF 137/assignment2 (main) € dotnet run exampleInput.csv
The sum of measurements is 4,000.00.
Program file

Your programs' namespace and class file can be whatever you wish. Check for a valid number of arguments, check if the file exists, and print out the sum of measurements.