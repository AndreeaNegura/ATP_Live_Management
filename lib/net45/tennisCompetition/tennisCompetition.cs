using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITF_LiveManagement
{
    public class tennisCompetition
    {
        public string betradarId { get; set; }
        public string playerOne { get; set; }
        public string playerTwo { get; set; }
        public DateTime scheduledTime { get; set; }
        public string status { get; set; }
        public string match_status { get; set; }
        public string home_score { get; set; }
        public string away_score { get; set; }

        public static DateTime ParseScheduledTime(string schedule)
        {
            DateTime scheduledTime;
            try
            {
                scheduledTime = DateTime.ParseExact(schedule, "yyyy-MM-ddTHH:mm:ss+00:00", System.Globalization.CultureInfo.InvariantCulture);
            }
            catch
            {
                Console.WriteLine("Parsing not successfull using GMT! Trying with what is before +...");
                scheduledTime = DateTime.ParseExact(schedule.Split('+')[0], "yyyy-MM-ddTHH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
            }

            return scheduledTime;
        }

    }
}
