using Microsoft.EntityFrameworkCore.Migrations;

namespace TP5_Identity.Migrations
{
    public partial class new1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a50b1f0b-0d54-474c-8dff-a2a5466e29fe", "12985353-da8b-4563-be68-a9696178017b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2e160057-41c2-47f6-b26a-34f70fc95d2a", "9bd270e1-f1dd-49cc-96c3-646637f96749" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e04e0a74-2aec-4755-bf99-836fbbb488eb", "abc47360-807e-412a-a585-d068a621cbfa" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e160057-41c2-47f6-b26a-34f70fc95d2a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a50b1f0b-0d54-474c-8dff-a2a5466e29fe");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e04e0a74-2aec-4755-bf99-836fbbb488eb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12985353-da8b-4563-be68-a9696178017b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9bd270e1-f1dd-49cc-96c3-646637f96749");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abc47360-807e-412a-a585-d068a621cbfa");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "798cf9db-9760-41d0-8fba-330ef65e2d4e", "ba125327-5b5f-4c4e-b6bf-dcb4816ea000", "admin", "ADMIN" },
                    { "f87c082a-35d7-474f-a753-432b91120cde", "529b2e08-81e6-420d-b29a-3eebd229a180", "employe", "EMPLOYE" },
                    { "0848733e-90ae-44f0-b61d-35fdf60f1356", "bb706d89-aa74-4fd4-bd35-f8c07a249c48", "client", "CLIENT" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Aderesse", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Nom", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8815ea04-1c2e-4540-bb9d-8d89c2e2a093", 0, null, "3befc780-86be-4818-8442-680ba9c7ff18", "admin@admin.com", false, false, null, null, "ADMIN@ADMIN.COM", "ADMIN", "AQAAAAEAACcQAAAAENi4DDKWprYSwMXfv9UcUAquh5Jl7zfSh1IFTO1bkiWCHsPHg43Inmro1Ag7J8Oq0Q==", null, false, "5795fdef-db3e-4906-be2d-414aa2fe12e2", false, "admin" },
                    { "77b14d17-d6dc-4418-a71b-a02c072fd958", 0, null, "4e10cdc2-c1d4-4499-8685-434e785ebcf3", "employe@employe.com", false, false, null, null, "EMPLOYE@EMPLOYE.COM", "EMPLOYE", "AQAAAAEAACcQAAAAEPUdnPB8YBP4qv3pkG2GTPQlxR9ry6R7ZlgCDF/4LE6lS548B1HmczuPrlDQBgfReQ==", null, false, "edd830bd-172a-46fd-ac97-5dba2bdf785d", false, "employe" },
                    { "f5112c0b-762c-40f0-aed2-bd8639fe4c6a", 0, null, "9e00f777-42d3-4caa-acae-2f937ad820ca", "client@client.com", false, false, null, null, "CLIENT@CLIENT.COM", "CLIENT", "AQAAAAEAACcQAAAAEPUdnPB8YBP4qv3pkG2GTPQlxR9ry6R7ZlgCDF/4LE6lS548B1HmczuPrlDQBgfReQ==", null, false, "a7f17e88-5757-496d-9d2f-a4fe94ddffd3", false, "client" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "798cf9db-9760-41d0-8fba-330ef65e2d4e", "8815ea04-1c2e-4540-bb9d-8d89c2e2a093" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f87c082a-35d7-474f-a753-432b91120cde", "77b14d17-d6dc-4418-a71b-a02c072fd958" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0848733e-90ae-44f0-b61d-35fdf60f1356", "f5112c0b-762c-40f0-aed2-bd8639fe4c6a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f87c082a-35d7-474f-a753-432b91120cde", "77b14d17-d6dc-4418-a71b-a02c072fd958" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "798cf9db-9760-41d0-8fba-330ef65e2d4e", "8815ea04-1c2e-4540-bb9d-8d89c2e2a093" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0848733e-90ae-44f0-b61d-35fdf60f1356", "f5112c0b-762c-40f0-aed2-bd8639fe4c6a" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0848733e-90ae-44f0-b61d-35fdf60f1356");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "798cf9db-9760-41d0-8fba-330ef65e2d4e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f87c082a-35d7-474f-a753-432b91120cde");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "77b14d17-d6dc-4418-a71b-a02c072fd958");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8815ea04-1c2e-4540-bb9d-8d89c2e2a093");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f5112c0b-762c-40f0-aed2-bd8639fe4c6a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "e04e0a74-2aec-4755-bf99-836fbbb488eb", "03180689-2ac1-4d5e-8cc7-592500728abf", "admin", "ADMIN" },
                    { "a50b1f0b-0d54-474c-8dff-a2a5466e29fe", "02887615-dfd5-4cbb-8671-d2e33e2d205a", "employe", "EMPLOYE" },
                    { "2e160057-41c2-47f6-b26a-34f70fc95d2a", "ada361f1-9c5a-42ff-96e4-0fa02a648f0a", "client", "CLIENT" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Aderesse", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Nom", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "abc47360-807e-412a-a585-d068a621cbfa", 0, null, "985986a1-3c26-405e-9fdd-57f36c1b1a8f", "admin@admin.com", false, false, null, null, "ADMIN@ADMIN.COM", "ADMIN", "AQAAAAEAACcQAAAAEKno1d+WREiL7PitUHIE19IurVc6RiaYXXDbJ/SVWYD97rImca22Q9+kED/3YHjMTw==", null, false, "409a2bd7-f5c3-408d-9767-a0e64b5f7130", false, "admin" },
                    { "12985353-da8b-4563-be68-a9696178017b", 0, null, "8eb53cef-419f-45f1-95d4-88d9bd180f7b", "employe@employe.com", false, false, null, null, "EMPLOYE@EMPLOYE.COM", "EMPLOYE", "AQAAAAEAACcQAAAAENdHFia9rvU8DfXIGm0ENq74qBU/3xwukAKtXW2rgcCxWQEzG8xboH/Vv6Rw+i5Fxg==", null, false, "03f54a77-ea66-41b3-bd26-6f0abdfb4d14", false, "employe" },
                    { "9bd270e1-f1dd-49cc-96c3-646637f96749", 0, null, "48543a39-4c20-455f-a3a3-a475290811a4", "client@client.com", false, false, null, null, "CLIENT@CLIENT.COM", "CLIENT", "AQAAAAEAACcQAAAAENdHFia9rvU8DfXIGm0ENq74qBU/3xwukAKtXW2rgcCxWQEzG8xboH/Vv6Rw+i5Fxg==", null, false, "fef17a76-5f0f-405b-8dbe-096872a878c1", false, "client" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e04e0a74-2aec-4755-bf99-836fbbb488eb", "abc47360-807e-412a-a585-d068a621cbfa" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a50b1f0b-0d54-474c-8dff-a2a5466e29fe", "12985353-da8b-4563-be68-a9696178017b" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2e160057-41c2-47f6-b26a-34f70fc95d2a", "9bd270e1-f1dd-49cc-96c3-646637f96749" });
        }
    }
}
