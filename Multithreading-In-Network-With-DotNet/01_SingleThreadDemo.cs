namespace Multithreading_In_Network_With_DotNet
{
    /// <summary>
    /// عملیات به صورت ترتیبی و پشت سر هم انجام می‌شن
    /// ---------------------------------------------------
    /// The operations are performed sequentially and one after another.
    /// </summary>
    public class SingleThreadDemo
    {
        public static void Run()
        {
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"Processing task {i}");
                Thread.Sleep(500);
            }
        }
    }
}