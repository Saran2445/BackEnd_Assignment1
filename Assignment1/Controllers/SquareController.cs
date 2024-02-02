using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class SquareController : ApiController
    {
        ///<summary>Receives a integer input. Squares it and returns the squared value</summary>
        ///<param name="id">The input integer</param>
        ///<returns>The input integer is squared</returns>
        ///<example>
        ///GET api/route/Square/-2 ->4
        /// </example>
        /// <example>
        ///GET api/route/Square/2 ->4
        /// </example>
        public int Get(int id)
        {
            int square = id * id;
            return square;
        }
    }
}
