using System;

namespace _2017_Txt2Srt
{
    public class IdozitettFelirat
    {
        public string Timing { get; set; }
        public string Subtitle { get; set; }

        public int SzavakSzama => Subtitle.Split(' ').Length;

        public string SrtIdozites
        {
            get
            {
                var first = GetSecondsFromString(Timing.Split('-')[0].Trim());
                var second = GetSecondsFromString(Timing.Split('-')[1].Trim());

                return $"{GetTimeStringFromSeconds(first)} ---> {GetTimeStringFromSeconds(second)}";
            }
        }

        public IdozitettFelirat(string timing, string subtitle)
        {
            Timing = timing;
            Subtitle = subtitle;
        }

        private int GetSecondsFromString(string time)
        {
            var split = time.Split(':');
            return int.Parse(split[0]) * 60 + int.Parse(split[1]);
        }

        private string GetTimeStringFromSeconds(int seconds)
        {
            TimeSpan time = TimeSpan.FromSeconds(seconds);
            return time.ToString(@"hh\:mm\:ss");
        }
    }
}
