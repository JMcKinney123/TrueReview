﻿using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace TrueReview2.Migrations
{
    public partial class BookIdtoReview : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BookId1",
                table: "Reviews",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_BookId1",
                table: "Reviews",
                column: "BookId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Books_BookId1",
                table: "Reviews",
                column: "BookId1",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Books_BookId1",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_BookId1",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "BookId1",
                table: "Reviews");
        }
    }
}
