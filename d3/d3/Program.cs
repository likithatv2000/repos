/* namespace d3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread mythread = Thread.CurrentThread;
            mythread.Name = "Main Thread";
            Console.WriteLine(mythread.Name);

        }
    }
}
*/
class Multithread
{
    public static void thread1()
    {
        for(int i=0;i<10;i++)
        {
            Console.WriteLine(i);
            Thread t = Thread.CurrentThread;
            Console.WriteLine(t.Name);
            // Thread.Sleep(100);
        }
    }

    static void Main()
    {
        Thread t1 = new Thread(new ThreadStart(Multithread.thread1));
        t1.Name = "threadone";
        Thread t2 = new Thread(new ThreadStart(Multithread.thread1));
        t2.Name = "threadtwo";
        Thread t3 = new Thread(new ThreadStart(Multithread.thread1));
        t3.Name = "threadthree";
        t3.Priority = ThreadPriority.Highest;
        t2.Priority = ThreadPriority.Normal;
        t1.Priority = ThreadPriority.Lowest;
        t1.Start();
        t2.Start();
        t3.Start();
        
    }

}