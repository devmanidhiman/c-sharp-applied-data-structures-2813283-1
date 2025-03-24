// Example file for C# Applied Data Structures by Joe Marini
// Basic data structures

// TODO: strings are collections of characters, and are immutable
string s1 = "Hello World ";
char[] c1 = new char[] {'F','i','z','z','y',' ','B','u','z','z'};
string s2 = new string(c1);
s1 += s2;
Console.WriteLine(s1);
s2 = s2.ToUpper();
Console.WriteLine(s2);

// TODO: Be careful with string references


// TODO: Arrays are contiguous storage of the same variable type
string s3 = "Hello ";
string s4 = s3;
s3 += "World";
Console.WriteLine(s4);


// TODO: implicitly typed array


// TODO: multiple type array


// TODO: Tuples are lightweight data structures that group multiple data elements
(string, int, bool) t1 = ("abc", 15, false);
Console.WriteLine($"{t1.Item1}, {t1.Item2}");

(string s, int i, bool b) t2 = ("abc", 15, true);
Console.WriteLine($"{t2.s}, {t2.i}, {t2.b}");

var t3 = (s: "def", a:34, e: false);
Console.WriteLine($"{t3.a}");