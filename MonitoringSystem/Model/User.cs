namespace MonitoringSystem.Model
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string SerialNo { get; set; } = string.Empty;
        public DateTime LoginTime { get; set; }
        public int RoleId { get; set; }
        public Roles? Roles { get; set; }
    }
}
