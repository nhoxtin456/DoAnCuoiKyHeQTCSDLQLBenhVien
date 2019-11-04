using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleApp1.Migrations
{
    public partial class spGetAccount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sp = @"CREATE PROCEDURE [dbo].[GetAccount]
                        @UserID NVARCHAR(50)
                     AS
                     BEGIN
                        SET NOCOUNT ON;
                        SELECT * FROM Account WHERE UserID LIKE @UserID +'%'
                    END";
            migrationBuilder.Sql(sp);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
