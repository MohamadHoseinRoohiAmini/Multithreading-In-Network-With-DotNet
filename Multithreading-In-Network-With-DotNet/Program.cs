using Multithreading_In_Network_With_DotNet;

int i = 0;
do
{
    Console.WriteLine("\n ******************************************* \n");
    Console.WriteLine($@"Enter you execution type "
                  + "\n 1-Single-threaded execution"
                  + "\n 2-Basic multithreaded execution"
                  + "\n 3-Race condition (without lock)"
                  + "\n 4-Solved with lock"
                  + "\n 5-Using ThreadPool"
                  + "\n 6-Async/Await for concurrent IO"
                  + "\n 7-Server simulation with client threads");

    int typeOfExecution = Convert.ToInt32(Console.ReadLine());
    i = typeOfExecution;
    switch (typeOfExecution)
    {
        case 1:
            Console.WriteLine("Single-threaded execution");
            SingleThreadDemo.Run();
            break;
        case 2:
            Console.WriteLine("Basic multithreaded execution");
            MultiThreadDemo.Run();
            break;
        case 3:
            Console.WriteLine("Race condition (without lock)");
            RaceConditionDemo.Run(lockedMode: false);
            break;
        case 4:
            Console.WriteLine("Solved with lock");
            RaceConditionDemo.Run(lockedMode: true);
            break;
        case 5:
            Console.WriteLine("Using ThreadPool");
            ThreadPoolDemo.Run();
            break;
        case 6:
            Console.WriteLine("Async/Await for concurrent IO");
            AsyncAwaitDemo.Run().Wait();
            break;
        case 7:
            Console.WriteLine("Server simulation with client threads");
            ServerSimulation.Run();
            break;
        default:
            Console.WriteLine("Am I joke to you?");
            break;
    }
} while (i != 0);