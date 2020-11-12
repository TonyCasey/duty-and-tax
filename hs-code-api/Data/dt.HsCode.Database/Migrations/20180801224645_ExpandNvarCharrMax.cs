using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace dt.HsCode.Database.Migrations
{
    public partial class ExpandNvarCharrMax : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ListOfNonAvDuties",
                schema: "HsCode",
                table: "Codes",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "AED",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local), new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "ARS",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local), new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "AUD",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local), new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "AZN",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local), new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "BBD",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local), new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "BDT",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local), new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "BGN",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local), new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "BHD",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local), new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "BMD",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local), new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "BOB",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local), new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "BRL",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local), new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "BYR",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local), new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "BZD",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local), new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "CAD",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local), new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "CHF",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local), new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "CLP",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local), new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "CNY",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local), new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "COP",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local), new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "CRC",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local), new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "CZK",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local), new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "DKK",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local), new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "DOP",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local), new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "EGP",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local), new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "EUR",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 8, 1, 23, 46, 44, 58, DateTimeKind.Local), new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "GBP",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local), new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "GIP",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local), new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "GTQ",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local), new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "HKD",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local), new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "HNL",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local), new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "HRK",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local), new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "HUF",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local), new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "IDR",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local), new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "ILS",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local), new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "INR",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local), new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "JMD",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local), new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "JOD",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local), new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "JPY",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local), new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "KHR",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local), new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "KRW",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local), new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "KWD",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local), new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "KZT",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local), new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "LKR",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local), new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "LTL",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local), new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "LVL",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local), new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "MDL",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local), new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "MVR",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local), new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "MXN",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local), new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "MYR",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local), new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "NIO",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local), new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "NOK",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local), new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "NZD",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local), new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "OMR",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local), new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "PAB",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local), new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "PEN",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local), new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "PHP",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local), new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "PKR",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local), new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "PLN",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local), new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "PYG",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local), new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "QAR",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local), new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "ROL",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local), new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "RON",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local), new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "RUB",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local), new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "SAR",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local), new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "SEK",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local), new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "SGD",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local), new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "THB",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local), new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "TRY",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local), new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "TWD",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local), new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "UAH",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local), new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "USD",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local), new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "VEF",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local), new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "ZAR",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local), new DateTime(2018, 8, 1, 23, 46, 44, 60, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ListOfNonAvDuties",
                schema: "HsCode",
                table: "Codes",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "AED",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local), new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "ARS",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local), new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "AUD",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local), new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "AZN",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local), new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "BBD",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local), new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "BDT",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local), new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "BGN",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local), new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "BHD",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local), new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "BMD",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local), new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "BOB",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local), new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "BRL",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local), new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "BYR",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local), new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "BZD",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local), new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "CAD",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local), new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "CHF",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local), new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "CLP",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local), new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "CNY",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local), new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "COP",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local), new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "CRC",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local), new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "CZK",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local), new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "DKK",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local), new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "DOP",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local), new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "EGP",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local), new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "EUR",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 31, 22, 17, 0, 412, DateTimeKind.Local), new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "GBP",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local), new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "GIP",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local), new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "GTQ",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local), new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "HKD",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local), new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "HNL",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local), new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "HRK",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local), new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "HUF",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local), new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "IDR",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local), new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "ILS",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local), new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "INR",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local), new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "JMD",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local), new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "JOD",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local), new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "JPY",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local), new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "KHR",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local), new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "KRW",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local), new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "KWD",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local), new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "KZT",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local), new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "LKR",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local), new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "LTL",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local), new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "LVL",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local), new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "MDL",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local), new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "MVR",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local), new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "MXN",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local), new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "MYR",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local), new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "NIO",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local), new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "NOK",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local), new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "NZD",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local), new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "OMR",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local), new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "PAB",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local), new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "PEN",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local), new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "PHP",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local), new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "PKR",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local), new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "PLN",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local), new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "PYG",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local), new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "QAR",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local), new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "ROL",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local), new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "RON",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local), new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "RUB",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local), new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "SAR",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local), new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "SEK",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local), new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "SGD",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local), new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "THB",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local), new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "TRY",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local), new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "TWD",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local), new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "UAH",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local), new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "USD",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local), new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "VEF",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local), new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "ZAR",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local), new DateTime(2018, 7, 31, 22, 17, 0, 413, DateTimeKind.Local) });
        }
    }
}
