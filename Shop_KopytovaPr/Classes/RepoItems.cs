using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_KopytovaPr.Classes
{
    public class RepoItems
    {
        public static List<object> AllItems()
        {
            List<object> allitems = new List<object>();

            allitems.Add(new Children("Игрушка интерактивная", 2200, 3));
            allitems.Add(new Children("Кактус танцующий", 894, 6));
            allitems.Add(new Children("Мягкая игрушка кошка-подушка", 1754, 6));
            allitems.Add(new Sport("Спортивный мужской костюм", 4913, "S"));
            allitems.Add(new Sport("Мяч для водного поло", 812, "61-63 см"));
            allitems.Add(new Sport("Набор для гольфа Partida", 3950, "600*800 мм"));
            allitems.Add(new Elements("Велосипед", 10560, 100, 120));
            allitems.Add(new Elements("Скутер для малышей", 3000, 50, 10));
            allitems.Add(new Elements("Гироскутер", 6780, 60, 20));
            return allitems;
        }
    }
}

