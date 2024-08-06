using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace com.dell.emulator.powerstore.Migrations
{
    /// <inheritdoc />
    public partial class CreateAlerts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alerts",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    EventCode = table.Column<string>(type: "TEXT", nullable: true),
                    Severity = table.Column<int>(type: "INTEGER", nullable: true),
                    ResourceType = table.Column<int>(type: "INTEGER", nullable: true),
                    ResourceId = table.Column<string>(type: "TEXT", nullable: true),
                    ResourceName = table.Column<string>(type: "TEXT", nullable: true),
                    DescriptionL10n = table.Column<string>(type: "TEXT", nullable: true),
                    GeneratedTimestamp = table.Column<DateTime>(type: "TEXT", nullable: true),
                    State = table.Column<int>(type: "INTEGER", nullable: true),
                    IsAcknowledged = table.Column<bool>(type: "INTEGER", nullable: true),
                    RaisedTimestamp = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ClearedTimestamp = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CalledHomeTimestamp = table.Column<DateTime>(type: "TEXT", nullable: true),
                    EmailSentTimestamp = table.Column<DateTime>(type: "TEXT", nullable: true),
                    SnmpSentTimestamp = table.Column<DateTime>(type: "TEXT", nullable: true),
                    AcknowledgedTimestamp = table.Column<DateTime>(type: "TEXT", nullable: true),
                    SeverityL10n = table.Column<string>(type: "TEXT", nullable: true),
                    ResourceTypeL10n = table.Column<string>(type: "TEXT", nullable: true),
                    StateL10n = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alerts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EventInstance",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    EventCode = table.Column<string>(type: "TEXT", nullable: true),
                    Severity = table.Column<int>(type: "INTEGER", nullable: true),
                    ResourceType = table.Column<int>(type: "INTEGER", nullable: true),
                    ResourceId = table.Column<string>(type: "TEXT", nullable: true),
                    ResourceName = table.Column<string>(type: "TEXT", nullable: true),
                    GeneratedTimestamp = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DescriptionL10n = table.Column<string>(type: "TEXT", nullable: true),
                    SystemImpactL10n = table.Column<string>(type: "TEXT", nullable: true),
                    RepairFlowL10n = table.Column<string>(type: "TEXT", nullable: true),
                    SeverityL10n = table.Column<string>(type: "TEXT", nullable: true),
                    ResourceTypeL10n = table.Column<string>(type: "TEXT", nullable: true),
                    AlertInstanceId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventInstance", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EventInstance_Alerts_AlertInstanceId",
                        column: x => x.AlertInstanceId,
                        principalTable: "Alerts",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Alerts",
                columns: new[] { "Id", "AcknowledgedTimestamp", "CalledHomeTimestamp", "ClearedTimestamp", "DescriptionL10n", "EmailSentTimestamp", "EventCode", "GeneratedTimestamp", "IsAcknowledged", "RaisedTimestamp", "ResourceId", "ResourceName", "ResourceType", "ResourceTypeL10n", "Severity", "SeverityL10n", "SnmpSentTimestamp", "State", "StateL10n" },
                values: new object[,]
                {
                    { "001", null, null, null, "Alert01", null, null, new DateTime(2024, 8, 6, 11, 36, 48, 919, DateTimeKind.Local).AddTicks(1042), null, null, null, null, null, null, 1, null, null, null, null },
                    { "002", null, null, null, "Alert02", null, null, new DateTime(2024, 8, 6, 11, 36, 48, 919, DateTimeKind.Local).AddTicks(1145), null, null, null, null, null, null, 2, null, null, null, null },
                    { "003", null, null, null, "Alert03", null, null, new DateTime(2024, 8, 6, 11, 36, 48, 919, DateTimeKind.Local).AddTicks(1160), null, null, null, null, null, null, 3, null, null, null, null },
                    { "004", null, null, null, "Alert04", null, null, new DateTime(2024, 8, 6, 11, 36, 48, 919, DateTimeKind.Local).AddTicks(1171), null, null, null, null, null, null, 4, null, null, null, null },
                    { "005", null, null, null, "Alert05", null, null, new DateTime(2024, 8, 6, 11, 36, 48, 919, DateTimeKind.Local).AddTicks(1183), null, null, null, null, null, null, 5, null, null, null, null },
                    { "006", null, null, null, "Alert06", null, null, new DateTime(2024, 8, 6, 11, 36, 48, 919, DateTimeKind.Local).AddTicks(1197), null, null, null, null, null, null, 2, null, null, null, null },
                    { "007", null, null, null, "Alert07", null, null, new DateTime(2024, 8, 6, 11, 36, 48, 919, DateTimeKind.Local).AddTicks(1209), null, null, null, null, null, null, 2, null, null, null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_EventInstance_AlertInstanceId",
                table: "EventInstance",
                column: "AlertInstanceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventInstance");

            migrationBuilder.DropTable(
                name: "Alerts");
        }
    }
}
