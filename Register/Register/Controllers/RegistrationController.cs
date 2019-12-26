using Register.Filters;
using RegisterWeb.Models;
using RegisterWeb.ModelsDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RegisterWeb.Controllers
{
    public class RegistrationController : ApiController
    {
        RegisterDbContext DB = new RegisterDbContext();

        [HttpPost]
        [ValidateModel]
        [Route("api/register")]
        public HttpResponseMessage Registration(EmailPassword login)
        {
                ModelsDB.Register emailPassword = new ModelsDB.Register();
                var logins = DB.Register.Where(p => p.Email == login.Email);
                if (logins != null)
                {
                    emailPassword.Email = login.Email;
                    emailPassword.Password = login.Password;
                    DB.Register.Add(emailPassword);
                    DB.SaveChanges();
                    return new HttpResponseMessage(HttpStatusCode.OK);
                }
            return new HttpResponseMessage(HttpStatusCode.BadRequest);
        }

    }
}
