﻿// Challenge 1
bool amProgrammer = true;
Console.WriteLine(amProgrammer);
double Age = 27.9;
Console.WriteLine(Age);
List<string> Names = new List<string>();
Names.Add("Monica");
Dictionary<string, string> MyDictionary = new Dictionary<string, string>();
MyDictionary.Add("Hello", "0");
MyDictionary.Add("Hi there", "0");
// This is a tricky one! Hint: look up what a char is in C#
string MyName = "MyName";
Console.WriteLine(MyName);
// Challenge 2
List<int> Numbers = new List<int>() {2,3,6,7,1,5};
for(int i = Numbers.Count - 1 ; i >= 0; i--)
{
    Console.WriteLine(Numbers[i]);
}
// Challenge 3
List<int> MoreNumbers = new List<int>() {12,7,10,-3,9};
for(int i = 0; i < MoreNumbers.Count; i++)
{
    Console.WriteLine(MoreNumbers[i]);
}
// Challenge 4
List<int> EvenMoreNumbers = new List<int> {3,6,9,12,14};
for(int num = 0; num < EvenMoreNumbers.Count; num++)
{
    if(EvenMoreNumbers[num] % 3 == 0)
    {
        EvenMoreNumbers[num] =  0;
    }
    Console.WriteLine(EvenMoreNumbers[num]);
}
// Challenge 5
// What can we learn from this error message?
string MyString = "superduberawesome";
MyString.Insert(7,  "p");
Console.WriteLine(MyString);
// You can't alter string values by index

// Challenge 6
// Hint: some bugs don't come with error messages
Random rand = new Random();
int randomNum = rand.Next(12, 13);
if(randomNum == 12)
{
    Console.WriteLine("Hello");
}


