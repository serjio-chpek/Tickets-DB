using ConsoleApp21.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace ConsoleApp21.Controller
{
    internal class PassangerController
    {
        ApplicationContext ef = new ApplicationContext();
        public void AddPassanger()
        {
            Console.WriteLine("Введите имя и номер пассажира");
            Passanger passanger = new Passanger()
            {
                Name = Console.ReadLine(),
                Phone = Console.ReadLine(),
            };

            ef.Add(passanger);
            ef.SaveChanges();
        }

        public void EditPassangerName()
        {
                Console.WriteLine("Введите имя, которое нужно изменить");
                var OldName = ef.Passangers.FirstOrDefault(x => x.Name == Console.ReadLine());

                if (OldName != null)
                {
                    Console.WriteLine("Введите новое имя");
                    OldName.Name = Console.ReadLine();
                }
            
            //ef.Update(OldName);
            ef.SaveChanges();
        }
    }
}
