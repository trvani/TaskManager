using System.ComponentModel.DataAnnotations;

namespace TaskManager.Models
{
    public class Task
    {
        [Key]
        public int id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime DueDate { get; set; }
        public IEnumerable<string> Owners
        {
            get
            {
                ///Here we will query of owners from user table
                return null;
            }
        }

    }
}
