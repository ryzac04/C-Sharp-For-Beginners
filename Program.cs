// See https://aka.ms/new-console-template for more information

// Hello World 
using System.Diagnostics.Metrics;

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

// Numbers, Integers, and Math
int a = 2100000000;
int b = 2100000000;
// long c = a + b; this will not work because the operation is being done as int and the result is being stored as long. Must coerce the operation as seen below. 
// long c = checked(a + b); 
long c = (long)a + (long)b;
Console.WriteLine(c);

// Branching and Ifs 
int d = 5;
int e = 3;

int f = d + e;

bool myTest = f > 10; // just to demonstrate boolean 

if (myTest)
{
    Console.WriteLine("The answer is greater than 10.");
}
else
{
    Console.WriteLine("The answer is less than 10.");
}

// Branching and While Loops
// int counter = 0;

// while (counter < 5)
// {
//     Console.WriteLine(counter);
//     counter++;

// }

// do
// {
//     Console.WriteLine(counter);
//     counter++; 
// }
// while(counter < 5); 

// For Loops
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i);
}

// List T and Collections of Data
var names = new List<string> { "Scott", "Ana", "Felipe" };

names.Add("David");
names.Add("Damian");
names.Add("Maria");
foreach (var name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}!");
}

// Arrays, Lists, Indexing, and Foreach
Console.WriteLine("#####ARRAYS, LISTS, INDEXING#####");

Console.WriteLine(names[0]);
Console.WriteLine(names[2]);
Console.WriteLine(names[4]);
Console.WriteLine(names[^1]);

// Sorting and Searching Lists 
Console.WriteLine("#####SORTING#####");

names.Sort();

foreach (var name in names)
{
    Console.WriteLine(name); 
}

var numbers = new List<int> {45, 56, 99, 48, 67, 78};

Console.WriteLine($"{string.Join(", ", numbers)}"); 

Console.WriteLine($"I found 99 at index {numbers.IndexOf(99)}."); 
numbers.Sort();

foreach (var number in numbers)
{
    Console.WriteLine($"{number}");
}

Console.WriteLine($"I found 99 at index {numbers.IndexOf(99)}."); 

// Language Integrated Query (LINQ) and IEnumerables 
// Console.WriteLine("#####LINQ LESSON- IMPERATIVE EXAMPLE#####");

// List<int> scores = [97, 92, 81, 60]; 

// for(int i = 0; i < scores.Count; i++)
// {
//     if(scores[i] > 80)
//     {
//         Console.WriteLine($"I found a score over 80: {scores[i]}"); 
//     }
// }

// return; 

Console.WriteLine("#####LINQ LESSON#####"); 

// LINQ Query Expression
// // Specify the data source. 
// List<int> scores = [3, 45, 82, 97, 92, 100, 81, 60]; 

// // Define the query expression. 
// IEnumerable<string> scoreQuery = 
//     from score in scores
//     where score > 80
//     orderby score descending
//     select $"The score is {score}."; 

// // Execute the query. 
// foreach (string s in scoreQuery)
// {
//     Console.WriteLine(s);
// }

// LINQ Method Syntax - both scoreQuery and scoreQuery 2 are LINQ. They functionally do the same thing, but written differently.  
// Specify the data source. 
List<int> scores = [3, 45, 82, 97, 92, 100, 81, 60]; 

// Define the query expression. 
IEnumerable<int> scoreQuery = 
    from score in scores
    where score > 80
    orderby score descending
    select score; 

var scoreQuery2 = scores.Where(s => s > 80).
    OrderByDescending(s => s); // select is implied

List<int> myScores = scoreQuery.ToList(); 
List<int> myScores2 = scoreQuery2.ToList(); 

// Execute the query. 
Console.WriteLine("scoreQuery result");
foreach (int score in scoreQuery)
{
    Console.WriteLine(score);
}

Console.WriteLine("scoreQuery2 result");
foreach (int score2 in scoreQuery2)
{
    Console.WriteLine(score2);
}

// OOP