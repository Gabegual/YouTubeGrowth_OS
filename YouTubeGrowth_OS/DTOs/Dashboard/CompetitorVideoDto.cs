namespace YouTubeGrowth_OS.DTOs.Dashboard
{
    public class CompetitorVideoDto
    {
        public string VideoId { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string ThumbnailUrl { get; set; } = string.Empty;
        public DateTime PublishedDate { get; set; }
        public long Views {  get; set; }
        public long Likes { get; set; }
        public long CommentCount { get; set; }

    }
}
