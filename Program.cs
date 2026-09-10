//Zionn Showers
//9-10-2026
//Mini Challenge # 5 - Mad Lib
//I made the user type in 10 different words and with the program saving them as strings. Afterwards, the program uses those strings in an existing Mad Lib to fill in the gaps and make a (somewhat) coherent story.
/*
Reviewer: Callen Thomason
Review:
Code works as intended. I really like the variable names. word1 through word10 ensures you have all the words. 
If I where to change anything I would change the WriteLine to Write. So the answers could be next to the questions. 
Interpolation looks great. 
Flow chart looks great. I really like the inclusion of a welcome. The user knows what they are getting into. 
*/


Console.Clear();

Console.WriteLine("Welcome to Mad Lib!");
Console.WriteLine("Please type in a COLOR:");
string word1 = Console.ReadLine();
Console.WriteLine("Please type in an ADJECTIVE:");
string word2 = Console.ReadLine();
Console.WriteLine("Please type in a TIME:");
string word3 = Console.ReadLine();
Console.WriteLine("Please type in an ADJECTIVE:");
string word4 = Console.ReadLine();
Console.WriteLine("Please type in a PLACE:");
string word5 = Console.ReadLine();
Console.WriteLine("Please type in a FOOD:");
string word6 = Console.ReadLine();
Console.WriteLine("Please type in a FOOD:");
string word7 = Console.ReadLine();
Console.WriteLine("Please type in a VERB:");
string word8 = Console.ReadLine();
Console.WriteLine("Please type in a NOUN:");
string word9 = Console.ReadLine();
Console.WriteLine("Please type in a NUMBER:");
string word10 = Console.ReadLine();
Console.WriteLine("Here is your Mad Lib!");
Console.WriteLine($"Bats are so cool! They are {word1}, {word2} animals which have wings. They like to fly around at {word3} which makes some people scared of them. But bats are {word4}, and they don't want to hurt people. I have a pet bat that lives in {word5}. I like to feed him {word6} and {word7}. He likes to {word8}. I am his favorite person, but he also likes {word9}. I want to convince my parents to get me {word10} more bats.");