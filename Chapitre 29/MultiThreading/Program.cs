using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lancement du thread principal");

            ThreadStart newThread = new ThreadStart(OtherThread);
            Thread thread = new Thread(newThread);
            thread.Start();

            Console.WriteLine("Suspension du thread principal pour 5 secondes");
            Thread.Sleep(5000);

            thread = new Thread(new ThreadStart(OtherThread));
            thread.Start();
            Console.WriteLine("Annulation du thread depuis un autre");
            thread.Abort();

            thread = new Thread(new ThreadStart(AbortThread));
            thread.Start();

            Console.WriteLine("Thread principal terminé");

            Console.ReadLine();

            Console.WriteLine("Lancement du thread avec ParameterizedThreadStart");
            thread = new Thread(new ParameterizedThreadStart(ParameterizedThread));
            thread.Start(10);

            Console.ReadLine();

            Console.WriteLine("Lancement du thread avec encapsulation");
            CustomThread cThread = new CustomThread() { intValue = 10, stringValue = "Ma valeur" };
            thread = new Thread(new ThreadStart(cThread.ThreadMethod));
            thread.Start();

            Console.ReadLine();

            Console.WriteLine("Lancement du thread avec encapsulation et retour");
            CustomThread cusThread = new CustomThread()
            {
                intValue = 10,
                stringValue = "Ma valeur",
                Callback = new CustomCallback(DisplayCallback)
            };
            thread = new Thread(new ThreadStart(cusThread.ThreadMethod));
            thread.Start();

            Console.ReadLine();

            Console.WriteLine("Lancement du thread avec verrouillage");
            cThread = new CustomThread();
            Thread thread1 = new Thread(new ThreadStart(cThread.LockedThread));
            thread1.Start();
            Thread thread2 = new Thread(new ThreadStart(cThread.LockedThread));
            thread2.Start();

            Console.ReadLine();

            Console.WriteLine("Lancement de threads sans priorité");
            thread1 = new Thread(new ThreadStart(Counter1));
            thread2 = new Thread(new ThreadStart(Counter2));
            thread1.Start();
            thread2.Start();

            Console.ReadLine();

            Console.WriteLine("Lancement de threads avec priorité");
            thread1 = new Thread(new ThreadStart(Counter1));
            thread2 = new Thread(new ThreadStart(Counter2));
            thread1.Priority = ThreadPriority.Lowest;
            thread2.Priority = ThreadPriority.Highest;
            thread1.Start();
            thread2.Start();

            Console.ReadLine();

            Console.WriteLine("Lancement d'une fonction longue");
            DateTime debut = DateTime.Now;
            double resultat = TimeConsumingFunction();
            DateTime fin = DateTime.Now;
            Console.Write("Résultat: ");
            Console.WriteLine(resultat);
            Console.Write("Temps d'exécution: ");
            Console.WriteLine(TimeSpan.FromTicks(fin.Ticks - debut.Ticks).TotalSeconds);

            Console.ReadLine();

            Console.WriteLine("Lancement d'une fonction longue asynchrone");
            int i = 0;
            Task<double> task = TimeConsumingFunctionAsync();
            TaskAwaiter<double> awaiter = task.GetAwaiter();
            awaiter.OnCompleted(() =>
            {
                i = 20;
                double resultat2 = awaiter.GetResult();
                Console.Write("Résultat: ");
                Console.WriteLine(resultat2);
            });
            for (i = 1; i < 15; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }

            Console.ReadLine();

            Console.WriteLine("Lancement asynchrone avec await et async");
            TimeConsumingFunctionAsync2();

            Console.ReadLine();

            Console.WriteLine("Lancement asynchrone dans une itération");
            Iteration();
            for (int j = 1; j < 20; j++)
            {
                Console.WriteLine(j);
                Thread.Sleep(1000);
            }

            Console.ReadLine();
        }
        public static void OtherThread()
        {
            Console.WriteLine("Lancement du thread secondaire");

            Console.WriteLine("Thread secondaire terminé");
        }
        public static void AbortThread()
        {
            Console.WriteLine("Annulation du thread depuis Thread.CurrentThread.Abort");
            Thread.CurrentThread.Abort();
        }
        public static void ParameterizedThread(object o)
        {
            Console.WriteLine("Valeur passée au thread: {0}", o);
        }
        public static void DisplayCallback(string s)
        {
            Console.WriteLine("Valeur retournée par le thread: {0}", s);
        }
        public static void Counter1()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("{0} ", i);
            }
        }
        public static void Counter2()
        {
            for (int i = 11; i <= 20; i++)
            {
                Console.Write("{0} ", i);
            }
        }
        public static double TimeConsumingFunction()
        {
            double x = 1;
            for (int i = 1; i < 100000000; i++)
            {
                x += Math.Tan(x) / i;
            }
            return x;
        }
        public static Task<double> TimeConsumingFunctionAsync()
        {
            return Task.Run(() => TimeConsumingFunction());
        }
        public static async void TimeConsumingFunctionAsync2()
        {
            double resultat = await TimeConsumingFunctionAsync();
            Console.Write("Résultat: ");
            Console.WriteLine(resultat);
        }
        public static async void Iteration()
        {
            for (int i = 0; i < 2; i++)
            {
                double resultat = await TimeConsumingFunctionAsync();
                Console.Write("Résultat " + (i + 1) + ": ");
                Console.WriteLine(resultat);
            }
        }
    }
    public class CustomThread
    {
        public int intValue { get; set; }
        public string stringValue { get; set; }
        public CustomCallback Callback { get; set; }

        public void ThreadMethod()
        {
            Console.WriteLine("Valeurs passée au thread:");
            Console.WriteLine("intValue = {0}", intValue);
            Console.WriteLine("stringValue = {0}", stringValue);
            if (Callback != null)
                Callback(string.Format("{0}: {1}", stringValue, intValue));
        }
        public void LockedThread()
        {
            lock (this)
            {
                Console.WriteLine("Le thread est verrouillé");
                Thread.Sleep(2000);
                Console.WriteLine("Le thread est déverrouillé");
            }
        }
    }
    public delegate void CustomCallback(string returnValue);
}
