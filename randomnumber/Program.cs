
Random rnd = new Random();

int myrandomnum;
int randomsum = 0;

for(int i = 0; i < 3; i++)
{
    myrandomnum = rnd.Next(0, 11); //0-10
    randomsum = randomsum + myrandomnum;    
    Console.WriteLine($"my random number is: {myrandomnum}");
}
Console.WriteLine($"random sum total: {randomsum}");