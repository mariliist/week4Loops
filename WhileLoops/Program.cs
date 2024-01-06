Random rnd = new Random();
int cpuRandom;

bool loopActive = true; //bool - true/false

while(loopActive)
{
    cpuRandom = rnd.Next(1, 4);
    //Console.WriteLine($"cpu generated {cpuRandom}");
    Console.WriteLine("Make a guess!");
    int userNumber = Int32.Parse(Console.ReadLine());

    if(userNumber == cpuRandom)
    {
        Console.WriteLine("Congratulations, you won");
        //loopActive = false; 
        break; // käitub samamoodi nagu loopActive
    }
    else
    {
        Console.WriteLine("Okouu. Try again!");
    }
}

Console.WriteLine("Have a nice day!");