using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class GreetingController : ApiController
    {
        ///<summary>Receives a integer input. And Returns the string Greetings to {id} people where id is the integer input</summary>
        ///<param name="id">The input integer</param>
        ///<returns>Returns the string Greetings to {id} people where id is the integer input</returns>
        ///<example>
        ///GET api/route/Greeting/0 ->Greetings to 0 people!
        /// </example>
        /// <example>
        ///GET api/route/Greeting/6 ->Greetings to 6 people!
        /// </example>
        public String Get(int id)
        {
            return "Greetings to" + " " + id + " " +"people!";
        }

        ///<summary>Hello world</summary>
        ///<param name="id">The input integer</param>
        ///<returns>Returns the string Hello World</returns>
        ///<example>
        ///once you execute the curl command on command prompt you will get the output as "Hello World!"
        /// </example>
        public String Post()
        {
            return "Hello" + " " + "World!";
        }
    }
}
