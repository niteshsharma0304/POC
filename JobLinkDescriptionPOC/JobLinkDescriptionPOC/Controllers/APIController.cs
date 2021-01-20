using Fizzler.Systems.HtmlAgilityPack;
using HtmlAgilityPack;
using JobLinkDescriptionPOC.Models;
using JobLinkDescriptionPOC.Utilities;
using Microsoft.Ajax.Utilities;
using PuppeteerSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace JobLinkDescriptionPOC.Controllers
{
    public class APIController : ApiController
    {
        [HttpGet]
        public async Task<IHttpActionResult> GetJobDescription(string url)
        {

            JobDetails jobDetails = new JobDetails();
            string jd = "";
            string jt = "";
            string comp = "";
            try
            {
                await new BrowserFetcher().DownloadAsync(BrowserFetcher.DefaultRevision);
                using (var browser = await Puppeteer.LaunchAsync(new LaunchOptions { Headless = true }))
                using (var page = await browser.NewPageAsync())
                {
                    try
                    {
                        await page.GoToAsync(url, WaitUntilNavigation.Networkidle0 );
                    }
                    catch { }
                    jd = CommonUtils.getJobDescription(page);
                    jt = CommonUtils.getTargetJobTitle(page);
                    comp = CommonUtils.getTargetCompany(page);
                }

                jobDetails.jobDescription = jd;
                jobDetails.targetJobTitle = jt;
                jobDetails.targetCompany = comp;
                jobDetails.jobSkills = CommonUtils.getParsedJobSkills(jt, comp, jd);
                jobDetails.jobKeys = CommonUtils.getParsedJobKeys(jt, comp, jd);
            }
            catch (Exception ex)
            {
                jobDetails.jobDescription = ex.Message + "\n" + ex.StackTrace;
            }
            return Ok(jobDetails);
        }

        [HttpPost]
        public JobSkillsAndKeys GetParsedJobSkills([FromBody] JobSkills jsonRequest)
        {
            JobSkillsAndKeys jobSkillsAndKeys = new JobSkillsAndKeys();
            jobSkillsAndKeys.jobSkills = CommonUtils.getParsedJobSkills(jsonRequest.jobTitle, jsonRequest.companyName, jsonRequest.jobDescription);
            jobSkillsAndKeys.jobKeys = CommonUtils.getParsedJobKeys(jsonRequest.jobTitle, jsonRequest.companyName, jsonRequest.jobDescription);
            return jobSkillsAndKeys;
        }
    }
}
