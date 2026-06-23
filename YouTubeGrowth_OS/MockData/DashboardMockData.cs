using System;
using YouTubeGrowth_OS.DTOs;
using YouTubeGrowth_OS.DTOs.Dashboard;

namespace YouTubeGrowth_OS.MockData
{
    public class DashboardMockData
    {



        public static DashboardResponseDto GetDashboard()
        {
            ChannelSummaryDto channelSummary = new ChannelSummaryDto();
            MonetizationProgressDto monetizationProgress = new MonetizationProgressDto();
            PerformanceChartDto performanceChart = new PerformanceChartDto();
            GrowthInsightDto aiGrowthInsights = new GrowthInsightDto();
            VideoSummaryDto videoSummary = new VideoSummaryDto();
            CompetitorSummaryDto competitorSummary = new CompetitorSummaryDto();

            channelSummary.ChannelId = "US_Test_Channel";
            channelSummary.ChannelName = "Gabe Gaming";
            channelSummary.CreatorHandle = "@gabegaming";
            channelSummary.AvatarUrl = "https://example.com/avatar.png";
            channelSummary.BannerUrl = "https://example.com/bannar.png";
            channelSummary.Description = "Gaming channel  focused on builds, guides, and creator growth";
            channelSummary.CreatedDate = DateTime.Now;
            channelSummary.TotalSubscribers = 123;
            channelSummary.TotalViews = 1240000;
            channelSummary.TotalVideos = 56;
            channelSummary.TotalWatchHours = 3652.5;

            monetizationProgress.ChannelId = "US_Test_Channel";
            monetizationProgress.CurrentSubscribers = 123;



            return new DashboardResponseDto
            {
                ChannelSummary = channelSummary,
                MonetizationProgress = monetizationProgress,
                PerformanceChart = performanceChart,
                AiGrowthInsights = new List<GrowthInsightDto> { aiGrowthInsights },
                LatestVideos = new List<VideoSummaryDto> { videoSummary },
                CompetitorSnapshot = new List<CompetitorSummaryDto> { competitorSummary }

            };
        }

    }
}
