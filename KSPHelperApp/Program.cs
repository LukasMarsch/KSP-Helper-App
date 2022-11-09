using KSPHelperApp;

class Program
{
    static Transfer start;
    static int sum = 0;

    public static void Main()
    {
        start = TransferFactory.Create();
        EvaluateInput("start");
    }

    static void EvaluateInput(string? input) 
    {
        switch (input)
        {
            case "start": Console.WriteLine("give a target, type help or exit:"); ConsoleLoop(); break;
            case null: Console.WriteLine("Nothing recieved, please try again!"); ConsoleLoop(); break;
            case "help": Console.WriteLine("Enter a location to calculate delta-v-requirements for"); ConsoleLoop(); break;
            case "exit": Console.WriteLine("Fine, see you soon!"); break;
            default: Console.WriteLine("Evaluating delta-v for " + input); SearchForElement(start, input); break;
        }
    }

    static void ConsoleLoop()
    {
        EvaluateInput(Console.ReadLine());
    }

    static Transfer? SearchForElement(Transfer f, String name)
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

    static void countPath(int num)
    {
        sum += num;
    }
}
