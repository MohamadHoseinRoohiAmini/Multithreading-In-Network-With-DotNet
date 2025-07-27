using System.Threading.Tasks;

namespace Multithreading_In_Network_With_DotNet
{
    /// <summary>
    /// در این کلاس یک سرور چندنخی شبیه‌سازی می‌کنیم که چندین اتصال مشتری 
    /// (client) 
    /// رو به صورت همزمان می‌پذیره.
    ///-------------------------------------------------------------
    ///In this class, we simulate a multithreaded server that accepts multiple client connections simultaneously.
    /// </summary>
    public class ServerSimulation
    {
        public static void Run()
        {
            for (int i = 1; i <= 3; i++)
            {
                int clientId = i;
                new Thread(() =>
                {
                    Console.WriteLine($"[Client {clientId}] Connected to server");
                    Thread.Sleep(500);
                    Console.WriteLine($"[Client {clientId}] Disconnected");
                }).Start();
            }

            Thread.Sleep(1000); // Wait for all clients to finish
        }
    }
}