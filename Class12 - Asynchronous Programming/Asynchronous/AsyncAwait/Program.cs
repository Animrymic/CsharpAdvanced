using System.Diagnostics;

Console.WriteLine("================= ASYNC / AWAIT ==================\n\n");

void SendMessage(string message)
{
    Console.WriteLine("Sending message...");
    Thread.Sleep(3000);
    Console.WriteLine($"Message {message} sent!");
    Console.WriteLine($"Current Thread Id:{Thread.CurrentThread.ManagedThreadId}\n");
}

async Task SendMessageAsync(string message)
{
    Console.WriteLine($"Current Thread Id:{Thread.CurrentThread.ManagedThreadId}\n");
    Console.WriteLine("Sending message...");
    await Task.Delay(3000);
    Console.WriteLine($"Current Thread Id:{Thread.CurrentThread.ManagedThreadId}\n");
    Console.WriteLine($"Message {message} sent!");
}

void ShowAd()
{
    Console.WriteLine("While you wait, here's an add. Buy the new 'iPhone 17' for a special price.");
}

Stopwatch stopwatch = new Stopwatch();

Console.WriteLine("=================== Synchronous ===================\n");

stopwatch.Restart();
SendMessage("Hello Avenga Academy!");
ShowAd();
stopwatch.Stop();
Console.WriteLine($"Total time {stopwatch.ElapsedMilliseconds} ms.");

Console.WriteLine("=================== Asynchronous WITHOUT await - Fire and Forget ===================\n");

stopwatch.Restart();
SendMessageAsync("Hello Avenga Academy!");
ShowAd();
stopwatch.Stop();
Console.WriteLine($"Total time {stopwatch.ElapsedMilliseconds} ms.");

Console.WriteLine("=================== Asynchronous WITH await ===================\n");

stopwatch.Restart();
await SendMessageAsync("Hello Avenga Academy!");
ShowAd();
stopwatch.Stop();
Console.WriteLine($"Total time {stopwatch.ElapsedMilliseconds} ms.");






Console.ReadLine(); 
