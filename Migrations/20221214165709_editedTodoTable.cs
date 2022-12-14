using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReenToDo.Migrations
{
    /// <inheritdoc />
    public partial class editedTodoTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "ToDoList");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "ToDoList",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
