using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp21.Models
{
    internal class Point
    {
        [Key]
        public int IdPoint { get; set; }
        public string Value { get; set; }
    }
}
