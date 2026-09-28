namespace MonitoringSystem.Model
{
    public class Roles
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; } = string.Empty;
        public ICollection<User> Users { get; set; } = new List<User>();
    }
}
