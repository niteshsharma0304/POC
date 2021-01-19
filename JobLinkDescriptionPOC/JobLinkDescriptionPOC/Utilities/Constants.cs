using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobLinkDescriptionPOC.Utilities
{
    public static class Constants
    {
        public static string[] jdQSList =
        {
            "#description",
            "#jobDescriptionText",
            "#job-description",
            "#jdp_description",
            "#job-details",
            "#JobDescriptionContainer",
            ".usajobs-content-well .usajobs-joa-section",
            ".viewjob-jobDescription",
            ".job-description",
            ".job_description",
            ".job-detail-list",
            "section.description",
            "[aria-label='Job details']",
            "[data-content='#JobDescription']",
            "[data-async-type='jb_detail_view']",
            "[data-test='JobDetail'] [class*='styles_content']"
        };

        public static string[] jtQSList =
        {
            ".job-view-title"
        };

        public static string[] compQSList =
        {
            ".job-view-header-details a"
        };
    }
}