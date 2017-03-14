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
        private int pageSize = 4;

        private int GetPageFromReuest() //Получение страницы с запроса
        {
            int page;
            string reqValue = (string)RouteData.Values["page"] ?? Request.QueryString["page"];
            return reqValue != null && int.TryParse(reqValue, out page)? page : 1;
        }


        protected int CurrentPage //текущая страница
        {
            get
            {
                int page;
                page = GetPageFromReuest();
                return page > MaxPage ? MaxPage : page;
            }
        }

        public int MaxPage // максимальное количество страниц вычисляется по количеству записей
        {
            get {
                return (int)Math.Ceiling((decimal)repository.Games.Count() / pageSize);
            }
            }

        protected IEnumerable<Game> GetGames() // получение списка игр с базы
        {

            return repository.Games.OrderBy(g => g.GameID).Skip((CurrentPage - 1) * pageSize).Take(pageSize);
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}