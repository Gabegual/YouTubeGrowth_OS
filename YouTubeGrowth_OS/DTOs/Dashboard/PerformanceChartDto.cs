namespace YouTubeGrowth_OS.DTOs.Dashboard
{
    public class PerformanceChartDto
    {
        public string DateRange { get; set; } = string.Empty;
        public List<ChartPointDto> ChartPoints { get; set; } = new List<ChartPointDto>();
    }
}
