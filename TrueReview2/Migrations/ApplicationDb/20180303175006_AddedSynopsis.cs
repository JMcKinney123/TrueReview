using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace TrueReview2.Migrations
{
    public partial class AddedSynopsis : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Books");

            migrationBuilder.AddColumn<string>(
                name: "Synopsis",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Synopsis",
                table: "Books");

            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "Books",
                nullable: false,
                defaultValue: 0);
        }
    }
}
