namespace Jeugdhuis.Models
{
    public class Light
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Channel { get; set; }
        public bool IsOff { get; set; }
    }

    public class ApiStatusResponse
    {
        public string Status { get; set; }
    }

    public class ApiResponse
    {
        public List<Group> Groups { get; set; }
    }

    public class Group
    {
        public GroupInfo GroupInfo { get; set; }
        public List<Subject> Subjects { get; set; }
    }

    public class GroupInfo
    {
        public string Name { get; set; }
        public string Id { get; set; }
    }

    public class Subject
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Channel { get; set; }
        public string Type { get; set; }
    }

    public class TokenResponse
    {
        public string Token { get; set; }
    }
}
