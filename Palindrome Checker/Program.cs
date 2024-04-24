using System.Collections;
//using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
///-----------------------------------------------------------------
///   Description: Palindrome Checker
///   Author:       Leon Goodwin
///   Date:         17 April 2024
///-----------------------------------------------------------------
Start:

Console.Clear();

Console.Write("Enter Text: ");                   // Prompts User Input
 
string Text = Console.ReadLine();                // Gets User's Input And Sets It To The Var "Text"

Console.Clear();                                 // (Debug) Clears Console

Console.WriteLine("Base Input: " + Text);        // (Debug) Outputs Inital Text

string LowerText = Text.ToLower();               // Makes New Var "LowerText" And Sets It To The Var "Text" But Lowercase

Console.WriteLine("Lowercase: " + LowerText);    // (Debug) Outputs Text Var In Lowercase

Char[] LowerTextARR = LowerText.ToCharArray();   // Convert To Array

List<Char> LowerTextList = LowerTextARR.ToList();// Convert To List

bool CheckListbool(char check)                  // Check If Char Is In List
{
    return !char.IsLetter(check);
}
string FinalIT = "";

LowerTextList.RemoveAll(CheckListbool);          // Remove Chars In List

LowerTextList.ForEach((char ch) => {
   FinalIT = FinalIT + ch;
});
String Reverse = "";

Console.WriteLine("Non Letters Removed: " + FinalIT);                      // (Debug) Outputs Final Itteration

IEnumerable<Char> ReverseLs = FinalIT.Reverse();

List<char> ReverseCharList = ReverseLs.ToList();

ReverseCharList.ForEach((char ch) => {
    Reverse = Reverse + ch;
});

Console.WriteLine("Reversed: " + Reverse);

if (Reverse == FinalIT)
{
    Console.WriteLine("It Is A Palindrome");
}
else
{
    Console.WriteLine("It Is Not A Palindrome");
}
Console.WriteLine("Continue?");                   // Prompts User Input

string Continue = Console.ReadLine();
 if (Continue == "y")
{
    goto Start;
}
 else if (Continue == "n")
{
   
}