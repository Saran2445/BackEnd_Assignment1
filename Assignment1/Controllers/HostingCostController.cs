using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class HostingCostController : ApiController
    ///<summary>Receives a integer input. Outputs 3 Strings</summary>
    ///<param name="id">The input integer</param>
    ///<returns>Mathematical calculations for calculating number of fortNights, fortNightCost, hst and total are calculated and printed over 3 strings</returns>
    ///<example>
    ///GET api/route/HostingCost/15 ->“2 fortnights at $5.50/FN = $11.00 CAD” “HST 13% = $1.43 CAD” “Total = $12.43 CAD”
    /// </example>
    {
        public String Get(double id)
        {
            //even after using ceiling, input value 0 can't be taken as 1 so i used a simple if else statement to resolve this issue :)
            if (id%14==0)
                //for cases where id%14==0 like input values:0,14,28 etc
            {
                double fortNight = Math.Ceiling(id / 14) + 1; 
                //calculating fortNightCost
                double fortNightCost = fortNight * 5.50;
                //Calculating hst
                double hst = fortNightCost * 0.13;
                //adding up both fortNightCost and hst for total
                double total = fortNightCost + hst;

                // below \" is used so that the output string has ""
                // below :F2 is used to round upto 2 decimal values
                // below /n is used for creating new line
                return $"\"{fortNight} fortnights at $5.50/FN=${fortNightCost:F2} CAD\"\n" +
                    $"\" HST 13%=${hst:F2} CAD\"\n" +
                    $"\" Total=${total} CAD\"";
            }
            else
            {
                double fortNight = Math.Ceiling(id / 14);
                double fortNightCost = fortNight * 5.50;
                double hst = fortNightCost * 0.13;
                double total = fortNightCost + hst;
                return $"\"{fortNight} fortnights at $5.50/FN=${fortNightCost:F2} CAD\"\n" +
                    $"\" HST 13%=${hst:F2} CAD\"\n" +
                    $"\" Total=${total} CAD\"";
            }
        }

    }
}

