using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SNCFDatabase.Migrations
{
    public partial class AddAllForeignKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CityID",
                table: "Opinion",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Opinion_CityID",
                table: "Opinion",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_Mark_CommentID",
                table: "Mark",
                column: "CommentID");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_ForumID",
                table: "Comment",
                column: "ForumID");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Forum_ForumID",
                table: "Comment",
                column: "ForumID",
                principalTable: "Forum",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Mark_Comment_CommentID",
                table: "Mark",
                column: "CommentID",
                principalTable: "Comment",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Opinion_City_CityID",
                table: "Opinion",
                column: "CityID",
                principalTable: "City",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Forum_ForumID",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_Mark_Comment_CommentID",
                table: "Mark");

            migrationBuilder.DropForeignKey(
                name: "FK_Opinion_City_CityID",
                table: "Opinion");

            migrationBuilder.DropIndex(
                name: "IX_Opinion_CityID",
                table: "Opinion");

            migrationBuilder.DropIndex(
                name: "IX_Mark_CommentID",
                table: "Mark");

            migrationBuilder.DropIndex(
                name: "IX_Comment_ForumID",
                table: "Comment");

            migrationBuilder.AlterColumn<string>(
                name: "CityID",
                table: "Opinion",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
