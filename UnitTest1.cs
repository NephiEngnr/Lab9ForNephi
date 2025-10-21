//Nephi Allen.
//lab 9.
// 10/21/25

Console.Clear();
Console.WriteLine(@"This game is fun! 
It is designed to take words you give it, and then it will tell you a story that you helped write!
Sounds fun, doesn't it. Give it a go!
(press enter to continue)");
Console.ReadLine();
Console.Clear();

string adj = "Please enter a new adjective: \n";
string verb = "Please enter a verb: \n";
string noun = "Please enter a new noun: (name an animal)\n";

Console.Write(adj);
string adj1 = Console.ReadLine();
Console.Write(verb);
string verb1 = Console.ReadLine();


Console.Write(noun);
string noun1 = Console.ReadLine();



string story = "There was a " + adj1 + " " + noun1 + ". This " + noun1 + " tried to " + verb1 + " its pet turtle.";
Console.WriteLine(story);




public class UnitTest1
{
    [Fact]
    public void Test1()
    {

    }
}
