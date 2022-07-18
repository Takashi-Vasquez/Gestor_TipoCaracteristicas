using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gestor_TipoCaracteristicas.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bank",
                columns: table => new
                {
                    BankId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Status = table.Column<byte>(type: "tinyint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(36)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedUser = table.Column<string>(type: "nvarchar(36)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bank", x => x.BankId);
                });

            migrationBuilder.CreateTable(
                name: "ClaseActivo",
                columns: table => new
                {
                    ClaseActivoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Status = table.Column<byte>(type: "tinyint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(36)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedUser = table.Column<string>(type: "nvarchar(36)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClaseActivo", x => x.ClaseActivoId);
                });

            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    Status = table.Column<byte>(type: "tinyint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(36)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedUser = table.Column<string>(type: "nvarchar(36)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.CompanyId);
                });

            migrationBuilder.CreateTable(
                name: "Currency",
                columns: table => new
                {
                    CurrencyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Status = table.Column<byte>(type: "tinyint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(36)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedUser = table.Column<string>(type: "nvarchar(36)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currency", x => x.CurrencyId);
                });

            migrationBuilder.CreateTable(
                name: "Tenant",
                columns: table => new
                {
                    TenantId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShortName = table.Column<string>(type: "varchar(5)", maxLength: 5, nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    NotificationEmail = table.Column<string>(type: "varchar(150)", nullable: false),
                    Status = table.Column<byte>(type: "tinyint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(36)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedUser = table.Column<string>(type: "nvarchar(36)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tenant", x => x.TenantId);
                });

            migrationBuilder.CreateTable(
                name: "TipoActivo",
                columns: table => new
                {
                    TipoActivoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Abbrevation = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Status = table.Column<byte>(type: "tinyint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(36)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedUser = table.Column<string>(type: "nvarchar(36)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoActivo", x => x.TipoActivoId);
                });

            migrationBuilder.CreateTable(
                name: "TipoCaracteristica",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Equipment = table.Column<string>(type: "varchar(50)", nullable: false),
                    Abbrevation = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Status = table.Column<byte>(type: "tinyint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(36)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedUser = table.Column<string>(type: "nvarchar(36)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoCaracteristica", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                columns: table => new
                {
                    UserRoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Status = table.Column<byte>(type: "tinyint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(36)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedUser = table.Column<string>(type: "nvarchar(36)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => x.UserRoleId);
                });

            migrationBuilder.CreateTable(
                name: "Marca",
                columns: table => new
                {
                    MarcaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Abbrevation = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    ClaseActivoId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<byte>(type: "tinyint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(36)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedUser = table.Column<string>(type: "nvarchar(36)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marca", x => x.MarcaId);
                    table.ForeignKey(
                        name: "FK_Marca_ClaseActivo_ClaseActivoId",
                        column: x => x.ClaseActivoId,
                        principalTable: "ClaseActivo",
                        principalColumn: "ClaseActivoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Provider",
                columns: table => new
                {
                    ProviderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BankId = table.Column<int>(type: "int", nullable: false),
                    CurrencyId = table.Column<int>(type: "int", nullable: false),
                    ContactName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    BusinessName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Address = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false),
                    WebAddress = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "varchar(150)", nullable: false),
                    CellPhoneNumber = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    AdditionalComment = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    DocumentNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    BankInterCode = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    DocumentType = table.Column<byte>(type: "tinyint", nullable: false),
                    PaymentType = table.Column<byte>(type: "tinyint", nullable: false),
                    Status = table.Column<byte>(type: "tinyint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(36)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedUser = table.Column<string>(type: "nvarchar(36)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provider", x => x.ProviderId);
                    table.ForeignKey(
                        name: "FK_Provider_Bank_BankId",
                        column: x => x.BankId,
                        principalTable: "Bank",
                        principalColumn: "BankId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Provider_Currency_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currency",
                        principalColumn: "CurrencyId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TenantCompany",
                columns: table => new
                {
                    TenantCompanyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    CompanyType = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<byte>(type: "tinyint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(36)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedUser = table.Column<string>(type: "nvarchar(36)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TenantCompany", x => x.TenantCompanyId);
                    table.ForeignKey(
                        name: "FK_TenantCompany_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TenantCompany_Tenant_TenantId",
                        column: x => x.TenantId,
                        principalTable: "Tenant",
                        principalColumn: "TenantId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserPosition",
                columns: table => new
                {
                    UserPositionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Status = table.Column<byte>(type: "tinyint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(36)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedUser = table.Column<string>(type: "nvarchar(36)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPosition", x => x.UserPositionId);
                    table.ForeignKey(
                        name: "FK_UserPosition_Tenant_TenantId",
                        column: x => x.TenantId,
                        principalTable: "Tenant",
                        principalColumn: "TenantId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CaracteristicasTipoActivo",
                columns: table => new
                {
                    CaracteristicasTipoActivoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoActivoId = table.Column<int>(type: "int", nullable: false),
                    TipoCaracteristicaId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<byte>(type: "tinyint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(36)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedUser = table.Column<string>(type: "nvarchar(36)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaracteristicasTipoActivo", x => x.CaracteristicasTipoActivoId);
                    table.ForeignKey(
                        name: "FK_CaracteristicasTipoActivo_TipoActivo_TipoActivoId",
                        column: x => x.TipoActivoId,
                        principalTable: "TipoActivo",
                        principalColumn: "TipoActivoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CaracteristicasTipoActivo_TipoCaracteristica_TipoCaracteristicaId",
                        column: x => x.TipoCaracteristicaId,
                        principalTable: "TipoCaracteristica",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Activo",
                columns: table => new
                {
                    ActivoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClaseActivoId = table.Column<int>(type: "int", nullable: false),
                    TipoActivoId = table.Column<int>(type: "int", nullable: false),
                    CurrencyId = table.Column<int>(type: "int", nullable: false),
                    EmpresaId = table.Column<int>(type: "int", nullable: false),
                    SedeId = table.Column<int>(type: "int", nullable: false),
                    MarcaId = table.Column<int>(type: "int", nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    Model = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    SerialNumber = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Condition = table.Column<int>(type: "int", nullable: false),
                    Invoice = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    BuyDate = table.Column<DateTime>(type: "Datetime", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    ProviderId = table.Column<int>(type: "int", nullable: false),
                    Observation = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: true),
                    LoanDocument = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    ContractNumber = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Status = table.Column<byte>(type: "tinyint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(36)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedUser = table.Column<string>(type: "nvarchar(36)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activo", x => x.ActivoId);
                    table.ForeignKey(
                        name: "FK_Activo_ClaseActivo_ClaseActivoId",
                        column: x => x.ClaseActivoId,
                        principalTable: "ClaseActivo",
                        principalColumn: "ClaseActivoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Activo_Currency_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currency",
                        principalColumn: "CurrencyId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Activo_Provider_ProviderId",
                        column: x => x.ProviderId,
                        principalTable: "Provider",
                        principalColumn: "ProviderId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Activo_TipoActivo_TipoActivoId",
                        column: x => x.TipoActivoId,
                        principalTable: "TipoActivo",
                        principalColumn: "TipoActivoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantCompanyId = table.Column<int>(type: "int", nullable: false),
                    UserRoleId = table.Column<int>(type: "int", nullable: false),
                    UserPositionId = table.Column<int>(type: "int", nullable: false),
                    ActiveDirectoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Username = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    FirstName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    PaternalLastName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    MaternalLastName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "varchar(150)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    DocumentNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    DocumentType = table.Column<byte>(type: "tinyint", nullable: false),
                    AvatarUrl = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: false),
                    Status = table.Column<byte>(type: "tinyint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(36)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedUser = table.Column<string>(type: "nvarchar(36)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_User_TenantCompany_TenantCompanyId",
                        column: x => x.TenantCompanyId,
                        principalTable: "TenantCompany",
                        principalColumn: "TenantCompanyId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_User_UserPosition_UserPositionId",
                        column: x => x.UserPositionId,
                        principalTable: "UserPosition",
                        principalColumn: "UserPositionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_User_UserRole_UserRoleId",
                        column: x => x.UserRoleId,
                        principalTable: "UserRole",
                        principalColumn: "UserRoleId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CaracteristicasActivo",
                columns: table => new
                {
                    CaracteristicasActivoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CaracteristicasTipoActivoId = table.Column<int>(type: "int", nullable: false),
                    TipoActivoId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Comment = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Status = table.Column<byte>(type: "tinyint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(36)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedUser = table.Column<string>(type: "nvarchar(36)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaracteristicasActivo", x => x.CaracteristicasActivoId);
                    table.ForeignKey(
                        name: "FK_CaracteristicasActivo_CaracteristicasTipoActivo_CaracteristicasTipoActivoId",
                        column: x => x.CaracteristicasTipoActivoId,
                        principalTable: "CaracteristicasTipoActivo",
                        principalColumn: "CaracteristicasTipoActivoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CaracteristicasActivo_TipoActivo_TipoActivoId",
                        column: x => x.TipoActivoId,
                        principalTable: "TipoActivo",
                        principalColumn: "TipoActivoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Activo_ClaseActivoId",
                table: "Activo",
                column: "ClaseActivoId");

            migrationBuilder.CreateIndex(
                name: "IX_Activo_CurrencyId",
                table: "Activo",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Activo_ProviderId",
                table: "Activo",
                column: "ProviderId");

            migrationBuilder.CreateIndex(
                name: "IX_Activo_TipoActivoId",
                table: "Activo",
                column: "TipoActivoId");

            migrationBuilder.CreateIndex(
                name: "IX_CaracteristicasActivo_CaracteristicasTipoActivoId",
                table: "CaracteristicasActivo",
                column: "CaracteristicasTipoActivoId");

            migrationBuilder.CreateIndex(
                name: "IX_CaracteristicasActivo_TipoActivoId",
                table: "CaracteristicasActivo",
                column: "TipoActivoId");

            migrationBuilder.CreateIndex(
                name: "IX_CaracteristicasTipoActivo_TipoActivoId",
                table: "CaracteristicasTipoActivo",
                column: "TipoActivoId");

            migrationBuilder.CreateIndex(
                name: "IX_CaracteristicasTipoActivo_TipoCaracteristicaId",
                table: "CaracteristicasTipoActivo",
                column: "TipoCaracteristicaId");

            migrationBuilder.CreateIndex(
                name: "IX_Marca_ClaseActivoId",
                table: "Marca",
                column: "ClaseActivoId");

            migrationBuilder.CreateIndex(
                name: "IX_Provider_BankId",
                table: "Provider",
                column: "BankId");

            migrationBuilder.CreateIndex(
                name: "IX_Provider_CurrencyId",
                table: "Provider",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_TenantCompany_CompanyId",
                table: "TenantCompany",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_TenantCompany_TenantId",
                table: "TenantCompany",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_User_TenantCompanyId",
                table: "User",
                column: "TenantCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_User_UserPositionId",
                table: "User",
                column: "UserPositionId");

            migrationBuilder.CreateIndex(
                name: "IX_User_UserRoleId",
                table: "User",
                column: "UserRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPosition_TenantId",
                table: "UserPosition",
                column: "TenantId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Activo");

            migrationBuilder.DropTable(
                name: "CaracteristicasActivo");

            migrationBuilder.DropTable(
                name: "Marca");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Provider");

            migrationBuilder.DropTable(
                name: "CaracteristicasTipoActivo");

            migrationBuilder.DropTable(
                name: "ClaseActivo");

            migrationBuilder.DropTable(
                name: "TenantCompany");

            migrationBuilder.DropTable(
                name: "UserPosition");

            migrationBuilder.DropTable(
                name: "UserRole");

            migrationBuilder.DropTable(
                name: "Bank");

            migrationBuilder.DropTable(
                name: "Currency");

            migrationBuilder.DropTable(
                name: "TipoActivo");

            migrationBuilder.DropTable(
                name: "TipoCaracteristica");

            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "Tenant");
        }
    }
}
