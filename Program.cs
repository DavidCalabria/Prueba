using System;
using System.Diagnostics;
using System.Threading;
//using System.Threading.Tasks;
//using Aron.Weiler;

//namespace MultiKeyGenericDictionarySpike
//{
    //class Program
    //{
    //    // Instantiate class with a value (string), primary key (int) and sub key (string)
    //    static MultiKeyDictionary<int, string, string> dictionary = new MultiKeyDictionary<int, string, string>();

    //    static CountdownEvent countDown;

    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Adding 'Zero' to dictionary with primary int key of '0'");
    //        dictionary.Add(0, "Zero");
    //        Console.WriteLine("Associating binary sub key of '0000' with primary int key of '0'");
    //        dictionary.Associate("0000", 0);

    //        Console.WriteLine("");

    //        Console.WriteLine("Adding 'One' to dictionary with primary int key of '1'");
    //        dictionary.Add(1, "One");
    //        Console.WriteLine("Associating binary sub key of '0001' with primary int key of '1'");
    //        dictionary.Associate("0001", 1);

    //        Console.WriteLine("");

    //        Console.WriteLine("Adding 'Two' to dictionary with primary int key of '2' and a binary sub key of '0010'");
    //        dictionary.Add(2, "0010", "Two");

    //        Console.WriteLine("");

    //        Console.WriteLine("Adding 'Three' to dictionary with primary int key of '3' and a binary sub key of '0011'");
    //        dictionary.Add(3, "0011", "Three");

    //        Console.WriteLine("------------------");

    //        Console.WriteLine("Adding invalid key...");

    //        try
    //        {
    //            dictionary.Add(4, "0100", "Four");
    //            dictionary.Associate("4", 4);
    //        }
    //        catch (ArgumentException)
    //        {
    //            Console.WriteLine("Invalid key threw exception!  (that's a good thing)");
    //        }		

    //        Console.WriteLine("------------------");

    //        Console.WriteLine("Checking values...");

    //        Console.WriteLine("------------------");

    //        Console.WriteLine("Getting value for binary sub key 0000: " + dictionary["0000"]);
    //        Console.WriteLine("Getting value for int primary key 0: " + dictionary[0]);

    //        Console.WriteLine("");

    //        Console.WriteLine("Getting value for binary sub key 0001: " + dictionary["0001"]);
    //        Console.WriteLine("Getting value for int primary key 1: " + dictionary[1]);

    //        Console.WriteLine("");

    //        Console.WriteLine("Getting value for binary sub key 0010: " + dictionary["0010"]);
    //        Console.WriteLine("Getting value for int primary key 2: " + dictionary[2]);

    //        Console.WriteLine("");

    //        Console.WriteLine("Getting value for binary sub key 0011: " + dictionary["0011"]);
    //        Console.WriteLine("Getting value for int primary key 3: " + dictionary[3]);

    //        Console.WriteLine("------------------");

    //        Console.WriteLine("Removing all dictionary entries and sub entries");
    //        dictionary.Remove(0);
    //        dictionary.Remove("0001");
    //        dictionary.Remove("0010");
    //        dictionary.Remove(3);
    //        dictionary.Remove(4);

    //        Console.WriteLine("Dictionary Count: " + dictionary.Count + ", Subdictionary Count: " + dictionary.subDictionary.Count);

    //        perfTest:

    //        Console.WriteLine("------------------");
    //        Console.WriteLine("");

    //        Console.WriteLine("Performance Test Running...");
    //        Console.WriteLine("");

    //        Stopwatch sw = new Stopwatch();
    //        countDown = new CountdownEvent(10);

    //        int seed = 100000;
    //        int count = 99999;

    //        Task[] tasks = new Task[10];

    //        for (int i = 0; i < 10; i++)
    //        {
    //            int temp = i;

    //            tasks[i] = new Task(() => DictionaryPerfTest(temp * seed + 1, count));
    //        }			

    //        sw.Start();

    //        foreach (Task task in tasks)
    //        {
    //            task.Start();
    //        }

    //        countDown.Wait();

    //        sw.Stop();

    //        Console.WriteLine("Done in {0} ticks for dictionary", sw.ElapsedTicks);			

    //        Console.WriteLine("Press any key to quit, or P to run perf test again...");
    //        if (Console.ReadKey().Key == ConsoleKey.P)
    //            goto perfTest;
    //    }
		
    //    private static void DictionaryPerfTest(int seed, int count)
    //    {
    //        Parallel.For(seed, seed + count, (i) =>
    //        {
    //            dictionary.Add(i, string.Format("Sub Key {0}", i), string.Format("Value {0}", i));
    //        });

    //        Parallel.For(seed, seed + count, (i) =>
    //        {
    //            Debug.Assert(dictionary[i] == (string.Format("Value {0}", i)));
    //        });

    //        Parallel.For(seed, seed + count, (i) =>
    //        {
    //            dictionary.Associate(string.Format("Sub Key {0}", i), i);
    //        });

    //        Parallel.For(seed, seed + count, (i) =>
    //        {
    //            Debug.Assert(dictionary[string.Format("Sub Key {0}", i)] == (string.Format("Value {0}", i)));
    //        });

    //        Parallel.For(seed, seed + count, (i) =>
    //        {
    //            dictionary.Remove(i);
    //        });

    //        countDown.Signal();
    //    }		
    //}
//}
