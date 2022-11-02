using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class Car
    {
        public int id { get; set; }
        public string name { get; set; }
        public string shortDesc { get; set; } //Короткое описание
        public string longDesc { get; set; } //Длинное описание
        public string img { get; set; } //url адресс картинки
        public uint price { get; set; }
        public bool isFavourite { get; set; }
        public bool avaible { get; set; }
        public int categoryID { get; set; }
        public virtual Category category { get; set; }
    }
}
