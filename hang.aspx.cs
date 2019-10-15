using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BooksShopOnline.Models;
using System.Web.ModelBinding;

namespace BooksShopOnline
{
    public partial class hang: System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IQueryable<Models.hang> GetBooks([QueryString("id")] int? categoryId)
        {
            var _db = new BooksShopOnline.Models.Context();
            IQueryable<Models.hang> query = _db.Books;
            if (categoryId.HasValue && categoryId > 0)
            {
                query = query.Where(p => p.CategoryID == categoryId);
            }
            return query;
        }
    }
}