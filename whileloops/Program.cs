
Random rnd = new Random();
int cpurandom;

bool loopactive = true; //bool - true/false

while (loopactive)
{
    cpurandom= rnd.Next(1, 4);
    //Console.WriteLine($"cpu has generated {cpurandom}.");
    Console.WriteLine("Make a guess. Enter a number 1-3");

    int usernumber = Int32.Parse(Console.ReadLine());

    if(usernumber == cpurandom)
    {
        Console.WriteLine("congratulatsion, you won!");
        //loopactive = false;
        break;
}
    else
    {
        Console.WriteLine("oops, try again");
    }

}

Console.WriteLine("have a nice day!");