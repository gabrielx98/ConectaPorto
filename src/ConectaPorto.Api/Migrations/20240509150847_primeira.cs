using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConectaPorto.Api.Migrations
{
    /// <inheritdoc />
    public partial class primeira : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarrierMode",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Veiculo = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarrierMode", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Nome = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FreightKind",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Cicla = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Descricao = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FreightKind", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ISO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Codigo = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Descricao = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ISO", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Portos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Cicla = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Cidade = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Pais = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Portos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TransitState",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Descricao = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransitState", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transportadoras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Cicla = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Nome = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transportadoras", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UnitCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Descricao = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Nome = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Login = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Password = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Email = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Telefone = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VisitState",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Situacao = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitState", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Carrier",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Codigo = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    VisitStateId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    DataPartida = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    DataChegada = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    POLId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    PODId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CarrierModeId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carrier", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carrier_CarrierMode_CarrierModeId",
                        column: x => x.CarrierModeId,
                        principalTable: "CarrierMode",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Carrier_Portos_PODId",
                        column: x => x.PODId,
                        principalTable: "Portos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Carrier_Portos_POLId",
                        column: x => x.POLId,
                        principalTable: "Portos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Carrier_VisitState_VisitStateId",
                        column: x => x.VisitStateId,
                        principalTable: "VisitState",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Unit",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Nbr = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    ProprietarioId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    IsoId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CategoriaId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    TransportadoraId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Booking = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    FreightKindId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    TransitStateId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CarrierIbId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CarrierObId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Unit_Carrier_CarrierIbId",
                        column: x => x.CarrierIbId,
                        principalTable: "Carrier",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Unit_Carrier_CarrierObId",
                        column: x => x.CarrierObId,
                        principalTable: "Carrier",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Unit_Clientes_ProprietarioId",
                        column: x => x.ProprietarioId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Unit_FreightKind_FreightKindId",
                        column: x => x.FreightKindId,
                        principalTable: "FreightKind",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Unit_ISO_IsoId",
                        column: x => x.IsoId,
                        principalTable: "ISO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Unit_Transportadoras_TransitStateId",
                        column: x => x.TransitStateId,
                        principalTable: "Transportadoras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Unit_Transportadoras_TransportadoraId",
                        column: x => x.TransportadoraId,
                        principalTable: "Transportadoras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Unit_UnitCategory_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "UnitCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Carrier_CarrierModeId",
                table: "Carrier",
                column: "CarrierModeId");

            migrationBuilder.CreateIndex(
                name: "IX_Carrier_PODId",
                table: "Carrier",
                column: "PODId");

            migrationBuilder.CreateIndex(
                name: "IX_Carrier_POLId",
                table: "Carrier",
                column: "POLId");

            migrationBuilder.CreateIndex(
                name: "IX_Carrier_VisitStateId",
                table: "Carrier",
                column: "VisitStateId");

            migrationBuilder.CreateIndex(
                name: "IX_Unit_CarrierIbId",
                table: "Unit",
                column: "CarrierIbId");

            migrationBuilder.CreateIndex(
                name: "IX_Unit_CarrierObId",
                table: "Unit",
                column: "CarrierObId");

            migrationBuilder.CreateIndex(
                name: "IX_Unit_CategoriaId",
                table: "Unit",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Unit_FreightKindId",
                table: "Unit",
                column: "FreightKindId");

            migrationBuilder.CreateIndex(
                name: "IX_Unit_IsoId",
                table: "Unit",
                column: "IsoId");

            migrationBuilder.CreateIndex(
                name: "IX_Unit_ProprietarioId",
                table: "Unit",
                column: "ProprietarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Unit_TransitStateId",
                table: "Unit",
                column: "TransitStateId");

            migrationBuilder.CreateIndex(
                name: "IX_Unit_TransportadoraId",
                table: "Unit",
                column: "TransportadoraId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TransitState");

            migrationBuilder.DropTable(
                name: "Unit");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Carrier");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "FreightKind");

            migrationBuilder.DropTable(
                name: "ISO");

            migrationBuilder.DropTable(
                name: "Transportadoras");

            migrationBuilder.DropTable(
                name: "UnitCategory");

            migrationBuilder.DropTable(
                name: "CarrierMode");

            migrationBuilder.DropTable(
                name: "Portos");

            migrationBuilder.DropTable(
                name: "VisitState");
        }
    }
}
