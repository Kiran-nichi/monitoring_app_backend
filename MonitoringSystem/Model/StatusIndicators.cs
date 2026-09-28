namespace MonitoringSystem.Model
{
    public class StatusIndicators
    {
        public bool Emergency_Status { get; set; }
        public bool ToolLife_Status { get; set; }
        public bool AirPressure_Status { get; set; }
        public bool LubricationLevel_Status { get; set; }
        public bool CoolantLevel_Status { get; set; }
        public bool ProgramLockKey_Status { get; set; }
        public bool ToolChangeOperation_Status { get; set; }
        public bool SetupKey_Status { get; set; }
        public bool SkipSignal_Status { get; set; }
        public bool EcoMode_Status { get; set; }
        public bool ProgramRun_Status { get; set; }
        public bool CoolantSystem_Status { get; set; }
        public bool Caution_Status { get; set; }
        public bool WarmUp_Status { get; set; }
    }
}