using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameShop.Models
{
    public class Game
    {
        public int GameID { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public String Category { get; set; }
        public decimal Price { get; set; }
    }
}