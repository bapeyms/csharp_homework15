namespace csharp_homework15;

class Program
{
    static void Main(string[] args)
    {
        // 1
        Console.WriteLine("-- TASK 1 --");
        Play play = new Play("Hamlet", "William Shakespeare", "Tradegy", 1601);
        play.Print();
        TestDestructor();
        Console.WriteLine("THE END\n");
        
        Console.WriteLine("-- TASK 2 --");
    }

    static void TestDestructor()
    {
        Play tempPlay = new Play("Temporary Play", "Unknown Author", "No-Name", 2288);
        tempPlay.Print();
        tempPlay = null;
        
        GC.Collect();
        GC.WaitForPendingFinalizers();
    }
}