bool keepLooping = true;

    Console.WriteLine("Please enter your name!:");

    string name = Console.ReadLine();

    Console.WriteLine("Oh, so your name is " + name, "?");
while (true)
{
    Console.WriteLine("Y=1/N=2");

    int nameconfirm = int.Parse(Console.ReadLine());

    switch (nameconfirm)
    {
      case 1:
            Console.WriteLine(name, " that's a good name");
            break;

      case 2:
            

        default:
            Console.WriteLine("That isn't a valid input");
            continue;
    }
}