using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalog_FirstAPI.Migrations
{
    /// <inheritdoc />
    public partial class PopulateCategoriesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into Categories(Name, ImageUrl) Values('Drinks', 'drinks.png')");
            migrationBuilder.Sql("Insert into Categories(Name, ImageUrl) Values('Snacks', 'snacks.png')");
            migrationBuilder.Sql("Insert into Categories(Name, ImageUrl) Values('Desserts', 'desserts.png')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from Categories");
        }
    }
}
