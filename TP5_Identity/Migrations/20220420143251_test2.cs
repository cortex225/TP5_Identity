using Microsoft.EntityFrameworkCore.Migrations;

namespace TP5_Identity.Migrations
{
    public partial class test2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2d15691c418237479115a3618b0009ee8acb1a80",
                column: "ConcurrencyStamp",
                value: "b521c2a4-532a-45a3-9ff1-47277d82bf58");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32e55894137a1c163a81836e815d4ad0",
                column: "ConcurrencyStamp",
                value: "289ba107-177b-419f-a70f-d98b2a5a6c3a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9faf91e5284627fc1e07d6884be54d4098f24fd6",
                column: "ConcurrencyStamp",
                value: "c54197e7-dc4d-44a9-a244-299daf00b85d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2d15691c418237479115a3618b0009ee8acb1a80",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2661af7a-6beb-4578-9a65-37edf484c6d7", null, "eac0318c-9ebb-46a5-a472-f3bb966e0601" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32e55894137a1c163a81836e815d4ad0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "19a807d4-d8c9-4e16-a974-1f7943f56d05", "AQAAAAEAACcQAAAAEE8DLAlcnBzByXNzlsN4/1FFyiGJrTViqxEETfptY5/6ii0x/1qkBdLeFoL7wT2axA==", "318122ac-1af7-4bb4-8507-0a8ddc0e03e9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9faf91e5284627fc1e07d6884be54d4098f24fd6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d49493e9-7dc0-495f-8655-4c51df4869ba", "AQAAAAEAACcQAAAAEJH3F0dqjRoYFghY2n+6JQosyQ9bn6BFyDVaQtLkLA60XczU3FvqqQO1JnyS67+9OQ==", "9768bbff-cde8-416a-9fe1-c20970b6f8d3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2d15691c418237479115a3618b0009ee8acb1a80",
                column: "ConcurrencyStamp",
                value: "a669fc33-8a4f-46ab-8bfb-d4f92e4f2e13");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32e55894137a1c163a81836e815d4ad0",
                column: "ConcurrencyStamp",
                value: "8dfe25a6-5160-42d6-a7a2-ee691246dfa0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9faf91e5284627fc1e07d6884be54d4098f24fd6",
                column: "ConcurrencyStamp",
                value: "4e071baa-edc6-411e-90c9-bd096545af09");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2d15691c418237479115a3618b0009ee8acb1a80",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "34cbf924-a518-45b1-b525-a42e1180dc7e", "AQAAAAEAACcQAAAAEARIrXrfqlKDe7oSj0VRjlPM6rwpUdYeuRDeP0DH1rmDqNOO0odOYbnUA9hGjNqicA==", "" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32e55894137a1c163a81836e815d4ad0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a09b1aa9-e20e-4e6e-afcd-75cd955bee54", "AQAAAAEAACcQAAAAEMpkDi/LHUBLuidnzbKqHXEYoNL/jYOYOxDTMxKRxVN+Okq5fJXV0lgb1T3l1tedcA==", "" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9faf91e5284627fc1e07d6884be54d4098f24fd6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f61282b3-b127-4eae-934d-bdc5b45e6d1d", "AQAAAAEAACcQAAAAEJ8gtBkRLAZoZzDZSr/r3Qs6Z2w4KmIn6OTH5dGVu8uilx8MtOo0KfKkARIlhv82OA==", "" });
        }
    }
}
