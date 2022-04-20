using Microsoft.EntityFrameworkCore.Migrations;

namespace TP5_Identity.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "34cbf924-a518-45b1-b525-a42e1180dc7e", "AQAAAAEAACcQAAAAEARIrXrfqlKDe7oSj0VRjlPM6rwpUdYeuRDeP0DH1rmDqNOO0odOYbnUA9hGjNqicA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32e55894137a1c163a81836e815d4ad0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a09b1aa9-e20e-4e6e-afcd-75cd955bee54", "AQAAAAEAACcQAAAAEMpkDi/LHUBLuidnzbKqHXEYoNL/jYOYOxDTMxKRxVN+Okq5fJXV0lgb1T3l1tedcA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9faf91e5284627fc1e07d6884be54d4098f24fd6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f61282b3-b127-4eae-934d-bdc5b45e6d1d", "AQAAAAEAACcQAAAAEJ8gtBkRLAZoZzDZSr/r3Qs6Z2w4KmIn6OTH5dGVu8uilx8MtOo0KfKkARIlhv82OA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2d15691c418237479115a3618b0009ee8acb1a80",
                column: "ConcurrencyStamp",
                value: "cc599b69-7f5b-4705-8d19-44b8fe0786c6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32e55894137a1c163a81836e815d4ad0",
                column: "ConcurrencyStamp",
                value: "3817f2a5-93aa-4278-9da3-f6c7e2d74f10");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9faf91e5284627fc1e07d6884be54d4098f24fd6",
                column: "ConcurrencyStamp",
                value: "0ca4fe4b-954c-4d62-9179-c596833fecaf");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2d15691c418237479115a3618b0009ee8acb1a80",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b626c9a0-8112-4b0e-98ea-a76ce0fc0ac8", "AQAAAAEAACcQAAAAEDXdUOVcH/IcshLoFBwv1fqF+f5QmCTv/XjG84DRF8MWj+Rj4gPV9UazPrWIxAGj1g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32e55894137a1c163a81836e815d4ad0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "70254ef7-792a-4968-9d8d-871cadfa23cd", "AQAAAAEAACcQAAAAEDR8Ns9EB1RafHjehou+jLbEdScuMd3tYfEEsetE+3wRYzZztyJk+mlVBpti+B/7fg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9faf91e5284627fc1e07d6884be54d4098f24fd6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a7164074-658a-47b5-b09c-dfc9263fce0f", "AQAAAAEAACcQAAAAEEzVcG8VgHXpt+G85waizEzXJ83Rc8z/Y6+C+uDhjuYg+eISRz+UgYRVieDpEde1TA==" });
        }
    }
}
