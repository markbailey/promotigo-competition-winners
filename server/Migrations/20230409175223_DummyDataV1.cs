using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace server.Migrations
{
    /// <inheritdoc />
    public partial class DummyDataV1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "Name" },
                values: new object[,]
                {
                    { new Guid("1f888604-02ae-4f98-ba63-3dfc2d729bde"), new DateTime(2023, 4, 9, 18, 52, 22, 932, DateTimeKind.Local).AddTicks(287), new DateTime(2023, 4, 9, 18, 52, 22, 932, DateTimeKind.Local).AddTicks(289), "Coca Cola" },
                    { new Guid("449e957d-15c8-40c8-9f68-bcc4288a7bcc"), new DateTime(2023, 4, 9, 18, 52, 22, 932, DateTimeKind.Local).AddTicks(223), new DateTime(2023, 4, 9, 18, 52, 22, 932, DateTimeKind.Local).AddTicks(274), "Brooks" },
                    { new Guid("524d9afa-3a6e-4640-aaf5-71febc4347cf"), new DateTime(2023, 4, 9, 18, 52, 22, 932, DateTimeKind.Local).AddTicks(291), new DateTime(2023, 4, 9, 18, 52, 22, 932, DateTimeKind.Local).AddTicks(293), "Ben & Jerrys" }
                });

            migrationBuilder.InsertData(
                table: "Competitions",
                columns: new[] { "Id", "ClientId", "ClosingDate", "DateCreated", "DateUpdated", "OpeningDate", "Title", "WinnersDrawn" },
                values: new object[,]
                {
                    { new Guid("62538378-de06-4da0-b361-8f27f5430386"), new Guid("449e957d-15c8-40c8-9f68-bcc4288a7bcc"), new DateTime(2023, 4, 9, 18, 53, 22, 932, DateTimeKind.Local).AddTicks(299), new DateTime(2023, 4, 9, 18, 52, 22, 932, DateTimeKind.Local).AddTicks(304), new DateTime(2023, 4, 9, 18, 52, 22, 932, DateTimeKind.Local).AddTicks(306), new DateTime(2023, 4, 9, 18, 52, 22, 932, DateTimeKind.Local).AddTicks(297), "Product launch instant win", false },
                    { new Guid("d63d6620-ecc4-49f8-9f37-e2e2bddf494d"), new Guid("1f888604-02ae-4f98-ba63-3dfc2d729bde"), new DateTime(2023, 4, 9, 18, 53, 22, 932, DateTimeKind.Local).AddTicks(310), new DateTime(2023, 4, 9, 18, 52, 22, 932, DateTimeKind.Local).AddTicks(311), new DateTime(2023, 4, 9, 18, 52, 22, 932, DateTimeKind.Local).AddTicks(313), new DateTime(2023, 4, 9, 18, 52, 22, 932, DateTimeKind.Local).AddTicks(308), "Sampling with capital xtra", false },
                    { new Guid("f2413a3b-1058-45ff-bd46-07df8bbbbebb"), new Guid("524d9afa-3a6e-4640-aaf5-71febc4347cf"), new DateTime(2023, 4, 9, 18, 53, 22, 932, DateTimeKind.Local).AddTicks(317), new DateTime(2023, 4, 9, 18, 52, 22, 932, DateTimeKind.Local).AddTicks(318), new DateTime(2023, 4, 9, 18, 52, 22, 932, DateTimeKind.Local).AddTicks(319), new DateTime(2023, 4, 9, 18, 52, 22, 932, DateTimeKind.Local).AddTicks(315), "Share the love", false }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("1f888604-02ae-4f98-ba63-3dfc2d729bde"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("449e957d-15c8-40c8-9f68-bcc4288a7bcc"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("524d9afa-3a6e-4640-aaf5-71febc4347cf"));

            migrationBuilder.DeleteData(
                table: "Competitions",
                keyColumn: "Id",
                keyValue: new Guid("62538378-de06-4da0-b361-8f27f5430386"));

            migrationBuilder.DeleteData(
                table: "Competitions",
                keyColumn: "Id",
                keyValue: new Guid("d63d6620-ecc4-49f8-9f37-e2e2bddf494d"));

            migrationBuilder.DeleteData(
                table: "Competitions",
                keyColumn: "Id",
                keyValue: new Guid("f2413a3b-1058-45ff-bd46-07df8bbbbebb"));
        }
    }
}
