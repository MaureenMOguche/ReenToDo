using System.ComponentModel.DataAnnotations;

namespace ReenToDo.Models
{
    public class ToDoModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name ="To Do Item")]
        public string ToDoItem { get; set; }
    }
}