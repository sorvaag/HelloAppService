namespace HelloAppService.Models
{
    public class EnvironmentViewModel
    {
        public string? ComputeRegion { get; set; }
        public string? ResourceGroup { get; set; }
        public string? PlanSku { get; set; }
        public string? TimeZone { get; set; }
        public string? ComputeZone { get; set; }
        public string? AspDotNetVersion { get; set; }
        public string? AspNetCoreEnvironment { get; set; }
        public string? MachineName { get; set; }
        public string? OSVersion { get; set; }
    }
}