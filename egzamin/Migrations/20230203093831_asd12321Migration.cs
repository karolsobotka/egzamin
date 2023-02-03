using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace egzamin.Migrations
{
    public partial class asd12321Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    IdTeam = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Deadline = table.Column<DateTime>(type: "datetime2", maxLength: 100, nullable: false),
                    MyProperty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Team_Id", x => x.IdTeam);
                });

            migrationBuilder.CreateTable(
                name: "TaskTypes",
                columns: table => new
                {
                    IdTaskType = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("TaskType_Id", x => x.IdTaskType);
                });

            migrationBuilder.CreateTable(
                name: "TeamMembers",
                columns: table => new
                {
                    IdTeamMember = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("TeamMember_Id", x => x.IdTeamMember);
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    IdTask = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Deadline = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdTeam = table.Column<int>(type: "int", nullable: false),
                    IdTaskType = table.Column<int>(type: "int", nullable: false),
                    IdAssignedTo = table.Column<int>(type: "int", nullable: false),
                    IdCreator = table.Column<int>(type: "int", nullable: false),
                    taskTypeIdTaskType = table.Column<int>(type: "int", nullable: false),
                    projectIdTeam = table.Column<int>(type: "int", nullable: false),
                    teamMemberIdTeamMember = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Task_Id", x => x.IdTask);
                    table.ForeignKey(
                        name: "FK_Tasks_Projects_projectIdTeam",
                        column: x => x.projectIdTeam,
                        principalTable: "Projects",
                        principalColumn: "IdTeam",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tasks_TaskTypes_taskTypeIdTaskType",
                        column: x => x.taskTypeIdTaskType,
                        principalTable: "TaskTypes",
                        principalColumn: "IdTaskType",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tasks_TeamMembers_teamMemberIdTeamMember",
                        column: x => x.teamMemberIdTeamMember,
                        principalTable: "TeamMembers",
                        principalColumn: "IdTeamMember",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_projectIdTeam",
                table: "Tasks",
                column: "projectIdTeam");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_taskTypeIdTaskType",
                table: "Tasks",
                column: "taskTypeIdTaskType");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_teamMemberIdTeamMember",
                table: "Tasks",
                column: "teamMemberIdTeamMember");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "TaskTypes");

            migrationBuilder.DropTable(
                name: "TeamMembers");
        }
    }
}
