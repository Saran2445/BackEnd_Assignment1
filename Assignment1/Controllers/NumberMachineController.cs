using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class NumberMachineController : ApiController
    {
        ///<summary>Receives a float input. Does four mathematical operations and returns the updated value</summary>
        ///<param name="id">The input integer</param>
        ///<returns>The input integer squared,divided b2,added by 1 and then subtracted by 1</returns>
        ///<example>
        ///GET api/route/NumberMachine/10 ->50
        /// </example>
        /// <example>
        ///GET api/route/NumberMachine/-5 ->12.5
        /// </example>
        public float Get(float id)
        {
            float calculation = (id * id) / 2 + 1 - 1;
            return calculation;
        }
    }
}
