using Fizzler.Systems.HtmlAgilityPack;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobLinkDescriptionPOC.Utilities
{
    public static class CommonUtils
    {
        //Check with ID's & Class query selector for Job Description
        public static string getJobDescription(HtmlAgilityPack.HtmlDocument htmlDocument)
        {
            string jd = "";
            string[] jdQSList = Constants.jdQSList;
            for (int i = 0; i < jdQSList.Length; i++)
            {
                jd = "";
                var jdElemArr = htmlDocument.DocumentNode.QuerySelectorAll(jdQSList[i]);
                if (jdElemArr != null && jdElemArr.Count() >= 1)
                {
                    jdElemArr.ForEach((x) => {
                        jd = jd + x.InnerText;//.Replace("\n", " ");
                    });
                }
                if (jd != null && jd != "")
                    break;
            }

            if (jd == "")
            {
                jd = "Can't parse the job description, Html fetched from URL: </br>";
                jd = jd + htmlDocument.DocumentNode.OuterHtml;
            }
            return jd;
        }

        public static string getTargetJobTitle(HtmlAgilityPack.HtmlDocument htmlDocument)
        {
            string jt = "";
            string[] jtQSList = Constants.jtQSList;
            for (int i = 0; i < jtQSList.Length; i++)
            {
                jt = "";
                var jtElem = htmlDocument.DocumentNode.QuerySelector(jtQSList[i]);
                if (jtElem != null && !String.IsNullOrEmpty(jtElem.InnerText))
                {
                    jt = jtElem.InnerText;
                    break;
                }
            }
            if (jt.Length > 0)
            {
                int indexAt = jt.ToLower().IndexOf(" at ");
                jt = jt.Substring(0, indexAt);
            }
            return jt;
        }

        public static string getTargetCompany(HtmlAgilityPack.HtmlDocument htmlDocument)
        {
            string comp = "";
            string[] compQSList = Constants.compQSList;
            for (int i = 0; i < compQSList.Length; i++)
            {
                comp = "";
                var jtElem = htmlDocument.DocumentNode.QuerySelector(compQSList[i]);
                if (jtElem != null && !String.IsNullOrEmpty(jtElem.InnerText))
                {
                    comp = jtElem.InnerText;
                    break;
                }
            }
            //if (comp.Length > 0)
            //{
            //    int indexAt = comp.ToLower().IndexOf(" at ");
            //    comp = comp.Substring(0, indexAt);
            //}
            return comp;
        }
    }
}