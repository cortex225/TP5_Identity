using Microsoft.EntityFrameworkCore.Migrations;

namespace TP5_Identity.Migrations
{
    public partial class new5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "237a470c-4786-4b80-8b34-a10ae2285970", "8ca181d8-a965-44c6-acd2-bcce580d6337", "admin", "ADMIN" },
                    { "94a6801e-8c29-4ae3-ae85-19ef6903fc1d", "32605185-44bd-4d42-89de-a84310291445", "employe", "EMPLOYE" },
                    { "48e1d93f-62de-4e8d-bd1c-45964c864112", "27ce00e2-95e3-4240-9f7e-5c3e1dd2e4a9", "client", "CLIENT" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Aderesse", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Nom", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "ac9cc4b1-46f6-404a-ac6a-59bd01b9744e", 0, null, "7bd2c28c-86c6-4e7d-b8ce-52a5927d66e2", "admin@admin.com", false, false, null, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEP5A0+Sh49GqZJZev/DKqD7yieTvqVejrmGV0mV6PL5KNos4tLJnJL1tHceX7HezGA==", null, false, "67e4066b-4de3-4f0c-8668-ef548a6595c4", false, "admin@admin.com" },
                    { "9440f7d0-fa0a-443d-86df-eaff757e28d5", 0, null, "f76369a4-995c-46dd-af8f-37041df47c0c", "employe@employe.com", false, false, null, null, "EMPLOYE@EMPLOYE.COM", "EMPLOYE@EMPLOYE.COM", "AQAAAAEAACcQAAAAEP5A0+Sh49GqZJZev/DKqD7yieTvqVejrmGV0mV6PL5KNos4tLJnJL1tHceX7HezGA==", null, false, "d5e1c12f-ad98-45f7-8346-263f327c3522", false, "employe@employe.com" },
                    { "a5368b40-9a59-4e4c-a696-869ec956f042", 0, null, "a96a0569-f71f-48fd-b5a2-99bc15f86876", "client@client.com", false, false, null, null, "CLIENT@CLIENT.COM", "CLIENT@CLIENT.COM", "AQAAAAEAACcQAAAAEP5A0+Sh49GqZJZev/DKqD7yieTvqVejrmGV0mV6PL5KNos4tLJnJL1tHceX7HezGA==", null, false, "6b955392-7407-482b-a181-75333feb4cce", false, "client@client.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "237a470c-4786-4b80-8b34-a10ae2285970", "ac9cc4b1-46f6-404a-ac6a-59bd01b9744e" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "94a6801e-8c29-4ae3-ae85-19ef6903fc1d", "9440f7d0-fa0a-443d-86df-eaff757e28d5" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "48e1d93f-62de-4e8d-bd1c-45964c864112", "a5368b40-9a59-4e4c-a696-869ec956f042" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "94a6801e-8c29-4ae3-ae85-19ef6903fc1d", "9440f7d0-fa0a-443d-86df-eaff757e28d5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "48e1d93f-62de-4e8d-bd1c-45964c864112", "a5368b40-9a59-4e4c-a696-869ec956f042" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "237a470c-4786-4b80-8b34-a10ae2285970", "ac9cc4b1-46f6-404a-ac6a-59bd01b9744e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "237a470c-4786-4b80-8b34-a10ae2285970");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "48e1d93f-62de-4e8d-bd1c-45964c864112");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "94a6801e-8c29-4ae3-ae85-19ef6903fc1d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9440f7d0-fa0a-443d-86df-eaff757e28d5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a5368b40-9a59-4e4c-a696-869ec956f042");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ac9cc4b1-46f6-404a-ac6a-59bd01b9744e");

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
    }
}
