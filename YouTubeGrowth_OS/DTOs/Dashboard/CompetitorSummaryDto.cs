namespace YouTubeGrowth_OS.DTOs.Dashboard
{
    public class CompetitorSummaryDto
    {
        public string ChannelName { get; set; } = string.Empty;
        public string ChannelHandle { get; set; } = string.Empty;
        public string AvatarUrl { get; set; } = string.Empty;
        public long TotalSubscribers { get; set; }
        public long TotalViews { get; set; }
        public long TotalVideos { get; set; }
        public double UploadFrequency { get; set; }
        public long AverageViewsPerVideo { get; set; }
        public List<CompetitorVideoDto> RelatedVideos { get; set; } = new List<CompetitorVideoDto>();
        public List<CompetitorVideoDto> BestPerformingVideos { get; set; } = new List<CompetitorVideoDto>();
        public List<string> WinningTitlePatterns { get; set; } = new List<string>();
        public List<string> WinningThumbnailPatterns { get; set; } = new List<string>();
        public List<string> ContentTopics { get; set; } = new List<string>();
        public DateTime LastUploadDate { get; set; }


    }
}
