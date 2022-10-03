using System.ComponentModel.DataAnnotations;

namespace TaskManager.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        public string email { get; set; }
        public HashSet<int> TaskIDs { get; set; }
    }
}
