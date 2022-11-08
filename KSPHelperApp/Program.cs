using KSPHelperApp;

class Program
{
    static Transfer? start;
    static int sum = 0;

    public static void Main()
    {
        bool keeper = true;
        start = TransferFactory.Create();
        while (keeper){
            var current = ConsoleLoop();
            if (current == null)
            {
                keeper = false;
                Console.WriteLine("No value was read");
                break;
            } else if(current == "exit")
            {
                Console.WriteLine("Fine, see you soon!");
                break;
            }
            else if(current == "help")
            {
                Console.WriteLine("Type a Planet to start from or append it with a position like 'Kerbin Orbit'");
                ConsoleLoop();
            }
            else
            {
                var res = SearchForElement(start, current);
                if(res == null)
                {
                    Console.WriteLine("Element not found check spelling!");
                }
                Console.WriteLine(sum);
                sum = 0;
            }
        }
    }

    public static String? ConsoleLoop()
    {
        Console.WriteLine("give a start, type help or exit:");
        return Console.ReadLine();
    }

    public static Transfer? SearchForElement(Transfer f, String name)
    { 
        if(f == null || f.Transfers == null) { return null; }

        if (f.Name == name) { return f; }


        for (int i = 0; i < f.Transfers.Count; i++)
        {
            var t = f.Transfers[i];
            if (t == null)
            {
                return null;
            }
            if (t.Name == name)
            {
                countPath(t.Value);
                return t;
            }
            if (!(t.Name == name)) { continue; }
        }
        for(int i=0; i < f.Transfers.Count; i++)
        {
            var t = f.Transfers[i];
            var t1 = SearchForElement(t, name);
            if (t1 == null)
            {
                continue;
            }
            else
            {
                countPath(f.Value);
                return t1;
            }
        }
        return null;
    }

    public static void countPath(int num)
    {
        sum += num;
    }
}
