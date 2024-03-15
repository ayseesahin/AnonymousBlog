using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AnonymousBlog.Data.Migrations
{
    /// <inheritdoc />
    public partial class DALExtensions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("317b3e9e-f657-478b-b869-89dc0deee6d8"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("65da7b83-14c2-41f2-b0ba-5981a65e6082"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("382d8af6-485a-4220-b9a9-95481ee2b1cf"), new Guid("2ce92254-c0d8-4e72-b51b-1cbadfd8c21c"), "Visual Studio Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.\n\n\n\n\n\n\n", "Admin Time", new DateTime(2024, 3, 15, 18, 9, 27, 571, DateTimeKind.Local).AddTicks(2820), null, null, new Guid("f5658d11-19f7-44d8-8393-8262e7d849aa"), false, null, null, "Visual Studio Deneme Makalesi 1", 15 },
                    { new Guid("5faa6f46-e5dd-4bce-8e2c-7d57c8cfe1ae"), new Guid("207d25af-103c-424b-8f7a-42c57345b18e"), "Asp.Net Core Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.\n\n\n\n\n\n\n", "Admin Time", new DateTime(2024, 3, 15, 18, 9, 27, 571, DateTimeKind.Local).AddTicks(2810), null, null, new Guid("3b21b170-ada6-439d-ac46-7f3ca44fc051"), false, null, null, "Asp.Net Core Deneme Makalesi 1", 15 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("207d25af-103c-424b-8f7a-42c57345b18e"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 18, 9, 27, 571, DateTimeKind.Local).AddTicks(3360));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2ce92254-c0d8-4e72-b51b-1cbadfd8c21c"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 18, 9, 27, 571, DateTimeKind.Local).AddTicks(3360));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("3b21b170-ada6-439d-ac46-7f3ca44fc051"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 18, 9, 27, 571, DateTimeKind.Local).AddTicks(3750));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("f5658d11-19f7-44d8-8393-8262e7d849aa"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 18, 9, 27, 571, DateTimeKind.Local).AddTicks(3760));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("382d8af6-485a-4220-b9a9-95481ee2b1cf"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("5faa6f46-e5dd-4bce-8e2c-7d57c8cfe1ae"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("317b3e9e-f657-478b-b869-89dc0deee6d8"), new Guid("207d25af-103c-424b-8f7a-42c57345b18e"), "Asp.Net Core Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.\n\n\n\n\n\n\n", "Admin Time", new DateTime(2024, 3, 15, 17, 0, 5, 347, DateTimeKind.Local).AddTicks(7820), null, null, new Guid("3b21b170-ada6-439d-ac46-7f3ca44fc051"), false, null, null, "Asp.Net Core Deneme Makalesi 1", 15 },
                    { new Guid("65da7b83-14c2-41f2-b0ba-5981a65e6082"), new Guid("2ce92254-c0d8-4e72-b51b-1cbadfd8c21c"), "Visual Studio Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.\n\n\n\n\n\n\n", "Admin Time", new DateTime(2024, 3, 15, 17, 0, 5, 347, DateTimeKind.Local).AddTicks(7840), null, null, new Guid("f5658d11-19f7-44d8-8393-8262e7d849aa"), false, null, null, "Visual Studio Deneme Makalesi 1", 15 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("207d25af-103c-424b-8f7a-42c57345b18e"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 17, 0, 5, 347, DateTimeKind.Local).AddTicks(8330));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2ce92254-c0d8-4e72-b51b-1cbadfd8c21c"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 17, 0, 5, 347, DateTimeKind.Local).AddTicks(8330));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("3b21b170-ada6-439d-ac46-7f3ca44fc051"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 17, 0, 5, 347, DateTimeKind.Local).AddTicks(8710));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("f5658d11-19f7-44d8-8393-8262e7d849aa"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 17, 0, 5, 347, DateTimeKind.Local).AddTicks(8710));
        }
    }
}
