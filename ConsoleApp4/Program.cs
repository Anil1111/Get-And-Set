using System;

class User

{

    private string location;

    private string name = "Dennnis Ritchie";

    public string Location

    {

        get { return location; }

        set { location = value; }

    }

    public string Name

    {

        get

        {

            return name.ToUpper();

        }

        set

        {

            if (value == "Dennis")

                name = value;

        }

    }

}

class Program

{

    static void Main(string[] args)

    {

        User u = new User();

        // set accessor will invoke

        u.Name = "CSharp";

        // set accessor will invoke

        u.Location = "Microsoft";

        // get accessor will invoke

        Console.WriteLine("Name: " + u.Name);

        // get accessor will invoke

        Console.WriteLine("Location: " + u.Location);

        Console.WriteLine("\nPress Enter Key to Exit..");

        Console.ReadLine();

    }

}


