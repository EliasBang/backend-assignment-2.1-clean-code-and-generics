int firstCapacity = 12;
int firstUsedCapacity = 5;
Console.WriteLine($"Remaining: {CalculateRemainingCapacity(firstCapacity, firstUsedCapacity)}");

int secondCapacity = 20;
int secondUsedCapacity = 8;
Console.WriteLine($"Remaining: {CalculateRemainingCapacity(secondCapacity, secondUsedCapacity)}");

static int CalculateRemainingCapacity(int capacity, int usedCapacity)
{
    return capacity - usedCapacity;
}