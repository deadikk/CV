using System;
using CV.App_LocalResources;

namespace CV.Models
{
    public class BasicInfoModel
    {
        public int Age
        {
            get
            {
                var diff = DateTime.Now.Date - DateTime.Parse("27 Oct, 1991");
                return (int)diff.Days / 365;
            }
        }//=> DateTime.Now.Year - 1991;
        public string Sex => Res.Male;
        public string Country => Res.Ukraine;
        public string City => Res.Kyiv;
        public string Level => Res.Middle;
        public string CompanyLink => @"https://www.globallogic.com/ua/";
        public string CompanyLabel => "GlobalLogic";

        public string Experience
        {
            get
            {
                var diff = DateTime.Now.Date - DateTime.Parse("01 Oct, 2013");
                var years = (int)diff.Days / 365;
                var months = (int)((diff.Days - years * 365) / 30.5);
                return $"{years}{Res.YearsLabel}, {months}{Res.MonthsLabel}";
               
            }
        }

    }
}