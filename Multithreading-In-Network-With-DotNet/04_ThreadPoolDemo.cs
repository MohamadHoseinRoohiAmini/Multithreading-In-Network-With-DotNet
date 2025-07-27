namespace Multithreading_In_Network_With_DotNet
{
    /// <summary>
    /// در این کلاس از 
    /// ThreadPool 
    /// برای مدیریت نخ‌ها استفاده می‌کنیم که به جای ایجاد نخ‌های جدید، نخ‌های موجود رو دوباره استفاده می‌کنه تا عملکرد بهتری داشته باشه.
    /// ----------------------------------------------------------------------------------
    /// In this class, we use ThreadPool to manage threads, which reuses existing threads instead of creating new ones to improve performance.
    /// </summary>
    public class ThreadPoolDemo
    {
        public static void Run()
        {
            for (int i = 1; i <= 3; i++)
            {
                int taskId = i;
                ThreadPool.QueueUserWorkItem(_ =>
                {
                    Console.WriteLine($"[ThreadPool] Task {taskId} started.");
                    Thread.Sleep(500);
                    Console.WriteLine($"[ThreadPool] Task {taskId} finished.");
                });
            }

            Thread.Sleep(1000);
        }
    }
}
