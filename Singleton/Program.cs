using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleSingleton();

            SafeThreadSingleton();

            Console.ReadLine();
        }

        static void SimpleSingleton()
        {
            Computer comp = new Computer();
            comp.Launch("Windows 8.1");
            Console.WriteLine(comp.OS.Name);

            // у нас не получится изменить ОС, так как объект уже создан    
            comp.OS = OS.getInstance("Windows 10");
            Console.WriteLine(comp.OS.Name);
        }

        static void SafeThreadSingleton()
        {
            SafeThread.Computer comp = new SafeThread.Computer();
            comp.Launch("Windows 8.1");
            Console.WriteLine(comp.OS.Name);

            // у нас не получится изменить ОС, так как объект уже создан    
            comp.OS = SafeThread.OS.getInstance("Windows 10");
            Console.WriteLine(comp.OS.Name);
        }
    }
}
