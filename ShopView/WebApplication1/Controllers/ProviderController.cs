using ShopCsharp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using WebApplication1.Controllers.Base;

namespace WebApplication1.Controllers
{
    public class ProviderController : BaseController<Provider>
    {
        [Route("api/ClassAs")]
        public override Task<IHttpActionResult> Post(IEnumerable<Provider> values)
        {
            return base.Post(values);
        }

        [Route("api/ClassAs")]
        public override Task<IHttpActionResult> Put(IEnumerable<Provider> values)
        {
            return base.Put(values);
        }

        [Route("api/ClassAs")]
        public override Task<IHttpActionResult> Delete(IEnumerable<Provider> values)
        {
            return base.Delete(values);
        }
    }
}
