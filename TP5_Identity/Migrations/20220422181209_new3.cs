using Microsoft.EntityFrameworkCore.Migrations;

namespace TP5_Identity.Migrations
{
    public partial class new3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "faffc1bb-9f58-4562-95e5-0a7b978e47c7", "db2265f2-dbb5-4707-b251-8f2be8c68bbd", "admin", "ADMIN" },
                    { "89765768-4594-4399-b025-6976ac77b06f", "895d0436-c3a3-4a0d-9f6d-c8186442f3b8", "employe", "EMPLOYE" },
                    { "361fb0eb-80cc-4c85-b008-0d9571bb26a9", "dd74e8a8-6f37-49a9-8fc2-0a8e969f477b", "client", "CLIENT" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Aderesse", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Nom", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "04095845-3a94-4cb9-8647-d460baf50ac7", 0, null, "b3a0776e-350f-43c5-a6b9-98f1d2a2c0bd", "admin@admin.com", false, false, null, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEJwEE+wiTVRx73u0Wq5g1D3BE5fadFZF30hbeiTMeHBFFe8iPiyWgyRqeGrI4uGw8Q==", null, false, "5ca3e3fe-2bd0-4ac7-a7a6-11eb888a9d22", false, "admin@admin.com" },
                    { "168b660f-8b1f-4df8-ac6b-2c05f7537f7f", 0, null, "25e1efbb-cdda-41b9-bc48-d3b4f971b019", "employe@employe.com", false, false, null, null, "EMPLOYE@EMPLOYE.COM", "EMPLOYE@EMPLOYE.COM", "AQAAAAEAACcQAAAAEI46gVckGydCZy7O8o/44W+0+Sv+8JZ0dckp6ZvyPbejDsZX3OWsyg5DPN1t1EAuHg==", null, false, "5d67bf40-6af9-4470-b4d7-7f2ee6a9446a", false, "employe@employe.com" },
                    { "d49a4dc6-64d1-422a-9415-120c51687345", 0, null, "40336d04-bf1a-4dae-bca2-a9e881829e10", "client@client.com", false, false, null, null, "CLIENT@CLIENT.COM", "CLIENT@CLIENT.COM", "AQAAAAEAACcQAAAAEI46gVckGydCZy7O8o/44W+0+Sv+8JZ0dckp6ZvyPbejDsZX3OWsyg5DPN1t1EAuHg==", null, false, "d1eaef00-b298-4cd2-96a5-3d907eb40af6", false, "client@client.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "faffc1bb-9f58-4562-95e5-0a7b978e47c7", "04095845-3a94-4cb9-8647-d460baf50ac7" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "89765768-4594-4399-b025-6976ac77b06f", "168b660f-8b1f-4df8-ac6b-2c05f7537f7f" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "361fb0eb-80cc-4c85-b008-0d9571bb26a9", "d49a4dc6-64d1-422a-9415-120c51687345" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "faffc1bb-9f58-4562-95e5-0a7b978e47c7", "04095845-3a94-4cb9-8647-d460baf50ac7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "89765768-4594-4399-b025-6976ac77b06f", "168b660f-8b1f-4df8-ac6b-2c05f7537f7f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "361fb0eb-80cc-4c85-b008-0d9571bb26a9", "d49a4dc6-64d1-422a-9415-120c51687345" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "361fb0eb-80cc-4c85-b008-0d9571bb26a9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "89765768-4594-4399-b025-6976ac77b06f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "faffc1bb-9f58-4562-95e5-0a7b978e47c7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04095845-3a94-4cb9-8647-d460baf50ac7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "168b660f-8b1f-4df8-ac6b-2c05f7537f7f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d49a4dc6-64d1-422a-9415-120c51687345");

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
    }
}
