Console.WriteLine("==================== THREADS ====================\n\n");

Console.WriteLine($"Main Thread Id: {Thread.CurrentThread.ManagedThreadId}\n");

// Synchronous 
void SendMessages()
{
    Console.WriteLine("Getting Ready...");
    Thread.Sleep(2000);

    Console.WriteLine("First message arrived!");
    Thread.Sleep(2000);

    Console.WriteLine($"Main Thread Id: {Thread.CurrentThread.ManagedThreadId}\n");

    Console.WriteLine("Second message arrived!");
    Thread.Sleep(2000);

    Console.WriteLine("Third message arrived!");
    Console.WriteLine("All messages are received!");
}

//SendMessages();

// Asynchronous
void SendMessagesWithThread()
{
    Console.WriteLine("Getting Ready...");
    Random rnd = new Random();

    Thread t1 = new Thread(() =>
    {
       int delay = rnd.Next(500, 2000);
        Thread.Sleep(delay);
        Console.WriteLine($"First message arrived after delay {delay} ms![ThreadID: {Thread.CurrentThread.ManagedThreadId}]");
    });

    Thread t2 = new Thread(() =>
    {
        int delay = rnd.Next(500, 2000);
        Thread.Sleep(delay);
        Console.WriteLine($"Second message arrived after delay {delay} ms![ThreadID: {Thread.CurrentThread.ManagedThreadId}]");
    });

    Thread t3 = new Thread(() =>
    {
        int delay = rnd.Next(500, 2000);
        Thread.Sleep(delay);
        Console.WriteLine($"Third message arrived after delay {delay} ms![ThreadID: {Thread.CurrentThread.ManagedThreadId}]");
    })
    { Name = "Our Thread 3" };

    t1.Start(); t2.Start(); t3.Start();

    Console.WriteLine($"Main Thread Id: {Thread.CurrentThread.ManagedThreadId}\n");
    Console.WriteLine("All messages are received! (or not yet...)");
}

SendMessagesWithThread();




Console.ReadLine();
