using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SignlRChat.Migrations
{
    /// <inheritdoc />
    public partial class third : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddColumn<string>(
              name: "ProfileImage",
              table: "AspNetUsers",
              type: "nvarchar(max)",
              maxLength: 100000,
              nullable: false,
              defaultValue: "");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {






        }
    }
}
