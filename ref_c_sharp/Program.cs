void PracticeWithRef(ref int num)
{
    num++;
    Console.WriteLine($"Number in method: {num}");
}

int beforeAfter = 7;
Console.WriteLine($"Number before method: {beforeAfter}");
PracticeWithRef(ref beforeAfter);
Console.WriteLine($"Number after method: {beforeAfter}");
