using _20_Day.Models;

namespace _20_Day.Utils
{
    public class UserPage
    {
        public int TotaalCount { get; set; }
        public int TotalPage { get; set; }
        public List<User> Users { get; set; } = new List<User>();
    }
}