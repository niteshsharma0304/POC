using Fizzler.Systems.HtmlAgilityPack;
using HtmlAgilityPack;
using JobLinkDescriptionPOC.Models;
using JobLinkDescriptionPOC.Utilities;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace JobLinkDescriptionPOC.Controllers
{
    public class APIController : ApiController
    {
        [HttpGet]
        //[Route("v1/api/getjobdescription")]
        public IHttpActionResult GetJobDescription(string url)
        {
            JobDetails jobDetails = new JobDetails();
            HtmlWeb htmlWeb = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument htmlDocument = htmlWeb.Load(url);

            //Get Job Description
            string jd = CommonUtils.getJobDescription(htmlDocument);
            string jt = CommonUtils.getTargetJobTitle(htmlDocument);
            string comp = CommonUtils.getTargetCompany(htmlDocument);

            jobDetails.jobDescription = jd;
            jobDetails.targetJobTitle = jt;
            jobDetails.targetCompany = comp;
            return Ok(jobDetails);
        }
    }
}
