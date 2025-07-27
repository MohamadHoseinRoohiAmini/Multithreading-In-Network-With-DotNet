namespace Multithreading_In_Network_With_DotNet
{
    /// <summary>
    /// عملیات به طور همزمان انجام می‌شن
    /// -------------------------------------------------
    /// The operations are executed simultaneously.
    /// </summary>
    public class MultiThreadDemo
    {
        public static void Run()
        {
            for (int i = 1; i <= 3; i++)
            {
                int taskId = i;
                new Thread(() =>
                {
                    Console.WriteLine($"[Thread {Thread.CurrentThread.ManagedThreadId}] Start Task {taskId}");
                    Thread.Sleep(500);
                    Console.WriteLine($"[Thread {Thread.CurrentThread.ManagedThreadId}] End Task {taskId}");
                }).Start();
            }
            Thread.Sleep(1000); // Wait for threads to finish
        }
    }
}
