using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace mlp.Migrations
{
    public partial class SeedReviewTableAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "Rating", "ReviewDate", "ReviewerName" },
                values: new object[] { 3, "I love to ride my pony!!", 5.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Colleen" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "Rating", "ReviewDate", "ReviewerName" },
                values: new object[] { 4, "I wish I had this pony!!", 5.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tim" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
