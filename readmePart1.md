Create a terminal application that reads information from a file and prints the sum of measurements to the terminal to two decimal places and contains the appropriate commas.
ex: 1,234.56
Shapes3D Library
Create a library of shapes. Your library should include an abstract class 'Shape3D' that defines methods 'GetSurfaceArea' and 'GetVolume'. 
Using that template, fill out classes for the following objects:
Cuboid (rectangular prism)
Cube (child of cuboid)
Cylinder 
Sphere
File Parser
Create another library called 'Assignment 2' and implement a static class 'Slover' that reads in a csv file containing 3D shapes and their measurements. 
Here is an example of input file for testing purposes:
cuboid,area,4.5910,2.1215,3.3676
cuboid,area,1.4949,1.0121,3.4208
cube,volume,3.5312
cube,volume,4.0837
cube,area,1.3391
cylinder,area,4.9448,1.5906
cuboid,volume,1.1686,4.8972,2.1454
cube,volume,2.5493
cylinder,volume,1.7270,4.0281
sphere,volume,4.2586
sphere,volume,3.1750
cuboid,volume,4.7128,3.7729,4.9553
cylinder,area,3.0578,4.5875

An example of the programs output totaling our example input file:
matthew@neptune:~/Dropbox/projects/teaching/2210 INF 137/assignment2 (main) € dotnet run exampleInput.csv

The sum of measurements is 1,169.97.
Here is a key for the values you'll find in our file:
Cuboid will have three double values for width, height, and depth.
Cube will have a single double value for the length of all of it's sides.
Cylinder will have two double values for radius and height.
Sphere will have a single double value for radius

Program file

Your programs' namespace and class file can be whatever you wish. Check for a valid number of arguments, check if the file exists, and print out the sum of measurements




-------------------------------------------------------------------------------------------------------------