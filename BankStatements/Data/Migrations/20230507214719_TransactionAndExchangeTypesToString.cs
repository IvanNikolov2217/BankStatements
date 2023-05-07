using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankStatements.Data.Migrations
{
    /// <inheritdoc />
    public partial class TransactionAndExchangeTypesToString : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Statements_ExchangeTypes_ExchangeTypeId",
                table: "Statements");

            migrationBuilder.DropForeignKey(
                name: "FK_Statements_TransactionTypes_TransactionTypeId",
                table: "Statements");

            migrationBuilder.DropIndex(
                name: "IX_Statements_ExchangeTypeId",
                table: "Statements");

            migrationBuilder.DropIndex(
                name: "IX_Statements_TransactionTypeId",
                table: "Statements");

            migrationBuilder.DropColumn(
                name: "ExchangeTypeId",
                table: "Statements");

            migrationBuilder.DropColumn(
                name: "TransactionTypeId",
                table: "Statements");

            migrationBuilder.AddColumn<string>(
                name: "ExchangeType",
                table: "Statements",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TransactionType",
                table: "Statements",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExchangeType",
                table: "Statements");

            migrationBuilder.DropColumn(
                name: "TransactionType",
                table: "Statements");

            migrationBuilder.AddColumn<int>(
                name: "ExchangeTypeId",
                table: "Statements",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TransactionTypeId",
                table: "Statements",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.CreateIndex(
                name: "IX_Statements_ExchangeTypeId",
                table: "Statements",
                column: "ExchangeTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Statements_TransactionTypeId",
                table: "Statements",
                column: "TransactionTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Statements_ExchangeTypes_ExchangeTypeId",
                table: "Statements",
                column: "ExchangeTypeId",
                principalTable: "ExchangeTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Statements_TransactionTypes_TransactionTypeId",
                table: "Statements",
                column: "TransactionTypeId",
                principalTable: "TransactionTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
