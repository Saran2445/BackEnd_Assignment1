using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class AddTenController : ApiController
    {
        ///<summary>Receives a integer input. Does Addition and returns the added value</summary>
        ///<param name="id">The input integer</param>
        ///<returns>The input integer added by 10</returns>
        ///<example>
        ///GET api/route/AddTen/21 ->31
        /// </example>
        /// <example>
        ///GET api/route/AddTen/1 ->11
        /// </example>
        public int Get(int id)
        {
            int addition = id + 10;
            return addition;
        }
    }
}
