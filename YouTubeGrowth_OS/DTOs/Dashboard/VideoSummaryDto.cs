namespace YouTubeGrowth_OS.DTOs.Dashboard
{
    public class VideoSummaryDto
    {
        public int VideoId { get; set; }
        public string VideoURL { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ThumbnailURL { get; set; } = string.Empty;
        public DateTime PublishedDate { get; set; }
        public int Duration { get; set; }
        public long Views { get; set; }
        public long Likes { get; set; }
        public List<string> Comments { get; set; } = new List<string>();
        public long ClickThroughRate { get; set; }
        public double AverageViewDuration { get; set; }
        public double RetentionRate { get; set; }
        public double WatchTime { get; set; }
        public double AiScore { get; set; }
        public string PerformanceCategory { get; set; } = string.Empty;
        public string Recommendations { get; set; } = string.Empty;

    }
}
