using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace banhang.Models
{
    public class BanHang
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Pirce { get; set; }
        public static IEnumerable<BanHang> GetList()
        {
            List<BanHang> li = new List<BanHang>();
            for(int i=0;i<5;i++)
            {
                BanHang bh = new BanHang() { ID = i, Name = "mat hang " + i, Pirce = i };
                li.Add(bh);
            }
            return li;
        }
    }
}