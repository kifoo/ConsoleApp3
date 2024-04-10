using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_GUI
{
    internal class Weather_Info
    {
        public int QueryCost { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string ResolvedAddress { get; set; }
        public string Address { get; set; }
        public string Timezone { get; set; }
        public float Tzoffset { get; set; }
        public List<DayData> Days { get; set; }


        public class DayData
        {
            public required string Datetime { get; set; }
            public long DatetimeEpoch { get; set; }
            public double Tempmax { get; set; }
            public double Tempmin { get; set; }
            public double Temp { get; set; }
            public double Feelslikemax { get; set; }
            public double Feelslikemin { get; set; }
            public double Snow { get; set; }
            public double Windspeed { get; set; }
            public double Winddir { get; set; }
            public double Cloudcover { get; set; }
            public double Visibility { get; set; }
            public double Uvindex { get; set; }
            //public double Precipsum { get; set; }
            //public double Precipsumnormal { get; set; }
            //public double Snowsum { get; set; }
            //public string DatetimeInstance { get; set; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Address: {Address}");
            if (Days != null && Days.Any())
            {
                sb.AppendLine("Day summaries:");
                foreach (var day in Days)
                {
                    sb.AppendLine($" - Datetime: {day.Datetime}");
                    sb.AppendLine($"   Tempmax: {day.Tempmax}");
                    sb.AppendLine($"   Tempmin: {day.Tempmin}");
                    sb.AppendLine($"   Temp: {day.Temp}");
                    sb.AppendLine($"   Feelslikemax: {day.Feelslikemax}");
                    sb.AppendLine($"   Feelslikemin: {day.Feelslikemin}");
                    sb.AppendLine($"   Snow: {day.Snow}");
                    sb.AppendLine($"   Windspeed: {day.Windspeed}");
                    sb.AppendLine($"   Winddir: {day.Winddir}");
                    sb.AppendLine($"   Cloudcover: {day.Cloudcover}");
                    sb.AppendLine($"   Visibility: {day.Visibility}");
                    sb.AppendLine($"   Uvindex: {day.Uvindex}");
                }
            }
            return sb.ToString();
        }


    }
}
