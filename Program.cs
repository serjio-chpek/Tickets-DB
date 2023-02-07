using ConsoleApp21.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Channels;

internal class Program
{
    private static void Main(string[] args)
    {
        ApplicationContext ef = new ApplicationContext();

        //RemovePassanger(); //удаление в метод засунул

        //Console.WriteLine("Напишите имя и номер пассажира");
        //AddPassanger(Console.ReadLine(), Console.ReadLine()); //добавление пассажира тоже в метод

        //AddPoint();  //добавление точки в методе

        //AddTicket(); //добавление билета в методе

        foreach (var item in ef.Tickets.Include(x =>x.Passanger).Include(x => x.PointArrival).Include(x => x.PointDeparture).ToList())
        {
            Console.WriteLine($"{item?.IdTicket}, {item.Passanger?.Name}, {item.PointDeparture?.Value}-{item.PointArrival?.Value}, время отправления - {item.DateArrive}");
        }

        ef.SaveChanges();


        void RemovePassanger() //удаление билета по имени
        {
            Console.WriteLine("Введите имя для удаления билета");
            string NameToRemove = Console.ReadLine();

            foreach (var item1 in ef.Tickets.Include(x => x.Passanger))
            {
                if (item1.Passanger.Name == NameToRemove)
                {
                    ef.Remove(item1);
                }
            }
        }

        void AddPassanger(string Name, string Phone) //добавление пассажира
        {
            Passanger passanger = new Passanger()
            {
                Name = Name,
                Phone = Phone
            };

            ef.Add(passanger);
        }

        void AddPoint() //добавление города
        {
            Console.WriteLine("Введите название города");

            Point point = new Point() { Value = Console.ReadLine() };

            ef.Add(point);
        }

        void AddTicket() //добавление билета
        {
            Console.WriteLine("Напишите имя, город отправления и город прибытия");
            Ticket ticket = new Ticket()
            {
                Passanger = ef.Passangers.FirstOrDefault(x => x.Name == Console.ReadLine()),
                PointDeparture = ef.Points.FirstOrDefault(x => x.Value == Console.ReadLine()),
                PointArrival = ef.Points.FirstOrDefault(x => x.Value == Console.ReadLine()),
                DateArrive = DateTime.Now.AddHours(6)
            };

            ef.Add(ticket);
        }

    }

}


//Console.WriteLine("Введите имя для удаления");
//string NameToRemove = Console.ReadLine();

//foreach (var item1 in ef.Tickets.Include(x => x.Passanger))
//{
//    if (item1.Passanger.Name == NameToRemove)
//    {
//        ef.Remove(item1);
//    }
//}
////тут сделал удаление, сразу после удаления неправильно показывает, потом при втором запуске нормально вроде
///


//Passanger passanger = new Passanger()
//{
//    Name = "Вероника",
//    Phone = "+79272418836"
//};

//ef.Add(passanger);



//Point point = new Point() { Value = "Тольятти" };
//Point point2 = new Point() { Value = "Москва" };
//Point point3 = new Point() { Value = "Брянск" };
//Point point4 = new Point() { Value = "Самара" };
//Point point5 = new Point() { Value = "Нижний Новгород" };

//ef.Add(point);
//ef.Add(point2);
//ef.Add(point3);
//ef.Add(point4);
//ef.Add(point5);




//Ticket ticket = new Ticket()
//{
//    Passanger = ef.Passangers.FirstOrDefault(x => x.Name == "Вероника"),
//    PointDeparture = ef.Points.FirstOrDefault(x => x.Value == "Москва"),
//    PointArrival = ef.Points.FirstOrDefault(x => x.Value == "Самара"),
//    DateArrive = date1
//};

//ef.Add(ticket);