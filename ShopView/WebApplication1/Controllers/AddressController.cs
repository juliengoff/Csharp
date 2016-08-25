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
    public class AddressController : BaseController<Address>
    {
        [Route("api/ClassAs")]
        public override Task<IHttpActionResult> Post(IEnumerable<Address> values)
        {
            return base.Post(values);
        }

        [Route("api/ClassAs")]
        public override Task<IHttpActionResult> Put(IEnumerable<Address> values)
        {
            return base.Put(values);
        }

        [Route("api/ClassAs")]
        public override Task<IHttpActionResult> Delete(IEnumerable<Address> values)
        {
            return base.Delete(values);
        }
    }
}
