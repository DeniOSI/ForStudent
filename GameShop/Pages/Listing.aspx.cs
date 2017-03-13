using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using GameShop.Models;

namespace GameShop.Pages
{
    public partial class Listing : System.Web.UI.Page
    {
        private Repository repository = new Repository();
        private int pageSize = 3;

        protected int CurrentPage
        {
            get
            {
                int page;
                page = int.TryParse(Request.QueryString["page"], out page) ? page : 1;
                return page > MaxPage ? MaxPage : page;
            }
        }

        public int MaxPage { get {
                return (int)Math.Ceiling((decimal)repository.Games.Count() / pageSize);
            }
            }

        protected IEnumerable<Game> GetGames()
        {

            return repository.Games.OrderBy(g => g.GameID).Skip((CurrentPage - 1) * pageSize).Take(pageSize);
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}