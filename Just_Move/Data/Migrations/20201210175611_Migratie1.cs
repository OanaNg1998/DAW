using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Just_Move.Data.Migrations
{
    public partial class Migratie1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AddressId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: true),
                    County = table.Column<string>(nullable: true),
                    Street = table.Column<string>(nullable: true),
                    StreetNumber = table.Column<int>(nullable: false),
                    Block = table.Column<string>(nullable: true),
                    ApartmentNumber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Instructors",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Specialization = table.Column<string>(nullable: true),
                    CareerHistory = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Trainings",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    StartHour = table.Column<int>(nullable: false),
                    EndHour = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gym",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    DailyOpenHour = table.Column<int>(nullable: false),
                    DailyClosingHour = table.Column<int>(nullable: false),
                    WeekendOpenHour = table.Column<int>(nullable: false),
                    WeekendClosingHour = table.Column<int>(nullable: false),
                    AddressId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gym", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Gym_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InstructorTrainings",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    InstructorId = table.Column<string>(nullable: true),
                    TrainingId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstructorTrainings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InstructorTrainings_Instructors_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "Instructors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InstructorTrainings_Trainings_TrainingId",
                        column: x => x.TrainingId,
                        principalTable: "Trainings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GymInstructors",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    InstructorId = table.Column<string>(nullable: true),
                    GymId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GymInstructors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GymInstructors_Gym_GymId",
                        column: x => x.GymId,
                        principalTable: "Gym",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GymInstructors_Instructors_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "Instructors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GymTrainings",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    GymId = table.Column<string>(nullable: true),
                    TrainingId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GymTrainings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GymTrainings_Gym_GymId",
                        column: x => x.GymId,
                        principalTable: "Gym",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GymTrainings_Trainings_TrainingId",
                        column: x => x.TrainingId,
                        principalTable: "Trainings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Subscriptions",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    GymId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subscriptions_Gym_GymId",
                        column: x => x.GymId,
                        principalTable: "Gym",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserSubscriptions",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    SubscriptionId = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSubscriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserSubscriptions_Subscriptions_SubscriptionId",
                        column: x => x.SubscriptionId,
                        principalTable: "Subscriptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserSubscriptions_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_AddressId",
                table: "AspNetUsers",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Gym_AddressId",
                table: "Gym",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_GymInstructors_GymId",
                table: "GymInstructors",
                column: "GymId");

            migrationBuilder.CreateIndex(
                name: "IX_GymInstructors_InstructorId",
                table: "GymInstructors",
                column: "InstructorId");

            migrationBuilder.CreateIndex(
                name: "IX_GymTrainings_GymId",
                table: "GymTrainings",
                column: "GymId");

            migrationBuilder.CreateIndex(
                name: "IX_GymTrainings_TrainingId",
                table: "GymTrainings",
                column: "TrainingId");

            migrationBuilder.CreateIndex(
                name: "IX_InstructorTrainings_InstructorId",
                table: "InstructorTrainings",
                column: "InstructorId");

            migrationBuilder.CreateIndex(
                name: "IX_InstructorTrainings_TrainingId",
                table: "InstructorTrainings",
                column: "TrainingId");

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptions_GymId",
                table: "Subscriptions",
                column: "GymId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSubscriptions_SubscriptionId",
                table: "UserSubscriptions",
                column: "SubscriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSubscriptions_UserId",
                table: "UserSubscriptions",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Address_AddressId",
                table: "AspNetUsers",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Address_AddressId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "GymInstructors");

            migrationBuilder.DropTable(
                name: "GymTrainings");

            migrationBuilder.DropTable(
                name: "InstructorTrainings");

            migrationBuilder.DropTable(
                name: "UserSubscriptions");

            migrationBuilder.DropTable(
                name: "Instructors");

            migrationBuilder.DropTable(
                name: "Trainings");

            migrationBuilder.DropTable(
                name: "Subscriptions");

            migrationBuilder.DropTable(
                name: "Gym");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_AddressId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");
        }
    }
}
