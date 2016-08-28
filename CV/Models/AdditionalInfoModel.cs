using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CV.App_LocalResources;

namespace CV.Models
{
    public class AdditionalInfoModel
    {
        public string MainInfo => Res.MainSkills.Replace("XXX", "<b>").Replace("xxx", "</b>");
        public string AdditionalInfo => Res.AdditionalSkills.Replace("XXX", "<b>").Replace("xxx", "</b>");

        public string Info => MainInfo + AdditionalInfo;

    }
}