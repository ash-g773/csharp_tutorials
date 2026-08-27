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
//Console.Write(subscript.X);