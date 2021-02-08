using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Audit.DAL.Migrations
{
    public partial class AddtabletblAnswersAudit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblQuestionsAudit",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Text = table.Column<string>(maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblQuestionsAudit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblUsersAudit",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Surname = table.Column<string>(maxLength: 150, nullable: false),
                    Login = table.Column<string>(maxLength: 100, nullable: false),
                    Password = table.Column<string>(maxLength: 120, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblUsersAudit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblAnswersAudit",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Text = table.Column<string>(maxLength: 500, nullable: false),
                    IsTrue = table.Column<bool>(nullable: false),
                    QuestionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAnswersAudit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblAnswersAudit_tblQuestionsAudit_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "tblQuestionsAudit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblSessionsAudit",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(nullable: false),
                    Begin = table.Column<DateTime>(nullable: false),
                    End = table.Column<DateTime>(nullable: false),
                    Marks = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblSessionsAudit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblSessionsAudit_tblUsersAudit_UserId",
                        column: x => x.UserId,
                        principalTable: "tblUsersAudit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblResultsAudit",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SessionId = table.Column<int>(nullable: false),
                    AnswerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblResultsAudit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblResultsAudit_tblAnswersAudit_AnswerId",
                        column: x => x.AnswerId,
                        principalTable: "tblAnswersAudit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblResultsAudit_tblSessionsAudit_SessionId",
                        column: x => x.SessionId,
                        principalTable: "tblSessionsAudit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblAnswersAudit_QuestionId",
                table: "tblAnswersAudit",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_tblResultsAudit_AnswerId",
                table: "tblResultsAudit",
                column: "AnswerId");

            migrationBuilder.CreateIndex(
                name: "IX_tblResultsAudit_SessionId",
                table: "tblResultsAudit",
                column: "SessionId");

            migrationBuilder.CreateIndex(
                name: "IX_tblSessionsAudit_UserId",
                table: "tblSessionsAudit",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblResultsAudit");

            migrationBuilder.DropTable(
                name: "tblAnswersAudit");

            migrationBuilder.DropTable(
                name: "tblSessionsAudit");

            migrationBuilder.DropTable(
                name: "tblQuestionsAudit");

            migrationBuilder.DropTable(
                name: "tblUsersAudit");
        }
    }
}
