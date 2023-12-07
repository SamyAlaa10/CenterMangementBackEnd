using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CenterMangement.Repository.Data.Migrations
{
    public partial class m1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    DateAction = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Permeations",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    DateAction = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permeations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Payee = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IdAccount = table.Column<long>(type: "bigint", nullable: false),
                    DateAction = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payments_Accounts_IdAccount",
                        column: x => x.IdAccount,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    JopTittle = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdAccount = table.Column<long>(type: "bigint", nullable: false),
                    DateAction = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Accounts_IdAccount",
                        column: x => x.IdAccount,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Centers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IdAccount = table.Column<long>(type: "bigint", nullable: false),
                    IdUser = table.Column<long>(type: "bigint", nullable: false),
                    DateAction = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Centers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Centers_Accounts_IdAccount",
                        column: x => x.IdAccount,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Centers_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Parents",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdUser = table.Column<long>(type: "bigint", nullable: false),
                    IdAccount = table.Column<long>(type: "bigint", nullable: false),
                    DateAction = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Parents_Accounts_IdAccount",
                        column: x => x.IdAccount,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Parents_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RelPermeationsUsers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdUser = table.Column<long>(type: "bigint", nullable: false),
                    IdPermeation = table.Column<long>(type: "bigint", nullable: false),
                    DateAction = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelPermeationsUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RelPermeationsUsers_Permeations_IdPermeation",
                        column: x => x.IdPermeation,
                        principalTable: "Permeations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RelPermeationsUsers_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Teatchers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PercentDefault = table.Column<float>(type: "real", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdUser = table.Column<long>(type: "bigint", nullable: false),
                    IdAccount = table.Column<long>(type: "bigint", nullable: false),
                    DateAction = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teatchers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teatchers_Accounts_IdAccount",
                        column: x => x.IdAccount,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Teatchers_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Grades",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IdCenter = table.Column<long>(type: "bigint", nullable: false),
                    IdUser = table.Column<long>(type: "bigint", nullable: false),
                    IdAccount = table.Column<long>(type: "bigint", nullable: false),
                    AccountNavigationId = table.Column<long>(type: "bigint", nullable: false),
                    DateAction = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Grades_Accounts_AccountNavigationId",
                        column: x => x.AccountNavigationId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Grades_Centers_IdCenter",
                        column: x => x.IdCenter,
                        principalTable: "Centers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Grades_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LectureHells",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IdCenter = table.Column<long>(type: "bigint", nullable: false),
                    IdUser = table.Column<long>(type: "bigint", nullable: false),
                    IdAccount = table.Column<long>(type: "bigint", nullable: false),
                    AccountNavigationId = table.Column<long>(type: "bigint", nullable: false),
                    DateAction = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LectureHells", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LectureHells_Accounts_AccountNavigationId",
                        column: x => x.AccountNavigationId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LectureHells_Centers_IdCenter",
                        column: x => x.IdCenter,
                        principalTable: "Centers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LectureHells_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RelUsersCenters",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdUser = table.Column<long>(type: "bigint", nullable: false),
                    IdCenter = table.Column<long>(type: "bigint", nullable: false),
                    DateAction = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelUsersCenters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RelUsersCenters_Centers_IdCenter",
                        column: x => x.IdCenter,
                        principalTable: "Centers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RelUsersCenters_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PriceDefault = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    filePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdUser = table.Column<long>(type: "bigint", nullable: false),
                    IdGrade = table.Column<long>(type: "bigint", nullable: false),
                    IdAccount = table.Column<long>(type: "bigint", nullable: false),
                    AccountNavigationId = table.Column<long>(type: "bigint", nullable: false),
                    DateAction = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Accounts_AccountNavigationId",
                        column: x => x.AccountNavigationId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Books_Grades_IdGrade",
                        column: x => x.IdGrade,
                        principalTable: "Grades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Books_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    IdParent = table.Column<long>(type: "bigint", nullable: false),
                    IdUser = table.Column<long>(type: "bigint", nullable: false),
                    IdAccount = table.Column<long>(type: "bigint", nullable: false),
                    IdGrade = table.Column<long>(type: "bigint", nullable: false),
                    DateAction = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_Accounts_IdAccount",
                        column: x => x.IdAccount,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Students_Grades_IdGrade",
                        column: x => x.IdGrade,
                        principalTable: "Grades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Students_Parents_IdParent",
                        column: x => x.IdParent,
                        principalTable: "Parents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Students_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PriceDefault = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IdUser = table.Column<long>(type: "bigint", nullable: false),
                    IdGrade = table.Column<long>(type: "bigint", nullable: false),
                    IdAccount = table.Column<long>(type: "bigint", nullable: false),
                    AccountNavigationId = table.Column<long>(type: "bigint", nullable: false),
                    DateAction = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subjects_Accounts_AccountNavigationId",
                        column: x => x.AccountNavigationId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Subjects_Grades_IdGrade",
                        column: x => x.IdGrade,
                        principalTable: "Grades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Subjects_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sessions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    startSession = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndSession = table.Column<DateTime>(type: "datetime2", nullable: true),
                    countStudent = table.Column<int>(type: "int", nullable: false),
                    Nots = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdSubject = table.Column<long>(type: "bigint", nullable: false),
                    PriceSubject = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IdTeatcher = table.Column<long>(type: "bigint", nullable: false),
                    PercentTeatcher = table.Column<float>(type: "real", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    IdUser = table.Column<long>(type: "bigint", nullable: false),
                    IdAccount = table.Column<long>(type: "bigint", nullable: false),
                    IdGrade = table.Column<long>(type: "bigint", nullable: false),
                    IdLectureHell = table.Column<long>(type: "bigint", nullable: false),
                    DateAction = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sessions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sessions_Accounts_IdAccount",
                        column: x => x.IdAccount,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sessions_Grades_IdGrade",
                        column: x => x.IdGrade,
                        principalTable: "Grades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sessions_LectureHells_IdLectureHell",
                        column: x => x.IdLectureHell,
                        principalTable: "LectureHells",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sessions_Subjects_IdSubject",
                        column: x => x.IdSubject,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sessions_Teatchers_IdTeatcher",
                        column: x => x.IdTeatcher,
                        principalTable: "Teatchers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sessions_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Logs",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdSession = table.Column<long>(type: "bigint", nullable: false),
                    IdStudent = table.Column<long>(type: "bigint", nullable: false),
                    PayeeBook = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Payee = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DateBook = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateCome = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GradeValue = table.Column<float>(type: "real", nullable: false),
                    BuyBook = table.Column<bool>(type: "bit", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    IdUser = table.Column<long>(type: "bigint", nullable: true),
                    DateAction = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Logs_Sessions_IdSession",
                        column: x => x.IdSession,
                        principalTable: "Sessions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Logs_Students_IdStudent",
                        column: x => x.IdStudent,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Logs_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RelBooksSessions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdSession = table.Column<long>(type: "bigint", nullable: false),
                    IdBook = table.Column<long>(type: "bigint", nullable: false),
                    IdUser = table.Column<long>(type: "bigint", nullable: false),
                    DateAction = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelBooksSessions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RelBooksSessions_Books_IdBook",
                        column: x => x.IdBook,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RelBooksSessions_Sessions_IdSession",
                        column: x => x.IdSession,
                        principalTable: "Sessions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RelBooksSessions_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RelSessionsVideos",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdSession = table.Column<long>(type: "bigint", nullable: false),
                    IdUser = table.Column<long>(type: "bigint", nullable: false),
                    DateAction = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelSessionsVideos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RelSessionsVideos_Sessions_IdSession",
                        column: x => x.IdSession,
                        principalTable: "Sessions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RelSessionsVideos_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_AccountNavigationId",
                table: "Books",
                column: "AccountNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_IdGrade",
                table: "Books",
                column: "IdGrade");

            migrationBuilder.CreateIndex(
                name: "IX_Books_IdUser",
                table: "Books",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_Centers_IdAccount",
                table: "Centers",
                column: "IdAccount");

            migrationBuilder.CreateIndex(
                name: "IX_Centers_IdUser",
                table: "Centers",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_Grades_AccountNavigationId",
                table: "Grades",
                column: "AccountNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_Grades_IdCenter",
                table: "Grades",
                column: "IdCenter");

            migrationBuilder.CreateIndex(
                name: "IX_Grades_IdUser",
                table: "Grades",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_LectureHells_AccountNavigationId",
                table: "LectureHells",
                column: "AccountNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_LectureHells_IdCenter",
                table: "LectureHells",
                column: "IdCenter");

            migrationBuilder.CreateIndex(
                name: "IX_LectureHells_IdUser",
                table: "LectureHells",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_Logs_IdSession",
                table: "Logs",
                column: "IdSession");

            migrationBuilder.CreateIndex(
                name: "IX_Logs_IdStudent",
                table: "Logs",
                column: "IdStudent");

            migrationBuilder.CreateIndex(
                name: "IX_Logs_IdUser",
                table: "Logs",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_Parents_IdAccount",
                table: "Parents",
                column: "IdAccount");

            migrationBuilder.CreateIndex(
                name: "IX_Parents_IdUser",
                table: "Parents",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_IdAccount",
                table: "Payments",
                column: "IdAccount");

            migrationBuilder.CreateIndex(
                name: "IX_RelBooksSessions_IdBook",
                table: "RelBooksSessions",
                column: "IdBook");

            migrationBuilder.CreateIndex(
                name: "IX_RelBooksSessions_IdSession",
                table: "RelBooksSessions",
                column: "IdSession");

            migrationBuilder.CreateIndex(
                name: "IX_RelBooksSessions_IdUser",
                table: "RelBooksSessions",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_RelPermeationsUsers_IdPermeation",
                table: "RelPermeationsUsers",
                column: "IdPermeation");

            migrationBuilder.CreateIndex(
                name: "IX_RelPermeationsUsers_IdUser",
                table: "RelPermeationsUsers",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_RelSessionsVideos_IdSession",
                table: "RelSessionsVideos",
                column: "IdSession");

            migrationBuilder.CreateIndex(
                name: "IX_RelSessionsVideos_IdUser",
                table: "RelSessionsVideos",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_RelUsersCenters_IdCenter",
                table: "RelUsersCenters",
                column: "IdCenter");

            migrationBuilder.CreateIndex(
                name: "IX_RelUsersCenters_IdUser",
                table: "RelUsersCenters",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_IdAccount",
                table: "Sessions",
                column: "IdAccount");

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_IdGrade",
                table: "Sessions",
                column: "IdGrade");

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_IdLectureHell",
                table: "Sessions",
                column: "IdLectureHell");

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_IdSubject",
                table: "Sessions",
                column: "IdSubject");

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_IdTeatcher",
                table: "Sessions",
                column: "IdTeatcher");

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_IdUser",
                table: "Sessions",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_Students_IdAccount",
                table: "Students",
                column: "IdAccount");

            migrationBuilder.CreateIndex(
                name: "IX_Students_IdGrade",
                table: "Students",
                column: "IdGrade");

            migrationBuilder.CreateIndex(
                name: "IX_Students_IdParent",
                table: "Students",
                column: "IdParent");

            migrationBuilder.CreateIndex(
                name: "IX_Students_IdUser",
                table: "Students",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_AccountNavigationId",
                table: "Subjects",
                column: "AccountNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_IdGrade",
                table: "Subjects",
                column: "IdGrade");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_IdUser",
                table: "Subjects",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_Teatchers_IdAccount",
                table: "Teatchers",
                column: "IdAccount");

            migrationBuilder.CreateIndex(
                name: "IX_Teatchers_IdUser",
                table: "Teatchers",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_Users_IdAccount",
                table: "Users",
                column: "IdAccount");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Logs");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "RelBooksSessions");

            migrationBuilder.DropTable(
                name: "RelPermeationsUsers");

            migrationBuilder.DropTable(
                name: "RelSessionsVideos");

            migrationBuilder.DropTable(
                name: "RelUsersCenters");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Permeations");

            migrationBuilder.DropTable(
                name: "Sessions");

            migrationBuilder.DropTable(
                name: "Parents");

            migrationBuilder.DropTable(
                name: "LectureHells");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "Teatchers");

            migrationBuilder.DropTable(
                name: "Grades");

            migrationBuilder.DropTable(
                name: "Centers");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Accounts");
        }
    }
}
