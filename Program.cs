// See https://aka.ms/new-console-template for more information

// Hello World 
Console.WriteLine("Hello, Ryan!");

// Strings and String Interpolation
string firstFriend = "Maria"; 
string secondFriend = "Sage"; 
Console.WriteLine($"My friends are {firstFriend} and {secondFriend}."); 

// Trim method example 
string thirdFriend = "   Nick   "; 

string trimmedFriend = thirdFriend.TrimStart(); 
Console.WriteLine($"[{trimmedFriend}]"); 

trimmedFriend = thirdFriend.TrimEnd(); 
Console.WriteLine($"[{trimmedFriend}]"); 

trimmedFriend = thirdFriend.Trim(); 
Console.WriteLine($"[{trimmedFriend}]"); 

// Replace method example 
string friends = $"My friends are {firstFriend} and {secondFriend}"; 

// Demonstrates that Replace method does not redefine friends - a new string is returned from Replace method and the old string assigned to friends stays the same. 
Console.WriteLine(friends); 
Console.WriteLine(friends.Replace("Maria", "Adam"));
Console.WriteLine(friends); 

Console.WriteLine("##############################");

// Demonstrates reassignment of a variable to a new string - this is a newly created string, not a mutation of the old string. The old string will now be eligible for garbage collection. 
Console.WriteLine(friends); 
friends = friends.Replace("Maria", "Adam");
Console.WriteLine(friends); 

// Contains method - returns a boolean value which tells if the string being searched for is found. 
Console.WriteLine(friends.Contains("Maria")); // False
Console.WriteLine(friends.Contains("Adam")); // True

// ToUpper and ToLower methods
Console.WriteLine(friends.ToLower()); 
Console.WriteLine(friends.ToUpper()); 

// Length method
Console.WriteLine(friends.Length); 

// Starts with and Ends with
Console.WriteLine(friends.StartsWith("My")); // True
Console.WriteLine(friends.StartsWith("Maria")); // False

Console.WriteLine(friends.EndsWith("Sage")); // True
Console.WriteLine(friends.EndsWith("My")); // False

