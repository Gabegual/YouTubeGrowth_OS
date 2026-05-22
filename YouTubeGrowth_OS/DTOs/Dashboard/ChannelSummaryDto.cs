namespace YouTubeGrowth_OS.DTOs.Dashboard
{
    public class ChannelSummaryDto
    {
        string ChannelId { get; set; }
        string ChannelName { get; set; }
        string CreatorHandle { get; set; }
        string AvatarUrl { get; set; }
        string BannerUrl { get; set; }
        string Description { get; set; }
        DateTime CreatedDate { get; set; }
        long TotalSubscribers { get; set; }
        long TotalViews { get; set; }
        int TotalVideos { get; set; }
        double TotalWatchHours { get; set; }
    }
}
