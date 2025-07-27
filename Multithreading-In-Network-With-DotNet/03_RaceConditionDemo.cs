namespace Multithreading_In_Network_With_DotNet
{
    /// <summary>
    /// وقتی دو یا چند نخ به طور همزمان به یک منبع مشترک
    /// (مثل متغیر counter)
    /// دسترسی داشته باشن، ممکنه نتایج غیرمنتظره‌ای داشته باشه.
    /// ------------------------------------------------------
    /// When two or more threads access a shared resource (like the counter variable) concurrently, it may lead to unexpected results.
    /// </summary>
    public class RaceConditionDemo
    {
        private static int counter = 0;
        private static readonly object lockObj = new();

        public static void Run(bool lockedMode)
        {
            counter = 0;
            var threads = new List<Thread>();

            for (int i = 0; i < 10; i++)
            {
                threads.Add(new Thread(() =>
                {
                    for (int j = 0; j < 1000; j++)
                    {
                        if (lockedMode)
                            lock (lockObj) counter++;
                        else
                            counter++;
                    }
                }));
            }

            threads.ForEach(t => t.Start());
            threads.ForEach(t => t.Join());

            Console.WriteLine($"Final Counter: {counter} (locked = {lockedMode})");
        }
    }
}