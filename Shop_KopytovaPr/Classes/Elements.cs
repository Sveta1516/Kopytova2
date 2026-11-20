using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_KopytovaPr.Classes
{
    public class Elements : Shop
    {
        public int EmkostAkk { get; set; }
        public int SpeedDrive { get; set; }

        public Elements(string Name, int Price, int EmkostAkk, int SpeedDrive) : base(Name, Price)
        {
            this.EmkostAkk = EmkostAkk;
            this.SpeedDrive = SpeedDrive;
        }
        public override string Characteristic => $"Аккумулятор: {EmkostAkk}; Скорость: {SpeedDrive}";
    }
}
