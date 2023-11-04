

    //Switch - Case

//Alternative to an if-else statement
using System.Runtime.Intrinsics.X86;

switch (selector)
{
    case someCase:
        statements;
        break;
    default:
        statements;
        break;
}

// For-Loop
for (initialization; condition; step)
{
    // Body of the for loop
}

    //While Loop
int i = 1;
while (i <= 5)
{
    Console.WriteLine(i);
    i++;
}

//While or For Loop?

//Use for-loop when you preliminary know the
//number of iterations
//▪ E.g. repeat exactly n times
//▪ Use while if you don't know when
//the exit condition will be met
//▪ E.g. repeat until stopped

//Break Operator

//Used for prematurely exiting the loop
//▪ Can only be executed from the loop's body
//▪ When break is executed, the code inside the
//loop's body after it is skipped (does not execute)

while (true)
{
    int a = 1; // Some code …
    if (a==0) break;
    // More code …
}

//Infinite While Loop

//Infinite while loops: use true as loop condition

while (true)
{
    string command = Console.ReadLine();
    if (command == "End")
    {
        break;
    }
    Console.WriteLine("Executing: " + command);
}

//Do…While Loops

//The do … while (…) loop repeats a block of code until an exit condition is met
//The loop body is always executed at least once
//while (…) loop uses an exit condition at the start
//do … while (…) loop uses an exit condition at the end
int i = 1;
do
{
    Console.WriteLine(i);
    i++;
} while (i <= 10);


//Method

//Named block of code, that can be invoked later
// Void methods do not return a result
static void PrintHello()
{
    Console.WriteLine("Hello");
}
//Declaring Methods
static void PrintText(String text)
{
    Console.WriteLine(text);
}

//Method Parameters
//Method parameters can be of any data type
//Each parameter has name and type


static void PrintNumbers(int start, int end)
{
    for (int i = start; i <= end; i++)
    {
        Console.Write("{0} ", i);
    }
}
//Call the method with certain values (arguments)
PrintNumbers(5, 10);

//Returning Values From Methods
//The return keyword immediately stops the method's execution
//Returns the specified value
//Void methods can be terminated by just using return
static string ReadFullName()
{
    string firstName = Console.ReadLine();
    string lastName = Console.ReadLine();
    return firstName + " " + lastName;
}

//Return value can be:
//Assigned to a variable
int max = GetMax(5, 10);

//Used in expression
double total = GetPrice() * quantity * 1.20;

//Passed to another method
int age = int.Parse(Console.ReadLine());







//ARRAY

//Reading Array from console separatet with space
using System;

int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
// Reading Array from console separatet with ","
int[] arr = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

//Arrays have fixed size
(Array.Length) //cannot be resized

//Printing Arrays with string.Join(…)
//Use string.Join(separator, array) to print an array:
string[] strings = { "one", "two" };
Console.WriteLine(string.Join(" ", strings)); //Output: one two
int[] array = { 1, 2, 3 };
Console.WriteLine(string.Join(", ", arr)); //Output: 1, 2, 3


//LIST
//	Reads a List of integers from the console separatet with space
List<int> numbersN = Console.ReadLine().Split().Select(int.Parse).ToList();
//Create an empty list of integers
List<int> numbersN = new List<int>();
//Create an  list of strings
List<string> names = new() { "Peter", "Ana", "Maria" };
//Provides operations to add / insert / remove / find elements
Add(element) // adds an element to the List<T>
Count // number of elements in the List<T>
Remove(element) // removes an element (returns true / false)
Insert(index, element) // inserts an element to a given index 
Contains(element) // determines whether an element is in the list
Sort() // sorts the array/list in ascending order

//Sorting Lists
List<string> names = new List<string>() { "Peter", "Michael", "George", "Victor", "John" };
names.Sort();//Sort in natural (ascending) order
names.Reverse();//Reverse the sorted result

