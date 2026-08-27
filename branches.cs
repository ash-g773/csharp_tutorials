int a = 5;
int b = 3;
int c = 4;

if ((a + b + c > 10) && (a == b))
{
    Console.WriteLine("both statements true");
}
else
{ 
    Console.WriteLine("one statement false"); 
}

if ((a + b + c > 10) || (a == b))
{
    Console.WriteLine("one or both statements true");
}
else
{
    Console.WriteLine("both statement false");
}