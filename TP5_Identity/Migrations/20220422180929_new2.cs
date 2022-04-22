using Microsoft.EntityFrameworkCore.Migrations;

namespace TP5_Identity.Migrations
{
    public partial class new2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "86eb8c46-ab3f-47fc-b6fc-f34cb833810a", "102ae9ac-0da9-43d1-9224-cb7d9559e19e", "admin", "ADMIN" },
                    { "2a739c6b-5d75-4531-acad-77726f290956", "f1d04154-716d-4570-972a-666823bc203d", "employe", "EMPLOYE" },
                    { "cb052e08-9973-4056-83be-0c97536c11a7", "2cb4c343-83fb-4dce-a1eb-2a3a085c9c3a", "client", "CLIENT" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Aderesse", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Nom", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "bd689bd6-f659-48b9-8ff4-c429836204dd", 0, null, "ee14502d-2348-4418-be93-cbe42928167f", "admin@admin.com", false, false, null, null, "ADMIN@ADMIN.COM", "ADMIN", "AQAAAAEAACcQAAAAEP5A0+Sh49GqZJZev/DKqD7yieTvqVejrmGV0mV6PL5KNos4tLJnJL1tHceX7HezGA==", null, false, "36c2dad3-a32f-4e11-8f56-32c549a39ead", false, "admin" },
                    { "205fb5ed-d4d2-40f0-ab94-8487b28f9206", 0, null, "5786e0e3-17a1-4094-9a73-08cd3c60f5f0", "employe@employe.com", false, false, null, null, "EMPLOYE@EMPLOYE.COM", "EMPLOYE", "AQAAAAEAACcQAAAAEO19pvcgLiGWz6WjcAHQSEn4HRgacn3V7MqyWmdC5apZk1mOeD4cX+TKKd/A6hg4YA==", null, false, "00d69269-87f5-491a-b4fa-4bb952596542", false, "employe" },
                    { "429dc12e-7ab1-409c-9f4f-465f72ee9d2b", 0, null, "e26cf738-0bd8-47e4-9c16-dc52472c57e1", "client@client.com", false, false, null, null, "CLIENT@CLIENT.COM", "CLIENT", "AQAAAAEAACcQAAAAEO19pvcgLiGWz6WjcAHQSEn4HRgacn3V7MqyWmdC5apZk1mOeD4cX+TKKd/A6hg4YA==", null, false, "ff3ac481-5895-4156-a219-df22eed37c70", false, "client" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "86eb8c46-ab3f-47fc-b6fc-f34cb833810a", "bd689bd6-f659-48b9-8ff4-c429836204dd" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2a739c6b-5d75-4531-acad-77726f290956", "205fb5ed-d4d2-40f0-ab94-8487b28f9206" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cb052e08-9973-4056-83be-0c97536c11a7", "429dc12e-7ab1-409c-9f4f-465f72ee9d2b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2a739c6b-5d75-4531-acad-77726f290956", "205fb5ed-d4d2-40f0-ab94-8487b28f9206" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cb052e08-9973-4056-83be-0c97536c11a7", "429dc12e-7ab1-409c-9f4f-465f72ee9d2b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "86eb8c46-ab3f-47fc-b6fc-f34cb833810a", "bd689bd6-f659-48b9-8ff4-c429836204dd" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2a739c6b-5d75-4531-acad-77726f290956");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "86eb8c46-ab3f-47fc-b6fc-f34cb833810a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cb052e08-9973-4056-83be-0c97536c11a7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "205fb5ed-d4d2-40f0-ab94-8487b28f9206");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "429dc12e-7ab1-409c-9f4f-465f72ee9d2b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd689bd6-f659-48b9-8ff4-c429836204dd");

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
    }
}
