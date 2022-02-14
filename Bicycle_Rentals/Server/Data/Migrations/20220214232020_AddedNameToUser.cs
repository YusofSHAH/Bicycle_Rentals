using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bicycle_Rentals.Server.Data.Migrations
{
    public partial class AddedNameToUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "BicycleModels");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "BicycleModels");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "BicycleModels");

            migrationBuilder.DropColumn(
                name: "TaskName",
                table: "BicycleModels");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "BicycleModels");

            migrationBuilder.DropColumn(
                name: "bicycleModelId",
                table: "BicycleModels");

            migrationBuilder.DropColumn(
                name: "isCompleted",
                table: "BicycleModels");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "BicycleModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "BicycleModels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "BicycleModels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "TaskName",
                table: "BicycleModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "BicycleModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "bicycleModelId",
                table: "BicycleModels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "isCompleted",
                table: "BicycleModels",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
