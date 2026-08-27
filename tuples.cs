// tuple - X, Y are keys 1, 2 are values
var pt = (X: 1, Y: 2);

//(double) : type casting
var slope = (double)pt.Y / (double)pt.X;
Console.WriteLine($"A line from the origin to the point {pt} has a slope of {slope}");

pt.X += 5;
slope = (double)pt.Y / (double)pt.X;
Console.WriteLine($"A line from the origin to the point {pt} has a slope of {slope}");

var pt2 = pt with { Y = 10 };
Console.WriteLine($"The point is at {pt2}");

var subscript = (A: 0, B: 0);
subscript = pt;
Console.Write(subscript.A);
//Console.Write(subscript.X); - this doesnt work

//record - type thats good for storing 2D graph space point values
Point pt3 = new Point(1, 1);
var pt4 = pt3 with { Y = 10 };
Console.WriteLine($"The two points are {pt3} and {pt4}");

double slopeResults = pt4.Slope();
Console.WriteLine($"The slope of {pt4} is {slopeResults}");

// declaring and using a new type needs to be at the bottom of the file
public record Point(int X, int Y)
{
    public double Slope() => (double)Y / (double)X;
}