using Microsoft.EntityFrameworkCore;
using ReenToDo.Models;

namespace ReenToDo.DataAccess
{
    public class TodoDbContext : DbContext
    {
        public TodoDbContext(DbContextOptions<TodoDbContext> options) : base(options)
        {  
        }

        public DbSet<ToDoModel> ToDoList { get; set; }
    }
}