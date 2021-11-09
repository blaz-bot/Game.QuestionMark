bool namerestart;
while (namerestart = true) 
{
    Console.WriteLine("Please enter your name!:");

    string name = Console.ReadLine();

    Console.WriteLine("Oh, so your name is " + name, "?");

    Console.WriteLine("y/n");
    char nameopt = char.Parse(Console.ReadLine());

    if (nameopt == 'n')
    {
        namerestart = true;
    }

    else if (nameopt == 'y')
    {
        C   ole.WriteLine("test");
    }

    else
    {
        namerestart = false;
    }
 }  