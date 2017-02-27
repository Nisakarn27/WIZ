using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class BaseController : ApiController
    {
        private ApplicationDbContext _db;
        protected ApplicationDbContext db
        {
            get
            {
                if (this._db == null)
                {
                    this._db = new ApplicationDbContext();
                }
                return this._db;
            }
        }
    }
}
