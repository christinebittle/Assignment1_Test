using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_n00000.Controllers
{
    public class FunController : ApiController
    {
        //create some methods
        //GET api/Fun/{id}
        //OUTPUT : Hello
        public string Get(decimal id)
        {
            decimal half = id / 2;
            string message = "Half of " + id.ToString() + " is "+ " " + half.ToString();
            return message;
        }

        //POST api/Fun/{id}

        public string Post(int id)
        {

            return "Hello - you made a POST call";
        }

    }
}
