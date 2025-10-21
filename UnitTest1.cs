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
Console.Write(verb+" (past tense) \n");
string verb1 = Console.ReadLine();
Console.Write(noun);
string noun1 = Console.ReadLine();
Console.Write(adj);
string adj2 = Console.ReadLine();
Console.Write(verb + " (past tense) \n");
string verb2 = Console.ReadLine();
Console.Write(verb + " (past tense) \n");
string verb3 = Console.ReadLine();
Console.Write(noun);
string noun2 = Console.ReadLine();

Console.Write(".\n");

string story = $@"Once upon a time, there was a(n) {adj1} boy who {verb1} sheep.
He wanted some excitement so he pretended that there was a(n) {adj2} {noun1} attacking his ^plural-noun.
When the townspeople came, he {verb2} them. 
He had so much fun that he tried it again the following day and {verb3} at the townspeople when they came to help.
The next day, a(n) {noun2} really did {verb3}";//his sheep and he {^past-tense-verb} and {^past-tense-verb} to call for help,
//but no one believed him and he lost his {^noun} .";

Console.WriteLine(story);
Console.WriteLine("I hope you enjoyed this! Have a great day. 😇");


public class UnitTest1
{
    [Fact]
    public void Test1()
    {

    }
}
