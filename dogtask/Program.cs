int distance = 10000, firstSpeed = 1, secondSpeed = 2, dogSpeed = 5, friend = 2, count = 0;
while (distance > 10)
{
    if (friend == 1)
    {
        int time = distance / (firstSpeed + dogSpeed);
        distance = distance - (firstSpeed + secondSpeed) * time;
        friend = 2;
        count++;
        Console.WriteLine(count);
        Console.WriteLine(distance);
    }
    if (friend == 2)
    {
        int time = distance / (secondSpeed + dogSpeed);
        distance = distance - (firstSpeed + secondSpeed) * time;
        friend = 1;
        count++;
        Console.WriteLine(count);
        Console.WriteLine(distance);
    }
}
Console.WriteLine(count);
