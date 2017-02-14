using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WizcationLocal.DBHelpers;

namespace WizcationLocal.Controllers.Api.Hotel
{
    public class SettingController : ApiController
    {

        static readonly ISettingSQL repository = new SettingSQL();

        [HttpGet]
        [ActionName("ListAgentType")]
        public DataTable GetListAgentType()
        {

            return repository.ListAgentType();
        }
    }
}
