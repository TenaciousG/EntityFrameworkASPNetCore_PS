using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ASPNETCoreMVC_PS.Migrations
{
    public partial class MoreFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LongDescription",
                table: "Pies",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Pies",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Pies",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "ShortDescription",
                table: "Pies",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LongDescription",
                table: "Pies");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Pies");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Pies");

            migrationBuilder.DropColumn(
                name: "ShortDescription",
                table: "Pies");
        }
    }
}
