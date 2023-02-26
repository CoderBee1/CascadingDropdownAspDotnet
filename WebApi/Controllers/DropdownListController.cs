using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class DropdownListController : ApiController
    {
        Altkamul_LibraryEntities db = new Altkamul_LibraryEntities();

        // get author list
        [HttpGet]
        public IHttpActionResult Index(int id)
        {
            List<Author> obj = new List<Author>();
            obj = db.Authors.Where(x => x.AuthorId== id).ToList();
            return Ok(obj[0].AuthorName);
        }

        // Get all book list
        [HttpGet]
        public IHttpActionResult GetBook()
        {
            var bookTitle = db.Books.ToList();
            //var obj = db.Books.Where(model => model.BookId == bid).FirstOrDefault();
            return Ok(bookTitle);
        }
    }
}
