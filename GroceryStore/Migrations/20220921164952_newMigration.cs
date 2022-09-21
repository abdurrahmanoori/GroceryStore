using Microsoft.EntityFrameworkCore.Migrations;

namespace GroceryStore.Migrations
{
    public partial class newMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DeleteData(
            //    table: "Category",
            //    keyColumn: "Id",
            //    keyValue: 1);

            //migrationBuilder.DeleteData(
            //    table: "Category",
            //    keyColumn: "Id",
            //    keyValue: 10);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        //    migrationBuilder.InsertData(
        //        table: "Category",
        //        columns: new[] { "Id", "Name" },
        //        values: new object[] { 10, "Eeating" });

        //    migrationBuilder.InsertData(
        //        table: "Category",
        //        columns: new[] { "Id", "Name" },
        //        values: new object[] { 1, "Washing" });
        }
    }
}
