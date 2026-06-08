Console.WriteLine("\n================== TASKS ==================\n\n");

Console.WriteLine("===== Task Status Lifecycle =====");

//Task myTask = new Task(() => { }); Old way of creating a task
//myTask.Start();

//1) Task without return value
Task myTask = Task.Run(() => 
{ 
    Thread.Sleep(2000);
    Console.WriteLine("Running after 2000 ms");
});

Console.WriteLine($"Right after start: {myTask.Status}");
Thread.Sleep(500);
Console.WriteLine($"While running: {myTask.Status}");
myTask.Wait();
Console.WriteLine($"After completion: {myTask.Status}");

//2) Task with return value integer
Task<int> valueTask = Task.Run(() =>
{
    Thread.Sleep(1500);
    return 300;
});

Console.WriteLine(valueTask.Result);
Console.WriteLine("Status of valueTask: " + valueTask.Status);

Console.WriteLine("====== 20 Tasks ======\n");

Random rnd = new Random();
for (int i = 1; i <= 20; i++)
{
    int temp = i;
    Task.Run(() =>
    {
        int delay = rnd.Next(500, 2000);
        Thread.Sleep(delay);
        Console.WriteLine($"Task {temp} done after {delay} ms. [ThreadID : {Thread.CurrentThread.ManagedThreadId}]");
    });
}

Console.WriteLine($"Main Thread Id: {Thread.CurrentThread.ManagedThreadId}\n");


Console.ReadLine();