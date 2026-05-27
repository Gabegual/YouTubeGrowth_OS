namespace YouTubeGrowth_OS.DTOs.Dashboard
{
    public class GrowthInsightDto
    {
        public string InsightType { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        public string Recommendation { get; set; } = string.Empty;
        public List<string> RelatedMetrics { get; set; } = new List<string>();
        public int ConfidenceScore { get; set; }
    }
}
