using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameShop.Models
{
    public class Repository
    {
        private EFDBContext context = new EFDBContext();
        public IEnumerable<Game> Games
        {
            get { return context.Games; }
        }
    }
}