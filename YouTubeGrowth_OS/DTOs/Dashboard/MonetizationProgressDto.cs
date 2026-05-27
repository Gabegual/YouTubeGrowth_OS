namespace YouTubeGrowth_OS.DTOs.Dashboard
{
    public class MonetizationProgressDto
    {
        public string ChannelId { get; set; } = string.Empty;
        public long CurrentSubscribers { get; set; }
        public long RequiredSubscribers { get; set; }
        public int SubscriberProgressPercentage { get; set; }
        public long SubscriberRemaining { get; set; }
        public double CurrentWatchHours { get; set; }
        public double RequiredWatchHours { get; set; }
        public double WatchHoursRemaining { get; set; }
        public int MonetizationProgressPercentage { get; set; }
        public string EstimatedTimeToMonetization { get; set; } = string.Empty;
        public string SuggestedActions { get; set; } = string.Empty;



    }
}
