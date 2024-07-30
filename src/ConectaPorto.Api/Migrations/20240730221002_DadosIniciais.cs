using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConectaPorto.Api.Migrations
{
    /// <inheritdoc />
    public partial class DadosIniciais : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
            table: "Clientes",
            columns: new[] { "Id", "Nome", "CNPJ" },
            values: new object[,]
            {
                { 1, "Eletronicos Ltd", 92692440000175 },
                { 2, "Ar Condicionados Brasil", 99465604000170 },
                { 3, "Roupas e Cia", 98979121000121 }
            });

            migrationBuilder.InsertData(
                table: "CarrierMode",
                columns: new[] { "Id", "Veiculo" },
                values: new object[,]
                {
                { 1, "Caminhão" },
                { 2, "Navio" },
                { 3, "Trem" }
                });

            migrationBuilder.InsertData(
                table: "FreightKind",
                columns: new[] { "Id", "Cicla", "Descricao" },
                values: new object[,]
                {
                { 1, "BBK", "Carga Unitária" },
                { 2, "FCL", "Totalmente Carregado" },
                { 3, "LCL", "Parcialmente Carregado" },
                { 4, "MTY" , "Vazio" }
                });

            migrationBuilder.InsertData(
                table: "ISO",
                columns: new[] { "Id", "Codigo", "Tamanho", "Tipo", "Descricao" },
                values: new object[,]
                {
                { 1 , 2000, 20, "Geral", "Unidade de 20" },
                { 2 , 2030, 20, "Refrigerado", "Unidade de 20 Refrigerada" },
                { 3 , 2050, 20, "Topo Aberto", "Unidade de 20 com Topo Aberto" },
                { 4 , 2060, 20, "Plataforma", "Unidade de 20 Tipo Plataforma" },
                { 5 , 2070, 20, "Tank de Líquidos", "Unidade de 20 Tank de Líquidos" },
                { 6 , 4000, 40, "Geral", "Unidade de 40" },
                { 7 , 4030, 40, "Refrigerado", "Unidade de 40 Refrigerada" },
                { 8 , 4050, 40, "Topo Aberto", "Unidade de 40 com Topo Aberto" },
                { 9 , 4060, 40, "Plataforma", "Unidade de 40 Tipo Plataforma" },
                { 10, 4070, 40, "Tank de Líquidos", "Unidade de 40 Tank de Líquidos" }
                });

            migrationBuilder.InsertData(
                table: "Portos",
                columns: new[] { "Id", "Cicla", "Cidade", "Pais" },
                values: new object[,]
                {
                { 1, "BLH", "Belo Horizonte", "Brasil" },
                { 2, "CPQ", "Campinas", "Brasil" },
                { 3, "FOR", "Fortaleza", "Brasil" },
                { 4, "PNG", "Paranagua", "Brasil" },
                { 5, "POA", "Porto Alegre", "Brasil" },
                { 6, "RIO", "Rio de Janeiro", "Brasil" },
                { 7, "SSZ", "Santos", "Brasil" }
                });

            migrationBuilder.InsertData(
                table: "TransitState",
                columns: new[] { "Id", "Descricao" },
                values: new object[,]
                {
                { 1, "Inbound" },
                { 2, "Outbound" },
                { 3, "Ecin" },
                { 4, "Ecout" },
                { 5, "Yard" },
                { 6, "Advised" },
                { 7, "Loaded" },
                { 8, "Departed" },
                { 9, "Retired" },
                });

            migrationBuilder.InsertData(
                table: "Transportadoras",
                columns: new[] { "Id", "Cicla", "Nome", "CNPJ" },
                values: new object[,]
                {
                { 1, "MSC", "Mediterranean Shipping Company SA", 69362111000144 },
                { 2, "MSK", "Maersk", 93352156000112 },
                { 3, "HLD", "Hapag-Lhoyd", 11290033000130 }
                });

            migrationBuilder.InsertData(
                table: "UnitCategory",
                columns: new[] { "Id", "Descricao" },
                values: new object[,]
                {
                { 1, "Import" },
                { 2, "Export" },
                { 3, "Domestic" },
                { 4, "Storage" },
                { 5, "Throught" },
                { 6, "Transship" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Nome", "CPF", "Login", "Password", "PasswordHash", "Email", "Telefone" },
                values: new object[,]
                {
                { 1, "Administrador", 59558171077, "admin" , "", "", "admin@conectaporto.com", "(13) 99123-1234" }
                });

            migrationBuilder.InsertData(
                table: "VisitState",
                columns: new[] { "Id", "Situacao" },
                values: new object[,]
                {
                { 1, "Active" },
                { 2, "Departed" },
                { 3, "Advised" },
                { 4, "Retired" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            #region "Clientes"

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 3);

            #endregion

            #region "CarrierMode"

            migrationBuilder.DeleteData(
                table: "CarrierMode",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
               table: "CarrierMode",
               keyColumn: "Id",
               keyValue: 2);

            migrationBuilder.DeleteData(
               table: "CarrierMode",
               keyColumn: "Id",
               keyValue: 3);

            #endregion

            #region "FreightKind"

            migrationBuilder.DeleteData(
                table: "FreightKind",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FreightKind",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FreightKind",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FreightKind",
                keyColumn: "Id",
                keyValue: 4);

            #endregion

            #region "Iso"

            migrationBuilder.DeleteData(
                table: "Iso",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Iso",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Iso",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Iso",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Iso",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Iso",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Iso",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Iso",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Iso",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Iso",
                keyColumn: "Id",
                keyValue: 10);

            #endregion

            #region "Porto"

            migrationBuilder.DeleteData(
                table: "Porto",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Porto",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Porto",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Porto",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Porto",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Porto",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Porto",
                keyColumn: "Id",
                keyValue: 7);

            #endregion

            #region "TransitState"

            migrationBuilder.DeleteData(
                table: "TransitState",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TransitState",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TransitState",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TransitState",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TransitState",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TransitState",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TransitState",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TransitState",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TransitState",
                keyColumn: "Id",
                keyValue: 9);

            #endregion

            #region "Transportadora"

            migrationBuilder.DeleteData(
                table: "Transportadora",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Transportadora",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Transportadora",
                keyColumn: "Id",
                keyValue: 3);

            #endregion

            #region "UnitCategory"

            migrationBuilder.DeleteData(
                table: "UnitCategory",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UnitCategory",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UnitCategory",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UnitCategory",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "UnitCategory",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "UnitCategory",
                keyColumn: "Id",
                keyValue: 6);

            #endregion

            #region "Usuario"

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 1);

            #endregion

            #region "VisitState"

            migrationBuilder.DeleteData(
                table: "VisitState",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "VisitState",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "VisitState",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "VisitState",
                keyColumn: "Id",
                keyValue: 4);

            #endregion
        }
    }
}
