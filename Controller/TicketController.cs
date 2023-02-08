using ConsoleApp21.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21.Controller
{
    internal class TicketController
    {
        ApplicationContext ef = new ApplicationContext();

        public void AddTicket()
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
            ef.SaveChanges();
        }

        public void DeleteTicketByName()
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
            ef.SaveChanges();
        }
    }
}
