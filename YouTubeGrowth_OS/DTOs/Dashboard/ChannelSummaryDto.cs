namespace YouTubeGrowth_OS.DTOs.Dashboard
{
    public class ChannelSummaryDto
    {
        public string ChannelId { get; set; } = string.Empty;
        public string ChannelName { get; set; }  = string.Empty;
        public string CreatorHandle { get; set; } = string.Empty;
        public string AvatarUrl { get; set; } = string.Empty;
        public string BannerUrl { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }
        public long TotalSubscribers { get; set; }
        public long TotalViews { get; set; }
        public int TotalVideos { get; set; }
        public double TotalWatchHours { get; set; }
    }
}
