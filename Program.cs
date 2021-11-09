
//Name Selection
{
    bool namerestart;
    while (namerestart = true)
    {
        Console.WriteLine("Please enter your name!:");

        string name = Console.ReadLine();

        Thread.Sleep(500);
        Console.WriteLine("Oh, so your name is " + name + "?");

        Thread.Sleep(500);
        Console.WriteLine("(y/n)");
        char nameopt = char.Parse(Console.ReadLine());
        //Incorrect name input, restart
        if (nameopt == 'n')
        {
            namerestart = true;
        }
        //Name is all g
        else if (nameopt == 'y')
        {
            Console.Clear();
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Sweet! Nice to meet you " + name, "!");
            break;
        }
        //Invalid y/n
        else
        {
            Thread.Sleep(500);
            Console.WriteLine("That is not a valid input :(, lets try again?");
            Thread.Sleep(500);
        }
    }
}