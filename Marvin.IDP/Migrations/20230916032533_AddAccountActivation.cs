using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Marvin.IDP.Migrations
{
    /// <inheritdoc />
    public partial class AddAccountActivation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("290eaf7d-31d8-4764-827e-a955596a5f1f"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("33efa44f-27ed-47e6-9c57-a6f2968f1362"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("63295cf8-7b56-4f5a-8ff2-d5371dad8853"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("68391e33-d240-48a6-87a7-093812c70e7d"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("759c1d1b-579f-4bba-b56f-199e84e3b0c5"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("87e1f3f0-121a-43ea-886e-cc64e9e9f890"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("b2f7bbb6-564b-4ac9-a071-fd38c6c16c41"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("c3fd2cbc-7ef4-423d-a00b-582b2687248f"));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Users",
                type: "TEXT",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecurityCode",
                table: "Users",
                type: "TEXT",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "SecurityCodeExpirationDate",
                table: "Users",
                type: "TEXT",
                maxLength: 200,
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[,]
                {
                    { new Guid("00908748-c8c8-4cca-aa6f-2a8e15765a92"), "178700f6-4d9d-495f-a220-bc2ddb8ac491", "country", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "be" },
                    { new Guid("1cfefef8-a1d8-4950-8e35-554e26d779a7"), "84d8233a-10d4-4f7c-b88d-28cba4838394", "role", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "PayingUser" },
                    { new Guid("6292782b-c78c-4559-806d-21c9df93c55f"), "de18ff80-d86f-4de4-82d7-c430936a406c", "given_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "David" },
                    { new Guid("85e11e40-5b1a-4378-9edd-8d70a5c3f88e"), "9b21f5bb-86b4-433b-90f4-9617045909ab", "family_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Flagg" },
                    { new Guid("b0634476-b6d7-4ed4-aa07-9213c0c68eef"), "576c88da-9152-4ddc-a7b9-52e9f413ad66", "family_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Flagg" },
                    { new Guid("beb75e5b-c41f-40cd-bad9-27653d29b48f"), "84ef85bf-1ba6-4671-a732-f0fdfb632ba5", "role", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "FreeUser" },
                    { new Guid("c2057393-510f-4681-a32a-d246844086a3"), "0334016f-fc33-4b52-9a0e-dd816bbbd003", "country", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "nl" },
                    { new Guid("cde400ba-af9c-4a00-be14-00e51a2b0fe0"), "c97c0b3b-ce79-4f61-bb27-2b398866775f", "given_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Emma" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityCode", "SecurityCodeExpirationDate" },
                values: new object[] { "ddde2bc9-5bb9-46eb-80e4-de2da1bee367", "david@someprovider.com", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityCode", "SecurityCodeExpirationDate" },
                values: new object[] { "6cd84dbc-a517-4230-9488-4a711152d5ed", "emma@someprovider.com", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("00908748-c8c8-4cca-aa6f-2a8e15765a92"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("1cfefef8-a1d8-4950-8e35-554e26d779a7"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("6292782b-c78c-4559-806d-21c9df93c55f"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("85e11e40-5b1a-4378-9edd-8d70a5c3f88e"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("b0634476-b6d7-4ed4-aa07-9213c0c68eef"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("beb75e5b-c41f-40cd-bad9-27653d29b48f"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("c2057393-510f-4681-a32a-d246844086a3"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("cde400ba-af9c-4a00-be14-00e51a2b0fe0"));

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SecurityCode",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SecurityCodeExpirationDate",
                table: "Users");

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[,]
                {
                    { new Guid("290eaf7d-31d8-4764-827e-a955596a5f1f"), "80507da8-d4a8-4187-806f-1039ac56d5c1", "family_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Flagg" },
                    { new Guid("33efa44f-27ed-47e6-9c57-a6f2968f1362"), "17982ffc-c7bf-4784-897d-854059e00223", "role", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "FreeUser" },
                    { new Guid("63295cf8-7b56-4f5a-8ff2-d5371dad8853"), "e5fc390e-ff32-4e1e-a786-dd1b76f86cb3", "family_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Flagg" },
                    { new Guid("68391e33-d240-48a6-87a7-093812c70e7d"), "a316d399-d221-45ad-84f7-8bb9b6e02a74", "country", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "be" },
                    { new Guid("759c1d1b-579f-4bba-b56f-199e84e3b0c5"), "3890204a-aaa8-489a-978d-65a8c9af22cb", "given_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "David" },
                    { new Guid("87e1f3f0-121a-43ea-886e-cc64e9e9f890"), "b19e754c-c6a3-4137-ba04-099530e61066", "given_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Emma" },
                    { new Guid("b2f7bbb6-564b-4ac9-a071-fd38c6c16c41"), "6864ecd7-5e41-4f72-803a-cd9a4b418b3e", "role", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "PayingUser" },
                    { new Guid("c3fd2cbc-7ef4-423d-a00b-582b2687248f"), "43d197d3-e02b-4b9b-9d24-7ad4ebecbcfd", "country", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "nl" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                column: "ConcurrencyStamp",
                value: "544e162b-6b7a-4340-8d86-350877560e9a");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                column: "ConcurrencyStamp",
                value: "be656bb5-1736-4653-ac0a-a7bef4723322");
        }
    }
}
