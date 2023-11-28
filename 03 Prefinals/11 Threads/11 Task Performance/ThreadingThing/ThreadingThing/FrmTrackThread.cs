namespace ThreadingThing
{
    public partial class FrmTrackThread : Form
    {
        Thread threadA, threadB, threadC, threadD;

        public void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "- Thread Start -";
            Console.WriteLine("- Thread 1 Start -");

            threadA = new Thread(MyThreadClass.thread1);
            threadA.Name = "Thread A process";

            threadB = new Thread(MyThreadClass.thread1);
            threadB.Name = "Thread B process";

            threadC = new Thread(MyThreadClass.thread1);
            threadC.Name = "Thread C process";

            threadD = new Thread(MyThreadClass.thread1);
            threadD.Name = "Thread D process";

            threadA.Start();
            threadB.Start();
            threadC.Start();
            threadD.Start();

            threadA.Join();
            threadB.Join();
            threadC.Join();
            threadD.Join();

            label1.Text = "- End of Thread -";
            Console.WriteLine("- End of Thread -");
        }

        public FrmTrackThread()
        {
            InitializeComponent();
        }
    }




    class MyThreadClass
    {
        public static void thread1()
        {
            for (int x = 0; x <= 2; x++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Thread Name: " + thread.Name + "  " + x);
                Thread.Sleep(500);
            }
        }

        public static void thread2()
        {
            for (int y = 1; y <= 5; y++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Thread Name: " + thread.Name + "  " + y);
                Thread.Sleep(1500);
            }
        }
    }
}