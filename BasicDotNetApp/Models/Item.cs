using System.ComponentModel.DataAnnotations;

namespace BasicDotNetApp.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        public string Borrower { get; set; }

    }
}
