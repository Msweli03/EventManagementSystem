using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EventManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class SeeddataAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "AvailableSeats", "Date", "Name", "TotalSeats" },
                values: new object[,]
                {
                    { 1, 100, new DateTime(2024, 9, 16, 18, 11, 22, 933, DateTimeKind.Local).AddTicks(6111), "Tech Conference", 100 },
                    { 2, 200, new DateTime(2024, 10, 16, 18, 11, 22, 933, DateTimeKind.Local).AddTicks(6137), "Music Festival", 200 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Registrations_UserId_EventId",
                table: "Registrations",
                columns: new[] { "UserId", "EventId" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Registrations_UserId_EventId",
                table: "Registrations");

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
