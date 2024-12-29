// See https://aka.ms/new-console-template for more information

// Hello World 
Console.WriteLine("Hello, Ryan!");

// Strings 
string firstFriend = "Maria"; 
string secondFriend = "Sage"; 
Console.WriteLine($"My friends are {firstFriend} and {secondFriend}."); 

// Trim Method Example 
string thirdFriend = "   Nick   "; 

string trimmedFriend = thirdFriend.TrimStart(); 
Console.WriteLine($"[{trimmedFriend}]"); 

trimmedFriend = thirdFriend.TrimEnd(); 
Console.WriteLine($"[{trimmedFriend}]"); 

trimmedFriend = thirdFriend.Trim(); 
Console.WriteLine($"[{trimmedFriend}]"); 

// Replace Method Example 
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