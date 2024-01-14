using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

public class Program
{
    static MyType _myType = new ();
    
    public static async Task Main()
    {
        var tasksList = new List<Task>();
		
        for(var i=0; i<10000; i++)
        {
            tasksList.Add(Task.Run(DoJob));
        }
		
        await Task.WhenAll(tasksList);
		
        Console.WriteLine("O valor do resource é: " + _myType.Counter);
    }

    private static void DoJob()
    {
        lock (_myType)
        {
            _myType.Counter++;
        }
    }
    
    public class MyType
    {
        public int Counter { get; set; }
    }
}
