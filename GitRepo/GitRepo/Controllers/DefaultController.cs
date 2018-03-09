using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GitRepo.Controllers
{
    public class DefaultController : ApiController
    {// Changed in BranchA
        public string Post()
        {
            return "This new Repo";

        }
    }
}
