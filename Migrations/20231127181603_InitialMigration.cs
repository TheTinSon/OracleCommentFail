using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OracleCommentFail.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "HRCMS");

            migrationBuilder.CreateTable(
                name: "CONTACT",
                schema: "HRCMS",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    FIRST_NAME = table.Column<string>(type: "VARCHAR2(4000)", unicode: false, nullable: false, comment: "This is a comment for the FirstName column"),
                    LAST_NAME = table.Column<string>(type: "VARCHAR2(4000)", unicode: false, nullable: false, comment: "This is a comment for the LastName column")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONTACT", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CONTACT",
                schema: "HRCMS");
        }
    }
}
