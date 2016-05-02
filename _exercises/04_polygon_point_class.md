---
title: Class for Polygon and Point
number: 4
status: finished
authors: marc
lesson: 3
---

We want to put the polygon and the euclidean distance exercise in own classes. 

### Step 1

Create two classes one for the polygon (`Polygon`) and one for a point (`Point2D`). These two classes should be in seperate files.

But keep the `Programm` class with the main method.

*Hint: All classes should be in the same namespace.*

### Step 2

The `Point2D` class needs the following members: 

- fields for both coordinates
- two constructors - one for empty parameters and one for the coordinates as parameters
- one method to calculate the distance between two points
  - the calculation is between the point itself and another point, given as a parameter

The `Polygon` class needs the following members:

- an field and property for the array of vertices
  - if the vertices changed (per `set`) it should recalculate the area
- an property for the area
  - with `get` and `private set`
- an property for the vertex count
  - only a `get` (it can get the count from the array)
- two constructors - one for epmty parameters and one for an array of points as parameter
- an private method that calculates the area of the polygon

### Step 3

Update the calculation methods with the new datastructures.

### Step 4

Give both classes all possible documentation commentaries.

### Step 5 (Optional)

Put the whole process of the polygon creation in an own (`static`) method in the `Programm` class.
