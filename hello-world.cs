//Console.WriteLine("Hello, World!");

string aFriend = "Sanju";
aFriend = "Tresa";
Console.WriteLine($"Hello {aFriend}");

Console.WriteLine($"Your name is {aFriend.Length} characters long!");

//square brackets just for visualization
string greeting = "       hey      ";
Console.Write( $"[{greeting}]" );

string trimmedGreeting = greeting.TrimStart();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.TrimEnd();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.Trim();
Console.WriteLine($"[{trimmedGreeting}]");

string sayHello = "Hello, World";
sayHello = sayHello.Replace("Hello", "Goodbye");
Console.WriteLine(sayHello);

Console.WriteLine(sayHello.ToUpper());

Console.WriteLine(sayHello.Contains("World"));
Console.WriteLine(sayHello.StartsWith("Goodbye"));
