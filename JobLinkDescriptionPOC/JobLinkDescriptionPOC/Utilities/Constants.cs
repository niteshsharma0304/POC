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
            ".job-description-content",
            ".job-detail-list",
            "section.description",
            "[class*='jobsearch-JobComponent']",
            "[aria-label='Job details']",
            "[data-content='#JobDescription']",
            "[data-async-type='jb_detail_view']",
            "[data-test='JobDetail'] [class*='styles_content']",
            "iframe[id='vjs-container-iframe']\")[0] && document.querySelectorAll(\"iframe[id='vjs-container-iframe']\")[0].contentDocument.querySelectorAll(\"[class*='jobsearch-JobComponent']"
        };

        public static string[] jtQSList =
        {
            "h1.jobsearch-JobInfoHeader-title",
            "div.smarterBannerEmpInfo",
            "div.empWrapper",
            "h1.topcard__title",
            "h2.topcard__title",
            "#jdp-data div.data-display-header_info-content h2",
            "#jdp-data div.data-display-header_info-content h2",
            "#JobViewHeader div.heading h1.title",
            "#JobViewHeader div.heading h1.title",
            "div.job-row .h1",
            "div.job-row .h1",
            "div.viewjob-jobTitle",
            "div.viewjob-jobTitle",
            "#job-title",
            "div.container h1",
            ".job-view-title"
        };

        public static string[] compQSList =
        {
            ".jobsearch-CompanyInfoWithoutHeaderImage div.jobsearch-InlineCompanyRating div",
            "div.smarterBannerEmpInfo",
            "div.empWrapper",
            "h3.topcard__flavor-row span.topcard__flavor:nth-child(1)",
            "h3.topcard__flavor-row span.topcard__flavor:nth-child(1)",
            "#jdp-data div.data-display-header_info-content div.data-details span:nth-child(1)",
            "#jdp-data div.data-display-header_info-content div.data-details span:nth-child(1)",
            "#JobViewHeader div.heading h1.title",
            "#JobViewHeader div.heading h1.title",
            "#jobDetails .company-name",
            "#jobDetails .company-name",
            "div.viewjob-header-companyInfo div.viewjob-labelWithIcon:nth-child(1)",
            "div.viewjob-header-companyInfo div.viewjob-labelWithIcon:nth-child(1)",
            "[class*='agency']",
            ".job-view-header-details a"
        };

        //Constants
        public static string querySelector = "document.querySelector(\"{0}\") && document.querySelector(\"{0}\").innerText";
        public static string customIFrameJDQuery =
            "document.querySelector(\"iframe[id = 'vjs-container-iframe']\")" +
            "&& document.querySelector(\"iframe[id = 'vjs-container-iframe']\").contentDocument.querySelector(\"[class*='jobsearch-JobComponent']\")" +
            "&& document.querySelector(\"iframe[id = 'vjs-container-iframe']\").contentDocument.querySelector(\"[class*='jobsearch-JobComponent']\").innerText";
        public static string customIFrameJTQuery =
            "document.querySelector(\"iframe[id = 'vjs-container-iframe']\")" +
            "&& document.querySelector(\"iframe[id = 'vjs-container-iframe']\").contentDocument.querySelector('h1.jobsearch-JobInfoHeader-title')" +
            "&& document.querySelector(\"iframe[id = 'vjs-container-iframe']\").contentDocument.querySelector('h1.jobsearch-JobInfoHeader-title').innerText";
        public static string customIFrameCompQuery =
            "document.querySelector(\"iframe[id = 'vjs-container-iframe']\")" +
            "&& document.querySelector(\"iframe[id = 'vjs-container-iframe']\").contentDocument.querySelector('.jobsearch-CompanyInfoWithoutHeaderImage div.jobsearch-InlineCompanyRating div')" +
            "&& document.querySelector(\"iframe[id = 'vjs-container-iframe']\").contentDocument.querySelector('.jobsearch-CompanyInfoWithoutHeaderImage div.jobsearch-InlineCompanyRating div').innerText";
        public static string querySelectorAll =
            "(function () {" +
            "var result=\"\";" +
            "var jdElemArr =  document.querySelectorAll(\"{0}\");" +
            "if(jdElemArr && jdElemArr.length){" +
            "jdElemArr.forEach((x)=>{" +
            "result = result + x.innerText;" +
            "});" +
            "}" +
            "return result; " +
            "}())";
        public static string token = "gKm1Sw8YNd0xvJkOtY6EjoQ8ELVUvqD9TEUNPrygTFF85vAc-Dl74ZrvIp2yfMgaUwiGNtsGJOIWR1DRsHLP2_hk4CHzlau3YcpU_5a46l1UuRZvY_4H3CAlzIcL7L8YTfikMIH8MRrckoG47QPWX4B7jVu-LBvmsDtgw5aaRUQH44LbaNNy8kmvl4o180qkHA2fG81MOH3sOfkMuzBzm3XcVgOsrp4eRUaWQizmiSs-TGmyvLyUrewCVKX07ZGoipFTT5Owzjz7gJSIXr6v12uez4JnMwG7cFM0LJ-ORVr4-Y5kI1-WjdMvtsvFo-Vas08wdIFyFVHDVDztYXG_7aOIP0WXH3jKAFqQVP0mwoAEnSkBHwCuA2zOQYBixN2tDv_YjMzVliGTJTVbKjkDhPzbvbU99F1yPgAkXeZWxmH739YZRwfPXQRZ9Hpe2vDaBAsFv5Y-7IpFK0pfMLwZnhT9w1pUm-HQyiZqp_Q9b5XsZ3hrx26NnSyKce2Fxjf_vb-xUOxYZGDYXMgEH1R6kKyzepsbl7R8AF6oVCDeXx5Br3jneR7hEjWvq0Lpvo3csHqzqxIEwBDhgTXwIuEDNiqan6cVrS0u_9_Les7sxTSHeRDtPXnh0IVxIrSKOH6QNPeOLjxMewBIcTYH7HnH4I6GcEXVlJewD4SHQr5N8PaXgvIt9IbPgcAbksrsFRXmQSy1dkf3LuXteDFfJZmgFEETXFbQWZS-GwGPzlNVGzyB7rLW0SRL7gYfQLFLtpym";
    }
}