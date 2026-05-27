namespace YouTubeGrowth_OS.DTOs.Dashboard
{
    public class ChartPointDto
    {
        public DateTime Date { get; set; }
        public long Views { get; set; }
        public int SubscribersGained { get; set; }
        public double WatchHours { get; set; }
        public long Impressions { get; set; }
        public double ClickThroughRate { get; set; }
        public double AverageViewDuration { get; set; }

    }
}
