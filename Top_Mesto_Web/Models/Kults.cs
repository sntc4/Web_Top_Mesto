using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Top_Mesto_Web.Models
{
    public class Kults
    {
        public int ID { get; set; }
        public string Title { get; set; } //Название парка
        public string Address { get; set; } //Адрес парка
        public string Classif { get; set; } //Размер парка
        public double Rating { get; set; } //Рейтинг парка
    }
}
