using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Application.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Private",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FatherName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecurityNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PANNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PlaceOfBirth = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaritalStatus = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Private", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Addinfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressLine1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressLine2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PermanentAddressLine1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PermanentAddressLine2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PermanentZipCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PermanentCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PermanentState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PermanentCountry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RelationshipType = table.Column<int>(type: "int", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    personid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addinfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addinfo_Private_personid",
                        column: x => x.personid,
                        principalTable: "Private",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Assesment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    S1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    S2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    S3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    S4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    S5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    W1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    W2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    W3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    W4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    W5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hobby = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Shortgoal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Longgoal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MpyAttendency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    personid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assesment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Assesment_Private_personid",
                        column: x => x.personid,
                        principalTable: "Private",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lastdesignation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Employmentperiod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Employecode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameofRm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartmentofRm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailofRm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TelephoneofRm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameofHr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailofHr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TelephoneofHr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmploymentIsOf = table.Column<int>(type: "int", nullable: false),
                    AlternativeNameofRm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AlternativeDepartmentofRm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AlternativeEmailofRm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AlternativeTelephoneofRm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Agency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remunerations = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    personid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Company_Private_personid",
                        column: x => x.personid,
                        principalTable: "Private",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Declaration",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Signed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    personid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Declaration", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Declaration_Private_personid",
                        column: x => x.personid,
                        principalTable: "Private",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Education",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    XcourseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XIIcourseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UGcourseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PGcourseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OthercourseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XcollegeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XIIcollegeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UGcollegeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PGcollegeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OthercollegeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Xpercent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XIIpercent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UGpercent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PGpercent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Otherpercent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    year1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    year2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    program = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Institute = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    duration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    percentage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    seminarname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    seminarconductby = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    seminarduration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    company = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    client = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    skill = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    teamsize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    personid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Education", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Education_Private_personid",
                        column: x => x.personid,
                        principalTable: "Private",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Passport",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Issuedate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Expirydate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PlaceofIssue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RfName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rfcurrentcompany = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rfemail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rftelephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RsName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rscurrentcompany = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rsemail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rstelephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Visa = table.Column<int>(type: "int", nullable: false),
                    Opentotravel = table.Column<int>(type: "int", nullable: false),
                    personid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passport", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Passport_Private_personid",
                        column: x => x.personid,
                        principalTable: "Private",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addinfo_personid",
                table: "Addinfo",
                column: "personid");

            migrationBuilder.CreateIndex(
                name: "IX_Assesment_personid",
                table: "Assesment",
                column: "personid");

            migrationBuilder.CreateIndex(
                name: "IX_Company_personid",
                table: "Company",
                column: "personid");

            migrationBuilder.CreateIndex(
                name: "IX_Declaration_personid",
                table: "Declaration",
                column: "personid");

            migrationBuilder.CreateIndex(
                name: "IX_Education_personid",
                table: "Education",
                column: "personid");

            migrationBuilder.CreateIndex(
                name: "IX_Passport_personid",
                table: "Passport",
                column: "personid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addinfo");

            migrationBuilder.DropTable(
                name: "Assesment");

            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "Declaration");

            migrationBuilder.DropTable(
                name: "Education");

            migrationBuilder.DropTable(
                name: "Passport");

            migrationBuilder.DropTable(
                name: "Private");
        }
    }
}
