using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalog_FirstAPI.Migrations
{
    /// <inheritdoc />
    public partial class PopulateProductsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into Products(Name, Description, Price, ImageUrl, Stock, RegisterDate, CategoryId) " +
                "Values('Diet Coke', 'Coke soda - 350mL', 1.55, 'dietcoke.png',50,now(),1)");
            migrationBuilder.Sql("Insert into Products(Name, Description, Price, ImageUrl, Stock, RegisterDate, CategoryId) " +
                "Values('Ham Sandwich', 'Tasty snack with ham and cheese', 2.75, 'hamsandwich.png', 30,now(),2)");
            migrationBuilder.Sql("Insert into Products(Name, Description, Price, ImageUrl, Stock, RegisterDate, CategoryId) " +
                "Values('Chocolate Cake', 'Delicious dessert with rich chocolate flavor', 3.50, 'chocolatecake.png', 20,now(),3)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from Products");
        }
    }
}
