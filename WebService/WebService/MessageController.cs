﻿using System;
using Microsoft.Owin;
using Owin;
using Microsoft.Owin.Hosting;
using System.Web.Http;
using System.Collections.Generic;
using System.Net;
using System.Web.Http.Cors;

namespace WebService
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class MessageController : ApiController
    {
        // GET api/values
        public Message Get()
        { 
            return new Message()
            {
                Now = DateTime.Now, 
                WhoAmI = Dns.GetHostEntry(Dns.GetHostName()).HostName, 
                Content = @"Nice to see you !"
            }; 
        }

        // GET api/values/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/values
        public void Post([FromBody]Message value)
        { 
        }
    }
}

