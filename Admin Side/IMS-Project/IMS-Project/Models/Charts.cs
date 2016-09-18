using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IMS_Project.Models
{
    public class DonutCharts
    {
        public string label { get; set; }
        public int value { get; set; }
    }
    public class AreaCharts
    {
        public string period { get; set; }
        public int sales { get; set; }
    }
    public class LineCharts
    {
        public string Date { get; set; }
        public int Orders { get; set; }
    }
}