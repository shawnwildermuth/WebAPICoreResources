using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyCodeCamp.Data.Migrations
{
    public partial class versioning2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Version",
                table: "Talks");

            migrationBuilder.DropColumn(
                name: "Version",
                table: "Speakers");

            migrationBuilder.DropColumn(
                name: "Version",
                table: "Camps");

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Talks",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Speakers",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Camps",
                rowVersion: true,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Talks");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Speakers");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Camps");

            migrationBuilder.AddColumn<byte[]>(
                name: "Version",
                table: "Talks",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Version",
                table: "Speakers",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Version",
                table: "Camps",
                nullable: true);
        }
    }
}
