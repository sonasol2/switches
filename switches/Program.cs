namespace switches;

class Program
{
    static void Main(string[] args)
    {
        string name = "Tom";

        switch (name)
        {
            case "Bob":
                Console.WriteLine("Your name is Bob");
                break;
            case "Tom":
                Console.WriteLine("Your name is Tom");
                goto case "Bob";
            default:
                Console.WriteLine("Wrong name");
                break;
	    }

     //   int DoOperation(int op, int a, int b)
     //   { 
	    //    switch (op)
     //       {
     //           case 1: return a + b;
     //           case 2: return a - b;
     //           case 3: return a * b;
     //           case 4: return a / b;
     //           default: return 0;
     //       }
	    //}

        int DoOperation(int op, int a, int b)
        {
            return op switch
            {
                1 => a + b,
                2 => a - b,
                3 => a * b,
                4 => a / b,
                _ => 0
            };
	    }

        int result = DoOperation(1, 5, 6);
        Console.WriteLine(result);
    }
}

