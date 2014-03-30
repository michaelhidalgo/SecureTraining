using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
namespace CSRFDemo.Controllers
{
    
    [System.Web.Http.Authorize]

    public class UsersController : ApiController
    {
        // GET api/users
        [System.Web.Http.Authorize(Users = "sdsd")]
        public IEnumerable<aspnet_Users> Get()
        {
            var entity = new CSRFEntities();
            var results = entity.aspnet_Users.ToList();
            return results.AsEnumerable();
        }

        // GET api/values/5
        public IEnumerable<aspnet_Users> Get(string id)
        {
            var context = HttpContext.Current;
         
            using (var userdata = new  CSRFEntities())
            {
                var query = Guid.Parse(id);
                var user = userdata.aspnet_Users.Where(x => x.UserId == query);
                return user.ToList();
            }
           
        }

        // POST api/values
        public void Post(string id,[FromBody]bool  value, Guid csrftoken)
        {
            using (var userdata = new CSRFEntities())
            {
                var query = Guid.Parse(id);
                var user = userdata.aspnet_Users.FirstOrDefault(x => x.UserId == query);

                if (user != null)
                {
                    user.IsAdmin = value;
                }
                userdata.SaveChanges();
            }
        }

        // PUT api/values/5
        public void Put(string id, [FromBody]bool  value)
        {

            using (var userdata = new CSRFEntities())
            {
                var query = Guid.Parse(id);
                var user = userdata.aspnet_Users.FirstOrDefault(x => x.UserId == query);

                if (user != null)
                {
                   user.IsAdmin = value;
                }
                userdata.SaveChanges();
            }
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
