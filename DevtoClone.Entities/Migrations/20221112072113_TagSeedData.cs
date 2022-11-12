using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DevtoClone.Entities.Migrations
{
    /// <inheritdoc />
    public partial class TagSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagId", "Name" },
                values: new object[,]
                {
                    { new Guid("5d11cde9-98ee-4844-8845-09714c472740"), "javascript" },
                    { new Guid("84f16bfd-5c77-47d1-8301-3d567b6acbc1"), "css" },
                    { new Guid("9ac89a6d-d440-455b-b303-a6d52b4e12b3"), "html" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "JoinedDate", "Username" },
                values: new object[,]
                {
                    { new Guid("015e75c9-b674-4f52-905c-0fa19c29abe1"), "matt@email.com", new DateTime(2022, 11, 12, 7, 21, 13, 33, DateTimeKind.Utc).AddTicks(6879), "matt" },
                    { new Guid("cddabe69-be5c-43be-ab25-5f3e5818b813"), "anne@email.com", new DateTime(2022, 11, 12, 7, 21, 13, 33, DateTimeKind.Utc).AddTicks(6883), "anne" },
                    { new Guid("ec772a59-3617-4fc6-a971-a45730f87c55"), "patrick@email.com", new DateTime(2022, 11, 12, 7, 21, 13, 33, DateTimeKind.Utc).AddTicks(6882), "patrick" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("5d11cde9-98ee-4844-8845-09714c472740"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("84f16bfd-5c77-47d1-8301-3d567b6acbc1"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("9ac89a6d-d440-455b-b303-a6d52b4e12b3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("015e75c9-b674-4f52-905c-0fa19c29abe1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("cddabe69-be5c-43be-ab25-5f3e5818b813"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("ec772a59-3617-4fc6-a971-a45730f87c55"));

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
    }
}
