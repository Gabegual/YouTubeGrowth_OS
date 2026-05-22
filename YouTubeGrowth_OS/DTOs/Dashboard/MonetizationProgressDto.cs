namespace YouTubeGrowth_OS.DTOs.Dashboard
{
    public class MonetizationProgressDto
    {
        string channelId { get; set; }
        long currentSubscribers { get; set; }
        long requiredSubscribers { get; set; }
        int subscriberProgressPercentage { get; set; }
        long subscriberRemaining { get; set; }
        double currentWatchHours { get; set; }
        double requiredWatchHours { get; set; }
        double watchHoursRemaining { get; set; }
        int monetizationProgressPercentage { get; set; }
        string estimatedTimeToMonetization { get; set; }
        string suggestedActions { get; set; }



    }
}
