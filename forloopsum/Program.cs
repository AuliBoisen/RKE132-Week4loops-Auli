
int sum = 0

for(int i = 1; i < 11; i++) //i-- on sama mis i-1
{
    Console.WriteLine($"i = {i}");
    Console.WriteLine($"current total: {sum}");
    sum = sum + i; //sum + = i;
}

Console.WriteLine($"final total {sum});

