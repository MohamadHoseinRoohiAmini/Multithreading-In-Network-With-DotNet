namespace Multithreading_In_Network_With_DotNet
{
    /// <summary>
    /// در این کلاس از 
    /// async/await
    /// استفاده می‌کنیم تا بدون نیاز به ایجاد نخ‌های جدید، عملیات‌های غیر همزمان 
    /// (asynchronous) رو انجام بدیم
    /// ---------------------------------------------------------------
    /// In this class, we use async/await to perform asynchronous operations without the need to create new threads.
    /// </summary>
    public class AsyncAwaitDemo
    {
        public static async Task Run()
        {
            var tasks = Enumerable.Range(1, 3).Select(async i =>
            {
                Console.WriteLine($"Start async task {i}");
                await Task.Delay(500);
                Console.WriteLine($"End async task {i}");
            });

            await Task.WhenAll(tasks);
        }
    }
}
