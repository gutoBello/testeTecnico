using Microsoft.EntityFrameworkCore.Migrations;

namespace TesteTecnico.Migrations
{
    public partial class SeedCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [dbo].[Customers] VALUES ('GUSTAVO BELLO', 'GUTO86@GMAIL.COM')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Customers] VALUES ('JOHN SILVA', 'JOHN@GMAIL.COM')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [DBO].[ORDERS]");
            migrationBuilder.Sql("DELETE FROM [DBO].[CUSTOMERS]");
        }
    }
}
