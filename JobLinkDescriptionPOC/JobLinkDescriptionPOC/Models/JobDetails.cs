﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobLinkDescriptionPOC.Models
{
    public class JobDetails
    {
        public string jobDescription { get; set; }
        public string targetJobTitle { get; set; }
        public string targetCompany { get; set; }
        public string jobSkills { get; set; }
        public string jobKeys { get; set; }
    }
}