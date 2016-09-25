using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.WebPages;
using System.Xml;

namespace CV.Workers
{
    interface ILogger
    {
        void WriteLog(string record);
        int GetVisits();
    }
    public class XmlLogger : ILogger
    {
        public void WriteLog(string record)
        {
            var xDoc = new XmlDocument();

            xDoc.Load(HttpContext.Current.Server.MapPath("Logs\\LogCounter.xml"));
            var counter = xDoc.SelectSingleNode("//totalVisits");
            int visits;
            int.TryParse(counter.InnerText, out visits);
            counter.InnerText = (++visits).ToString();
            xDoc.Save(HttpContext.Current.Server.MapPath("Logs\\LogCounter.xml"));
        }

        public int GetVisits()
        {
            var xDoc = new XmlDocument();
            xDoc.Load(HttpContext.Current.Server.MapPath("..\\Logs\\LogCounter.xml"));
            var counter = xDoc.SelectSingleNode("//totalVisits");
            int visits = 0;
            int.TryParse(counter.InnerText, out visits);
            return visits;
        }


    }
}