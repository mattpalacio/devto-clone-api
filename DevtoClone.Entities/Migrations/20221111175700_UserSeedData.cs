using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DevtoClone.Entities.Migrations
{
    /// <inheritdoc />
    public partial class UserSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "JoinedDate", "Username" },
                values: new object[,]
                {
                    { new Guid("a76f15bb-294f-4cba-a24c-c8a6e6ba3b5b"), "matt@email.com", new DateTime(2022, 11, 11, 17, 57, 0, 668, DateTimeKind.Utc).AddTicks(883), "matt" },
                    { new Guid("ae87fe9c-de6e-47be-a057-daa78b38bd46"), "patrick@email.com", new DateTime(2022, 11, 11, 17, 57, 0, 668, DateTimeKind.Utc).AddTicks(885), "patrick" },
                    { new Guid("e957a825-415e-4e27-8e9f-1c64aec8f3e7"), "anne@email.com", new DateTime(2022, 11, 11, 17, 57, 0, 668, DateTimeKind.Utc).AddTicks(886), "anne" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("a76f15bb-294f-4cba-a24c-c8a6e6ba3b5b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("ae87fe9c-de6e-47be-a057-daa78b38bd46"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("e957a825-415e-4e27-8e9f-1c64aec8f3e7"));
        }
    }
}
