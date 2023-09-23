using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Work.Data.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WorkFlowId",
                table: "ProgramDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "appFormId",
                table: "ProgramDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "AppForms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    img = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phone = table.Column<int>(type: "int", nullable: false),
                    nationality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    currentResidence = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IDNumber = table.Column<int>(type: "int", nullable: false),
                    birth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppForms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StageTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    question = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    info = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    maxduration = table.Column<int>(type: "int", nullable: false),
                    deadline = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StageTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkFlows",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StageName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    stageTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkFlows", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkFlows_StageTypes_stageTypeId",
                        column: x => x.stageTypeId,
                        principalTable: "StageTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProgramDetails_appFormId",
                table: "ProgramDetails",
                column: "appFormId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgramDetails_WorkFlowId",
                table: "ProgramDetails",
                column: "WorkFlowId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkFlows_stageTypeId",
                table: "WorkFlows",
                column: "stageTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProgramDetails_AppForms_appFormId",
                table: "ProgramDetails",
                column: "appFormId",
                principalTable: "AppForms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProgramDetails_WorkFlows_WorkFlowId",
                table: "ProgramDetails",
                column: "WorkFlowId",
                principalTable: "WorkFlows",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProgramDetails_AppForms_appFormId",
                table: "ProgramDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_ProgramDetails_WorkFlows_WorkFlowId",
                table: "ProgramDetails");

            migrationBuilder.DropTable(
                name: "AppForms");

            migrationBuilder.DropTable(
                name: "WorkFlows");

            migrationBuilder.DropTable(
                name: "StageTypes");

            migrationBuilder.DropIndex(
                name: "IX_ProgramDetails_appFormId",
                table: "ProgramDetails");

            migrationBuilder.DropIndex(
                name: "IX_ProgramDetails_WorkFlowId",
                table: "ProgramDetails");

            migrationBuilder.DropColumn(
                name: "WorkFlowId",
                table: "ProgramDetails");

            migrationBuilder.DropColumn(
                name: "appFormId",
                table: "ProgramDetails");
        }
    }
}
