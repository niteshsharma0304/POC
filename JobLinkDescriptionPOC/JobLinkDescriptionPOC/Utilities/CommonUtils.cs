using Fizzler.Systems.HtmlAgilityPack;
using Microsoft.Ajax.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PuppeteerSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace JobLinkDescriptionPOC.Utilities
{
    public static class CommonUtils
    {
        //Declarations
        private static readonly HttpClient client = new HttpClient();

        public static string getJobDescription(Page page)
        {
            string jd = "";
            string query;
            string[] jdQSList = Constants.jdQSList;
            JToken result = null;
            int i = 0;
            try
            {
                for (i = 0; i < jdQSList.Length; i++)
                {
                    query = Constants.querySelectorAll.Replace("{0}", jdQSList[i]);
                    result = page.EvaluateExpressionAsync(query).Result;
                    if (((JValue)result).Value != "")
                    {
                        jd = result.ToString();
                        break;
                    }
                }
                if(jd=="")
                {
                    result = page.EvaluateExpressionAsync(Constants.customIFrameJDQuery).Result;
                    jd = result != null ? result.ToString() : "";
                }
                if (jd == "")
                {
                    query = Constants.querySelector.Replace("{0}", "*");
                    result = page.EvaluateExpressionAsync(query).Result;
                    jd = "Can't parse the job description, Html fetched from URL: \n";
                    jd = jd + result.ToString();
                }
            }
            catch (Exception ex) { jd = "i: " + i + ", Selector: " + jdQSList[i] + ", " + ex.Message + "-" + ex.StackTrace; }
            return jd;
        }

        public static string getTargetJobTitle(Page page)
        {
            string jt = "";
            string query;
            string[] jtQSList = Constants.jtQSList;
            JToken result = null;
            int i = 0;
            try
            {
                for (i = 0; i < jtQSList.Length; i++)
                {
                    query = Constants.querySelector.Replace("{0}", jtQSList[i]);
                    result = page.EvaluateExpressionAsync(query).Result;
                    if (result != null)
                    {
                        jt = result.ToString();
                        break;
                    }
                }
                if (jt == "")
                {
                    result = page.EvaluateExpressionAsync(Constants.customIFrameJTQuery).Result;
                    jt = result != null ? result.ToString() : "";
                }
                if (jt.Length > 0)
                {
                    int indexAt = jt.ToLower().IndexOf(" at ");
                    if(indexAt > 2)
                        jt = jt.Substring(0, indexAt);
                }
            }
            catch (Exception ex) { jt = "i: " + i + ", Selector: " + jtQSList[i] + ", " + ex.Message + "-" + ex.StackTrace; }
            return jt;
        }

        public static string getTargetCompany(Page page)
        {
            string comp = "";
            string query;
            string[] compQSList = Constants.compQSList;
            JToken result = null;
            int i = 0;
            try
            {
                for (i = 0; i < compQSList.Length; i++)
                {
                    query = Constants.querySelector.Replace("{0}", compQSList[i]);
                    result = page.EvaluateExpressionAsync(query).Result;
                    if (result != null)
                    {
                        comp = result.ToString();
                        break;
                    }
                }
                if (comp == "")
                {
                    result = page.EvaluateExpressionAsync(Constants.customIFrameCompQuery).Result;
                    comp = result != null ? result.ToString() : "";
                }
                if (comp.Length > 0)
                {
                    int indexAt = comp.ToLower().IndexOf(" at ");
                    if (indexAt > 2)
                        comp = comp.Substring(indexAt + 3);
                }
            }
            catch (Exception ex) { comp = "i: " + i + ", Selector: " + compQSList[i] + ", " + ex.Message + "-" + ex.StackTrace; }
            return comp;
        }

        public static string getParsedJobSkills(string targetJobTitle, string targetCompany, string jobDescription)
        {
            var request = new Dictionary<string, string>
            {
                { "jobTitle", targetJobTitle },
                { "companyName", targetCompany },
                { "jobDescription", jobDescription }
            };
            string jsonRequest = JsonConvert.SerializeObject(request);
            var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Constants.token);
            var response = client.PostAsync("https://qa-api-de-jobs.livecareer.com/v1/jobs/skills", content).Result;
            var responseString = response.Content.ReadAsStringAsync().Result;
            return responseString;
        }

        public static string getParsedJobKeys(string targetJobTitle, string targetCompany, string jobDescription)
        {
            var request = new Dictionary<string, string>
            {
                { "jobTitle", targetJobTitle },
                { "companyName", targetCompany },
                { "jobDescription", jobDescription }
            };
            string jsonRequest = JsonConvert.SerializeObject(request);
            var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Constants.token);
            var response = client.PostAsync("https://qa-api-de-jobs.livecareer.com/v1/jobs/keywords", content).Result;
            var responseString = response.Content.ReadAsStringAsync().Result;
            return responseString;
        }
    }
}