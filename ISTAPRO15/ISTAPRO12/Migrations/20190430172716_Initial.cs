using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ISTAPRO12.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    TicketID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SubmitDate = table.Column<string>(nullable: true),
                    OpenDate = table.Column<string>(nullable: true),
                    CloseDate = table.Column<string>(nullable: true),
                    EmpID = table.Column<int>(nullable: false),
                    CustID = table.Column<int>(nullable: false),
                    CustName = table.Column<string>(nullable: false),
                    CustEmail = table.Column<string>(nullable: false),
                    Platform = table.Column<string>(nullable: false),
                    Summary = table.Column<string>(nullable: false),
                    Issue = table.Column<string>(nullable: false),
                    Resolution = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.TicketID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tickets");
        }
    }
}
