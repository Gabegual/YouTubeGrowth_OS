namespace YouTubeGrowth_OS.DTOs.Dashboard
{
    public class DashboardResponseDto
    {
        public ChannelSummaryDto ChannelSummary { get; set; } = new ChannelSummaryDto();
        public MonetizationProgressDto MonetizationProgress { get; set; } = new MonetizationProgressDto();
        public PerformanceChartDto PerformanceChart { get; set; } = new PerformanceChartDto();
        public List<VideoSummaryDto> LatestVideos { get; set; } = new List<VideoSummaryDto>();
        public List<GrowthInsightDto> AiGrowthInsights { get; set; } = new List<GrowthInsightDto>();
        public List<CompetitorSummaryDto> CompetitorSnapshot { get; set; } = new List<CompetitorSummaryDto>();
    }
}
