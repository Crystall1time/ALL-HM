using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly : log4net.Config.XmlConfigurator(Watch =true)]


namespace Hometask_11
{
    class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {
            log.Debug("Debug Starts");
            IRepository rep = new MotoRepository();
            Motorcycle Moto1 = new Motorcycle(1, "Ducati", "749", 2013, 13000);
            Motorcycle Moto2 = new Motorcycle(2, "Honda", "CBR600F Hurricane", 2014, 15000);
            Motorcycle Moto3 = new Motorcycle(3, "Kawasaki", "Ninja ZX-6R", 2010, 23000);
            Motorcycle Moto4 = new Motorcycle(4, "Honda", "CBR600RR", 2019, 1500);

            rep.CreateMotorcycle(Moto1);
            rep.CreateMotorcycle(Moto2);
            rep.CreateMotorcycle(Moto3);
            rep.CreateMotorcycle(Moto4);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Motorcycles info:");
            Console.ResetColor();
            rep.GetMotorcycles().ForEach(Console.WriteLine);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Update Motorcycle Name. Choose which one from 1 to 4:");
            Console.ResetColor();
            int Num = Convert.ToInt32(Console.ReadLine());
            switch (Num)
            {
                case 1:
                    Console.WriteLine("Input its name: ");
                    Moto1.Name = Console.ReadLine();
                    rep.UpdateMotorcycle(Moto1);
                    break;
                case 2:
                    Console.WriteLine("Input its name: ");
                    Moto2.Name = Console.ReadLine();
                    rep.UpdateMotorcycle(Moto2);
                    break;
                case 3:
                    Console.WriteLine("Input its name: ");
                    Moto3.Name = Console.ReadLine();
                    rep.UpdateMotorcycle(Moto3);
                    break;
                case 4:
                    Console.WriteLine("Input its name: ");
                    Moto4.Name = Console.ReadLine();
                    rep.UpdateMotorcycle(Moto4);
                    break;
                default:
                    Console.WriteLine("Invalid number!");
                    break;
            }
            rep.GetMotorcycles().ForEach(Console.WriteLine);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Get Moto by Its ID. Input number from 1 to 4: ");
            Console.ResetColor();
            Console.WriteLine(rep.GetMotorcycleById(Convert.ToInt32(Console.ReadLine())));
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Which moto would you like to delete? Input number from 1 to 4:");
            Console.ResetColor();
            int Del = Convert.ToInt32(Console.ReadLine());
            switch (Del)
            {
                case 1:
                    rep.DeleteMotorcycle(Moto1);
                    break;
                case 2:
                    rep.DeleteMotorcycle(Moto2);
                    break;
                case 3:
                    rep.DeleteMotorcycle(Moto3);
                    break;
                case 4:
                    rep.DeleteMotorcycle(Moto4);
                    break;
                default:
                    Console.WriteLine("Invalid number!");
                    break;
            }
            rep.GetMotorcycles().ForEach(Console.WriteLine);
            Console.ReadLine();
        }
    }
}
