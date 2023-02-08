using ConsoleApp21.Controller;
using ConsoleApp21.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.Design;
using System.Threading.Channels;

internal class Program
{
    private static void Main(string[] args)
    {

        //PassangerController t = new PassangerController();
        //t.AddPassanger();
        //t.EditPassangerName();

        string menu = "дальше";

        while (menu == "дальше" & menu != "стоп")
        {
            Console.WriteLine("Введите цифру для выбора действия" +
                "\n1-добавить пассажира" +
                "\n2-изменить имя пассажира" +
                "\n3-добавить билет" +
                "\n4-удалить билет" +
                "\n5-добавить город");
            int i = Convert.ToInt32(Console.ReadLine());
            if (i == 1)
            {
                PassangerController pascontrol = new PassangerController();
                pascontrol.AddPassanger();
            }
            else if (i == 2)
            {
                PassangerController pascontrol = new PassangerController();
                pascontrol.EditPassangerName();
            }
            else if (i == 3)
            {
                TicketController ticketcontrol = new TicketController();
                ticketcontrol.AddTicket();
            }
            else if (i == 4)
            {
                TicketController ticketcontrol = new TicketController();
                ticketcontrol.DeleteTicketByName();
            }
            else if (i == 5)
            {
                PointController pointcontrol = new PointController();
                pointcontrol.AddPoint();
            }
            Console.WriteLine("Напишите дальше или стоп для продолжения или остановки программы соответственно");
            menu = Console.ReadLine();
        }
    }

}


