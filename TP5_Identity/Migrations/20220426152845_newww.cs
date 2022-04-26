using Microsoft.EntityFrameworkCore.Migrations;

namespace TP5_Identity.Migrations
{
    public partial class newww : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7d61c783-3b69-495d-8477-97d7d0dafcf8", "02878026-e170-4acd-9a2d-a743e28129f3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "02a2766a-54ce-4746-9eeb-93ace591213d", "6e64d31e-db01-40fc-95c5-a789ee48adad" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9253c653-c9b9-4041-94c2-a58d1a0eab34", "e2f3399d-6892-4ccb-b4d4-9d0152a6b9c2" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "02a2766a-54ce-4746-9eeb-93ace591213d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7d61c783-3b69-495d-8477-97d7d0dafcf8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9253c653-c9b9-4041-94c2-a58d1a0eab34");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02878026-e170-4acd-9a2d-a743e28129f3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6e64d31e-db01-40fc-95c5-a789ee48adad");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e2f3399d-6892-4ccb-b4d4-9d0152a6b9c2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1943eb8d-c2b6-4f5b-810d-b8c8c5542898", "12d8c0a9-db38-4fb4-9c91-5a1db7616783", "admin", "ADMIN" },
                    { "eba27f7c-895d-4cbe-8368-b687e23e6fae", "95ae62da-8bfc-4173-ab1f-74347f712995", "employe", "EMPLOYE" },
                    { "725f63a0-3f62-4dd2-9029-9877f8f7a56d", "a9ace8d0-0ec6-4038-92d5-2f31a121f54f", "client", "CLIENT" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Aderesse", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Nom", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "a7a21d52-26ad-49ca-8654-7c00d4a59422", 0, null, "4357b40f-4057-4b76-9503-9d3f3bd3a217", "admin@admin.com", false, false, null, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEP5A0+Sh49GqZJZev/DKqD7yieTvqVejrmGV0mV6PL5KNos4tLJnJL1tHceX7HezGA==", null, false, "1cf2af58-884e-4a16-aaa4-6c570daa63c1", false, "admin@admin.com" },
                    { "806347c7-8864-4255-998d-4b93d39e3478", 0, null, "1906143b-1521-48d3-8ec9-3acbe762d4af", "employe@employe.com", false, false, null, null, "EMPLOYE@EMPLOYE.COM", "EMPLOYE@EMPLOYE.COM", "AQAAAAEAACcQAAAAEP5A0+Sh49GqZJZev/DKqD7yieTvqVejrmGV0mV6PL5KNos4tLJnJL1tHceX7HezGA==", null, false, "5ed5fc58-6a3c-47b6-a511-32e22ea057b5", false, "employe@employe.com" },
                    { "1da92294-2a12-4474-8d32-dabc1a712e48", 0, null, "ed098bd1-5cbd-41e3-8778-be3bc5df8c80", "client@client.com", false, false, null, null, "CLIENT@CLIENT.COM", "CLIENT@CLIENT.COM", "AQAAAAEAACcQAAAAEP5A0+Sh49GqZJZev/DKqD7yieTvqVejrmGV0mV6PL5KNos4tLJnJL1tHceX7HezGA==", null, false, "34c4895e-9eaa-4cca-9353-13b02efe58ee", false, "client@client.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1943eb8d-c2b6-4f5b-810d-b8c8c5542898", "a7a21d52-26ad-49ca-8654-7c00d4a59422" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "eba27f7c-895d-4cbe-8368-b687e23e6fae", "806347c7-8864-4255-998d-4b93d39e3478" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "725f63a0-3f62-4dd2-9029-9877f8f7a56d", "1da92294-2a12-4474-8d32-dabc1a712e48" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "725f63a0-3f62-4dd2-9029-9877f8f7a56d", "1da92294-2a12-4474-8d32-dabc1a712e48" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "eba27f7c-895d-4cbe-8368-b687e23e6fae", "806347c7-8864-4255-998d-4b93d39e3478" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1943eb8d-c2b6-4f5b-810d-b8c8c5542898", "a7a21d52-26ad-49ca-8654-7c00d4a59422" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1943eb8d-c2b6-4f5b-810d-b8c8c5542898");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "725f63a0-3f62-4dd2-9029-9877f8f7a56d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eba27f7c-895d-4cbe-8368-b687e23e6fae");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1da92294-2a12-4474-8d32-dabc1a712e48");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "806347c7-8864-4255-998d-4b93d39e3478");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a7a21d52-26ad-49ca-8654-7c00d4a59422");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9253c653-c9b9-4041-94c2-a58d1a0eab34", "32b6cbf0-725c-40bd-b8ae-ac0e55f590be", "admin", "ADMIN" },
                    { "7d61c783-3b69-495d-8477-97d7d0dafcf8", "cfa01dd6-6725-4e25-99be-c49a4ca97f0d", "employe", "EMPLOYE" },
                    { "02a2766a-54ce-4746-9eeb-93ace591213d", "d46f8af1-84e1-4655-bb9e-efa787858454", "client", "CLIENT" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Aderesse", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Nom", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "e2f3399d-6892-4ccb-b4d4-9d0152a6b9c2", 0, null, "45586041-1c1d-4032-a18a-acb795a32129", "admin@admin.com", false, false, null, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEP5A0+Sh49GqZJZev/DKqD7yieTvqVejrmGV0mV6PL5KNos4tLJnJL1tHceX7HezGA==", null, false, "8df526fe-f417-4cc2-8399-24a70e9654a8", false, "admin@admin.com" },
                    { "02878026-e170-4acd-9a2d-a743e28129f3", 0, null, "aaa5426c-18b6-401e-95ca-5d3342cf133f", "employe@employe.com", false, false, null, null, "EMPLOYE@EMPLOYE.COM", "EMPLOYE@EMPLOYE.COM", "AQAAAAEAACcQAAAAEP5A0+Sh49GqZJZev/DKqD7yieTvqVejrmGV0mV6PL5KNos4tLJnJL1tHceX7HezGA==", null, false, "15990d0f-c19c-4c98-8a69-7a3a7b45b382", false, "employe@employe.com" },
                    { "6e64d31e-db01-40fc-95c5-a789ee48adad", 0, null, "e79785e7-00d4-43bb-b313-2fcdc1775b0c", "client@client.com", false, false, null, null, "CLIENT@CLIENT.COM", "CLIENT@CLIENT.COM", "AQAAAAEAACcQAAAAEP5A0+Sh49GqZJZev/DKqD7yieTvqVejrmGV0mV6PL5KNos4tLJnJL1tHceX7HezGA==", null, false, "06d1af64-0d1b-4f4f-bd52-e2b8181b3b72", false, "client@client.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "9253c653-c9b9-4041-94c2-a58d1a0eab34", "e2f3399d-6892-4ccb-b4d4-9d0152a6b9c2" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "7d61c783-3b69-495d-8477-97d7d0dafcf8", "02878026-e170-4acd-9a2d-a743e28129f3" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "02a2766a-54ce-4746-9eeb-93ace591213d", "6e64d31e-db01-40fc-95c5-a789ee48adad" });
        }
    }
}
