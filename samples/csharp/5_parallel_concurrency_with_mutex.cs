using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

public class Program
{
    static int _resource;
    static Mutex _mutex = new ();
	
    public static async Task Main()
    {
        var tasksList = new List<Task>();
		
        for(var i=0; i<10000; i++)
        {
            tasksList.Add(Task.Run(DoJob));
        }
		
        await Task.WhenAll(tasksList);
		
        Console.WriteLine("O valor do resource é: " + _resource);
    }

    private static void DoJob()
    {
        _mutex.WaitOne();
        _resource++;
        _mutex.ReleaseMutex();
    }
}
