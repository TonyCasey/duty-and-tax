using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace dt.Calculator.Database.Migrations
{
    public partial class Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 113);

            migrationBuilder.AddColumn<bool>(
                name: "ToDelete",
                schema: "Lookup",
                table: "CanadianProvincialTaxRates",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 12,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 2, "AD" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 13,
                column: "CountryIso",
                value: "AE");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 14,
                column: "CountryIso",
                value: "AF");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 15,
                column: "CountryIso",
                value: "AG");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 16,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 1, "AI" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 18,
                column: "CountryIso",
                value: "AM");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 19,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 1, "AO" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 20,
                column: "CountryIso",
                value: "AQ");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 21,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 1, "AR" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 22,
                column: "CountryIso",
                value: "AS");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 23,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 2, "AT" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 25,
                column: "CountryIso",
                value: "AW");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 26,
                column: "CountryIso",
                value: "AX");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 27,
                column: "CountryIso",
                value: "AZ");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 28,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 2, "BA" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 29,
                column: "CountryIso",
                value: "BB");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 30,
                column: "CountryIso",
                value: "BD");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 31,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 2, "BE" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 32,
                column: "CountryIso",
                value: "BF");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 33,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 2, "BG" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 35,
                column: "CountryIso",
                value: "BI");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 36,
                column: "CountryIso",
                value: "BJ");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 37,
                column: "CountryIso",
                value: "BL");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 38,
                column: "CountryIso",
                value: "BM");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 39,
                column: "CountryIso",
                value: "BN");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 40,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 1, "BO" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 41,
                column: "CountryIso",
                value: "BQ");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 43,
                column: "CountryIso",
                value: "BS");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 44,
                column: "CountryIso",
                value: "BT");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 45,
                column: "CountryIso",
                value: "BV");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 46,
                column: "CountryIso",
                value: "BW");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 47,
                column: "CountryIso",
                value: "BY");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 48,
                column: "CountryIso",
                value: "BZ");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 50,
                column: "CountryIso",
                value: "CC");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 51,
                column: "CountryIso",
                value: "CD");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 52,
                column: "CountryIso",
                value: "CF");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 53,
                column: "CountryIso",
                value: "CG");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 55,
                column: "CountryIso",
                value: "CI");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 56,
                column: "CountryIso",
                value: "CK");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 58,
                column: "CountryIso",
                value: "CM");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 60,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 1, "CO" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 61,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 1, "CR" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 62,
                column: "CountryIso",
                value: "CU");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 63,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 1, "CV" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 64,
                column: "CountryIso",
                value: "CW");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 65,
                column: "CountryIso",
                value: "CX");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 66,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 2, "CY" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 67,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 2, "CZ" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 68,
                column: "CountryIso",
                value: "DE");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 69,
                column: "CountryIso",
                value: "DJ");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 70,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 2, "DK" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 71,
                column: "CountryIso",
                value: "DM");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 72,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 1, "DO" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 73,
                column: "CountryIso",
                value: "DZ");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 74,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 1, "EC" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 75,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 2, "EE" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 76,
                column: "CountryIso",
                value: "EG");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 77,
                column: "CountryIso",
                value: "EH");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 78,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 1, "ER" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 79,
                column: "CountryIso",
                value: "ES");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 80,
                column: "CountryIso",
                value: "ET");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 82,
                column: "CountryIso",
                value: "FJ");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 83,
                column: "CountryIso",
                value: "FK");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 84,
                column: "CountryIso",
                value: "FM");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 85,
                column: "CountryIso",
                value: "FO");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 86,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 2, "FR" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 87,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 1, "GA" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 89,
                column: "CountryIso",
                value: "GD");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 90,
                column: "CountryIso",
                value: "GE");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 91,
                column: "CountryIso",
                value: "GF");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 92,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 2, "GG" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 93,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 1, "GH" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 94,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 2, "GI" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 95,
                column: "CountryIso",
                value: "GL");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 96,
                column: "CountryIso",
                value: "GM");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 97,
                column: "CountryIso",
                value: "GN");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 98,
                column: "CountryIso",
                value: "GP");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 99,
                column: "CountryIso",
                value: "GQ");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 100,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 2, "GR" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 101,
                column: "CountryIso",
                value: "GS");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 102,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 1, "GT" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 103,
                column: "CountryIso",
                value: "GU");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 104,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 1, "GW" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 105,
                column: "CountryIso",
                value: "GY");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 107,
                column: "CountryIso",
                value: "HM");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 108,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 1, "HN" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 109,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 2, "HR" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 110,
                column: "CountryIso",
                value: "HT");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 111,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 2, "HU" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 112,
                column: "CountryIso",
                value: "ID");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 114,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 1, "IL" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 115,
                column: "CountryIso",
                value: "IM");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 116,
                column: "CountryIso",
                value: "IN");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 117,
                column: "CountryIso",
                value: "IO");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 118,
                column: "CountryIso",
                value: "IQ");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 119,
                column: "CountryIso",
                value: "IR");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 120,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 2, "IS" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 121,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 2, "IT" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 122,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 2, "JE" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 123,
                column: "CountryIso",
                value: "JM");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 124,
                column: "CountryIso",
                value: "JO");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 125,
                column: "CountryIso",
                value: "JP");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 126,
                column: "CountryIso",
                value: "KE");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 127,
                column: "CountryIso",
                value: "KG");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 128,
                column: "CountryIso",
                value: "KH");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 129,
                column: "CountryIso",
                value: "KI");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 130,
                column: "CountryIso",
                value: "KM");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 131,
                column: "CountryIso",
                value: "KN");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 132,
                column: "CountryIso",
                value: "KP");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 133,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 1, "KR" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 134,
                column: "CountryIso",
                value: "KW");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 135,
                column: "CountryIso",
                value: "KY");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 136,
                column: "CountryIso",
                value: "KZ");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 137,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 1, "LA" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 138,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 1, "LB" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 139,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 1, "LC" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 140,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 2, "LI" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 141,
                column: "CountryIso",
                value: "LK");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 142,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 1, "LR" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 143,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 1, "LS" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 144,
                column: "CountryIso",
                value: "LT");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 145,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 2, "LU" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 146,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 2, "LV" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 147,
                column: "CountryIso",
                value: "LY");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 148,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 1, "MA" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 149,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 2, "MC" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 150,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 2, "MD" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 151,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 2, "ME" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 152,
                column: "CountryIso",
                value: "MF");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 153,
                column: "CountryIso",
                value: "MG");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 154,
                column: "CountryIso",
                value: "MH");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 155,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 2, "MK" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 156,
                column: "CountryIso",
                value: "ML");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 157,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 1, "MM" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 158,
                column: "CountryIso",
                value: "MN");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 159,
                column: "CountryIso",
                value: "MO");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 160,
                column: "CountryIso",
                value: "MP");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 161,
                column: "CountryIso",
                value: "MQ");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 162,
                column: "CountryIso",
                value: "MR");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 163,
                column: "CountryIso",
                value: "MS");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 164,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 2, "MT" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 165,
                column: "CountryIso",
                value: "MU");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 166,
                column: "CountryIso",
                value: "MV");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 167,
                column: "CountryIso",
                value: "MW");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 168,
                column: "CountryIso",
                value: "MX");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 169,
                column: "CountryIso",
                value: "MY");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 170,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 1, "MZ" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 171,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 1, "NA" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 172,
                column: "CountryIso",
                value: "NC");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 173,
                column: "CountryIso",
                value: "NE");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 174,
                column: "CountryIso",
                value: "NF");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 175,
                column: "CountryIso",
                value: "NG");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 176,
                column: "CountryIso",
                value: "NI");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 177,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 2, "NL" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 178,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 2, "NO" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 179,
                column: "CountryIso",
                value: "NP");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 180,
                column: "CountryIso",
                value: "NR");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 181,
                column: "CountryIso",
                value: "NU");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 182,
                column: "CountryIso",
                value: "NZ");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 183,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 1, "OM" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 184,
                column: "CountryIso",
                value: "PA");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 185,
                column: "CountryIso",
                value: "PE");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 186,
                column: "CountryIso",
                value: "PF");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 187,
                column: "CountryIso",
                value: "PG");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 188,
                column: "CountryIso",
                value: "PH");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 189,
                column: "CountryIso",
                value: "PK");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 190,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 2, "PL" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 191,
                column: "CountryIso",
                value: "PM");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 192,
                column: "CountryIso",
                value: "PN");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 193,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 1, "PR" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 194,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 1, "PS" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 195,
                column: "CountryIso",
                value: "PT");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 196,
                column: "CountryIso",
                value: "PW");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 197,
                column: "CountryIso",
                value: "PY");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 198,
                column: "CountryIso",
                value: "QA");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 199,
                column: "CountryIso",
                value: "RE");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 200,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 2, "RO" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 201,
                column: "CountryIso",
                value: "RS");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 202,
                column: "CountryIso",
                value: "RU");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 203,
                column: "CountryIso",
                value: "RW");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 204,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 1, "SA" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 205,
                column: "CountryIso",
                value: "SB");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 206,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 1, "SC" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 207,
                column: "CountryIso",
                value: "SD");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 208,
                column: "CountryIso",
                value: "SE");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 209,
                column: "CountryIso",
                value: "SG");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 210,
                column: "CountryIso",
                value: "SH");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 211,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 2, "SI" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 212,
                column: "CountryIso",
                value: "SJ");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 213,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 2, "SK" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 214,
                column: "CountryIso",
                value: "SL");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 215,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 2, "SM" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 216,
                column: "CountryIso",
                value: "SN");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 217,
                column: "CountryIso",
                value: "SO");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 218,
                column: "CountryIso",
                value: "SR");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 219,
                column: "CountryIso",
                value: "SS");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 220,
                column: "CountryIso",
                value: "ST");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 221,
                column: "CountryIso",
                value: "SV");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 222,
                column: "CountryIso",
                value: "SX");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 223,
                column: "CountryIso",
                value: "SY");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 224,
                column: "CountryIso",
                value: "SZ");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 225,
                column: "CountryIso",
                value: "TC");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 226,
                column: "CountryIso",
                value: "TD");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 227,
                column: "CountryIso",
                value: "TF");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 228,
                column: "CountryIso",
                value: "TG");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 229,
                column: "CountryIso",
                value: "TH");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 230,
                column: "CountryIso",
                value: "TJ");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 231,
                column: "CountryIso",
                value: "TK");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 232,
                column: "CountryIso",
                value: "TL");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 233,
                column: "CountryIso",
                value: "TM");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 234,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 1, "TN" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 235,
                column: "CountryIso",
                value: "TO");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 236,
                column: "CountryIso",
                value: "TR");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 237,
                column: "CountryIso",
                value: "TT");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 238,
                column: "CountryIso",
                value: "TV");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 239,
                column: "CountryIso",
                value: "TW");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 240,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 1, "TZ" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 241,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 2, "UA" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 242,
                column: "CountryIso",
                value: "UG");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 243,
                column: "CountryIso",
                value: "UM");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 244,
                column: "CountryIso",
                value: "US");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 245,
                column: "CountryIso",
                value: "UY");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 246,
                column: "CountryIso",
                value: "UZ");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 247,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 2, "VA" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 248,
                column: "CountryIso",
                value: "VC");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 249,
                column: "CountryIso",
                value: "VE");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 250,
                column: "CountryIso",
                value: "VG");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 251,
                column: "CountryIso",
                value: "VI");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 252,
                column: "CountryIso",
                value: "VN");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 253,
                column: "CountryIso",
                value: "VU");

            migrationBuilder.InsertData(
                schema: "Calculator",
                table: "Calculators",
                columns: new[] { "CalculatorId", "CalculatorSettingId", "CountryIso" },
                values: new object[,]
                {
                    { 259, 1, "ZM" },
                    { 258, 1, "ZA" },
                    { 260, 1, "ZW" },
                    { 257, 1, "YT" },
                    { 256, 1, "YE" },
                    { 42, 1, "BR" },
                    { 254, 1, "WF" },
                    { 81, 2, "FI" },
                    { 17, 2, "AL" },
                    { 255, 1, "WS" }
                });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Settings",
                keyColumn: "CalculatorSettingId",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2018, 7, 26, 21, 49, 1, 385, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Settings",
                keyColumn: "CalculatorSettingId",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2018, 7, 26, 21, 49, 1, 385, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Settings",
                keyColumn: "CalculatorSettingId",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2018, 7, 26, 21, 49, 1, 385, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Settings",
                keyColumn: "CalculatorSettingId",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2018, 7, 26, 21, 49, 1, 385, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Settings",
                keyColumn: "CalculatorSettingId",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2018, 7, 26, 21, 49, 1, 386, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Settings",
                keyColumn: "CalculatorSettingId",
                keyValue: 6,
                column: "CreationTime",
                value: new DateTime(2018, 7, 26, 21, 49, 1, 386, DateTimeKind.Local));

            migrationBuilder.InsertData(
                schema: "Calculator",
                table: "Settings",
                columns: new[] { "CalculatorSettingId", "CountryIso", "CreationTime", "CreationUser", "CurrencyIso", "DefaultOtherTaxRate", "DutyApplicable", "DutyCalculationMethod", "DutyRate", "DutyRefundable", "DutyThreshold", "DutyThresholdForGifts", "Fee", "FeeRate", "FeeRefundable", "FeeThreshold", "FeesApplicable", "LastUpdateTime", "LastUpdateUser", "MaximumDutyPayable", "MaximumOtherTaxPayable", "MaximumTaxPayable", "MinimumDutyPayable", "MinimumOtherTaxPayable", "MinimumTaxPayable", "Name", "OtherTaxApplicable", "OtherTaxCalculationMethod", "OtherTaxIncludesDuty", "OtherTaxRefundable", "OtherTaxThreshold", "TaxApplicable", "TaxCalculationMethod", "TaxIncludesDuty", "TaxIncludesFees", "TaxRate", "TaxRefundable", "TaxThreshold", "TaxThresholdForGifts" },
                values: new object[,]
                {
                    { 7, "CA", new DateTime(2018, 7, 26, 21, 49, 1, 386, DateTimeKind.Local), "Seed", "AED", 0m, true, 2, 0.0461m, false, 1000m, 0m, 0m, 0m, false, 0m, false, null, null, 0m, 0m, 0m, 0m, 0m, 0m, "United Arab Emirates", false, 0, false, false, 0m, false, 0, false, false, 0m, false, 0m, 0m },
                    { 8, "BH", new DateTime(2018, 7, 26, 21, 49, 1, 386, DateTimeKind.Local), "Seed", "BHD", 0m, true, 2, 0.05m, false, 113m, 0m, 0m, 0m, false, 0m, false, null, null, 0m, 0m, 0m, 0m, 0m, 0m, "Bahrain Calculator", false, 0, false, false, 0m, false, 0, false, false, 0m, false, 0m, 0m },
                    { 9, "CH", new DateTime(2018, 7, 26, 21, 49, 1, 386, DateTimeKind.Local), "Seed", "CHF", 0m, true, 2, 0.16m, false, 113m, 0m, 0m, 0m, false, 0m, false, null, null, 0m, 0m, 0m, 0m, 0m, 0m, "Switzerland Calculator", false, 0, false, false, 0m, true, 0, true, false, 0.077m, false, 300m, 0m },
                    { 10, "CN", new DateTime(2018, 7, 26, 21, 49, 1, 386, DateTimeKind.Local), "Seed", "CNY", 0m, true, 2, 0.02m, false, 50m, 0m, 0m, 0m, false, 0m, false, null, null, 0m, 0m, 0m, 0m, 0m, 0m, "China Calculator", false, 0, false, false, 0m, true, 0, true, false, 0.17m, false, 50m, 0m },
                    { 11, "CL", new DateTime(2018, 7, 26, 21, 49, 1, 386, DateTimeKind.Local), "Seed", "CLP", 0m, true, 2, 0.06m, false, 30m, 0m, 0m, 0m, false, 0m, false, null, null, 0m, 0m, 0m, 0m, 0m, 0m, "Chile Calculator", false, 0, false, false, 0m, true, 0, true, false, 0.19m, false, 0m, 0m },
                    { 12, "HK", new DateTime(2018, 7, 26, 21, 49, 1, 386, DateTimeKind.Local), "Seed", "HKD", 0m, true, 2, 0.06m, false, 30m, 0m, 0m, 0m, false, 0m, false, null, null, 0m, 0m, 0m, 0m, 0m, 0m, "Hong Kong Calculator", false, 0, false, false, 0m, true, 0, true, false, 0.19m, false, 0m, 0m },
                    { 13, "HK", new DateTime(2018, 7, 26, 21, 49, 1, 386, DateTimeKind.Local), "Seed", "EUR", 0m, true, 2, 0.06m, false, 30m, 0m, 0m, 0m, false, 0m, false, null, null, 0m, 0m, 0m, 0m, 0m, 0m, "Andora Calculator", false, 0, false, false, 0m, true, 0, true, false, 0.19m, false, 0m, 0m }
                });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "AED",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local), new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "ARS",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local), new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "AUD",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local), new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "AZN",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local), new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "BBD",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local), new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "BDT",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local), new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "BGN",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local), new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "BHD",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local), new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "BMD",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local), new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "BOB",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local), new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "BRL",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local), new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "BYR",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local), new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "BZD",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local), new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "CAD",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local), new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "CHF",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local), new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "CLP",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local), new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "CNY",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local), new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "COP",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local), new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "CRC",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local), new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "CZK",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local), new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "DKK",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local), new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "DOP",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local), new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "EGP",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local), new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "EUR",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 26, 21, 49, 1, 380, DateTimeKind.Local), new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "GBP",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local), new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "GIP",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local), new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "GTQ",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local), new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "HKD",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local), new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "HNL",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local), new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "HRK",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local), new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "HUF",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local), new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "IDR",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local), new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "ILS",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local), new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "INR",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local), new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "JMD",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local), new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "JOD",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local), new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "JPY",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local), new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "KHR",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local), new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "KRW",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local), new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "KWD",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local), new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "KZT",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local), new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "LKR",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local), new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "LTL",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local), new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "LVL",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local), new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "MDL",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local), new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "MVR",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local), new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "MXN",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local), new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "MYR",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local), new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "NIO",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local), new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "NOK",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local), new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "NZD",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local), new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "OMR",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local), new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "PAB",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local), new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "PEN",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local), new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "PHP",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local), new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "PKR",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local), new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "PLN",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local), new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "PYG",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local), new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "QAR",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local), new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "ROL",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local), new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "RON",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local), new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "RUB",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local), new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "SAR",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local), new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "SEK",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local), new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "SGD",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local), new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "THB",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local), new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "TRY",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local), new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "TWD",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local), new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "UAH",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local), new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "USD",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local), new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "VEF",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local), new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "ZAR",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local), new DateTime(2018, 7, 26, 21, 49, 1, 381, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 5,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 7, "CA" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 6,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 8, "BH" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 7,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 9, "CH" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 8,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 10, "CN" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 9,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 11, "CL" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 10,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 12, "HK" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 11,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 13, "HK" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 254);

            migrationBuilder.DeleteData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 255);

            migrationBuilder.DeleteData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 256);

            migrationBuilder.DeleteData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 257);

            migrationBuilder.DeleteData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 258);

            migrationBuilder.DeleteData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 259);

            migrationBuilder.DeleteData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 260);

            migrationBuilder.DeleteData(
                schema: "Calculator",
                table: "Settings",
                keyColumn: "CalculatorSettingId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "Calculator",
                table: "Settings",
                keyColumn: "CalculatorSettingId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "Calculator",
                table: "Settings",
                keyColumn: "CalculatorSettingId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "Calculator",
                table: "Settings",
                keyColumn: "CalculatorSettingId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "Calculator",
                table: "Settings",
                keyColumn: "CalculatorSettingId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                schema: "Calculator",
                table: "Settings",
                keyColumn: "CalculatorSettingId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                schema: "Calculator",
                table: "Settings",
                keyColumn: "CalculatorSettingId",
                keyValue: 13);

            migrationBuilder.DropColumn(
                name: "ToDelete",
                schema: "Lookup",
                table: "CanadianProvincialTaxRates");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 5,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 2, "AD" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 6,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 1, "AE" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 7,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 1, "AF" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 8,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 1, "AG" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 9,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 1, "AI" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 10,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 2, "AL" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 11,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 1, "AM" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 12,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 1, "AO" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 13,
                column: "CountryIso",
                value: "AQ");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 14,
                column: "CountryIso",
                value: "AR");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 15,
                column: "CountryIso",
                value: "AS");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 16,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 2, "AT" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 18,
                column: "CountryIso",
                value: "AW");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 19,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 2, "AX" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 20,
                column: "CountryIso",
                value: "AZ");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 21,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 2, "BA" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 22,
                column: "CountryIso",
                value: "BB");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 23,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 1, "BD" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 25,
                column: "CountryIso",
                value: "BF");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 26,
                column: "CountryIso",
                value: "BG");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 27,
                column: "CountryIso",
                value: "BH");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 28,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 1, "BI" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 29,
                column: "CountryIso",
                value: "BJ");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 30,
                column: "CountryIso",
                value: "BL");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 31,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 1, "BM" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 32,
                column: "CountryIso",
                value: "BN");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 33,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 1, "BO" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 35,
                column: "CountryIso",
                value: "BR");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 36,
                column: "CountryIso",
                value: "BS");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 37,
                column: "CountryIso",
                value: "BT");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 38,
                column: "CountryIso",
                value: "BV");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 39,
                column: "CountryIso",
                value: "BW");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 40,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 2, "BY" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 41,
                column: "CountryIso",
                value: "BZ");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 43,
                column: "CountryIso",
                value: "CC");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 44,
                column: "CountryIso",
                value: "CD");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 45,
                column: "CountryIso",
                value: "CF");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 46,
                column: "CountryIso",
                value: "CG");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 47,
                column: "CountryIso",
                value: "CH");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 48,
                column: "CountryIso",
                value: "CI");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 50,
                column: "CountryIso",
                value: "CL");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 51,
                column: "CountryIso",
                value: "CM");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 52,
                column: "CountryIso",
                value: "CN");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 53,
                column: "CountryIso",
                value: "CO");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 55,
                column: "CountryIso",
                value: "CU");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 56,
                column: "CountryIso",
                value: "CV");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 58,
                column: "CountryIso",
                value: "CX");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 60,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 2, "CZ" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 61,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 2, "DE" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 62,
                column: "CountryIso",
                value: "DJ");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 63,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 2, "DK" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 64,
                column: "CountryIso",
                value: "DM");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 65,
                column: "CountryIso",
                value: "DO");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 66,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 1, "DZ" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 67,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 1, "EC" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 68,
                column: "CountryIso",
                value: "EE");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 69,
                column: "CountryIso",
                value: "EG");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 70,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 1, "EH" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 71,
                column: "CountryIso",
                value: "ER");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 72,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 2, "ES" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 73,
                column: "CountryIso",
                value: "ET");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 74,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 2, "FI" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 75,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 1, "FJ" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 76,
                column: "CountryIso",
                value: "FK");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 77,
                column: "CountryIso",
                value: "FM");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 78,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 2, "FO" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 79,
                column: "CountryIso",
                value: "FR");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 80,
                column: "CountryIso",
                value: "GA");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 82,
                column: "CountryIso",
                value: "GD");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 83,
                column: "CountryIso",
                value: "GE");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 84,
                column: "CountryIso",
                value: "GF");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 85,
                column: "CountryIso",
                value: "GG");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 86,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 1, "GH" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 87,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 2, "GI" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 89,
                column: "CountryIso",
                value: "GM");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 90,
                column: "CountryIso",
                value: "GN");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 91,
                column: "CountryIso",
                value: "GP");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 92,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 1, "GQ" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 93,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 2, "GR" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 94,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 1, "GS" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 95,
                column: "CountryIso",
                value: "GT");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 96,
                column: "CountryIso",
                value: "GU");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 97,
                column: "CountryIso",
                value: "GW");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 98,
                column: "CountryIso",
                value: "GY");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 99,
                column: "CountryIso",
                value: "HK");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 100,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 1, "HM" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 101,
                column: "CountryIso",
                value: "HN");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 102,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 2, "HR" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 103,
                column: "CountryIso",
                value: "HT");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 104,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 2, "HU" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 105,
                column: "CountryIso",
                value: "ID");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 107,
                column: "CountryIso",
                value: "IL");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 108,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 2, "IM" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 109,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 1, "IN" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 110,
                column: "CountryIso",
                value: "IO");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 111,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 1, "IQ" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 112,
                column: "CountryIso",
                value: "IR");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 114,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 2, "IT" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 115,
                column: "CountryIso",
                value: "JE");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 116,
                column: "CountryIso",
                value: "JM");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 117,
                column: "CountryIso",
                value: "JO");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 118,
                column: "CountryIso",
                value: "JP");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 119,
                column: "CountryIso",
                value: "KE");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 120,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 1, "KG" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 121,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 1, "KH" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 122,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 1, "KI" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 123,
                column: "CountryIso",
                value: "KM");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 124,
                column: "CountryIso",
                value: "KN");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 125,
                column: "CountryIso",
                value: "KP");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 126,
                column: "CountryIso",
                value: "KR");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 127,
                column: "CountryIso",
                value: "KW");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 128,
                column: "CountryIso",
                value: "KY");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 129,
                column: "CountryIso",
                value: "KZ");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 130,
                column: "CountryIso",
                value: "LA");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 131,
                column: "CountryIso",
                value: "LB");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 132,
                column: "CountryIso",
                value: "LC");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 133,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 2, "LI" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 134,
                column: "CountryIso",
                value: "LK");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 135,
                column: "CountryIso",
                value: "LR");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 136,
                column: "CountryIso",
                value: "LS");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 137,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 2, "LT" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 138,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 2, "LU" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 139,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 2, "LV" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 140,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 1, "LY" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 141,
                column: "CountryIso",
                value: "MA");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 142,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 2, "MC" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 143,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 2, "MD" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 144,
                column: "CountryIso",
                value: "ME");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 145,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 1, "MF" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 146,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 1, "MG" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 147,
                column: "CountryIso",
                value: "MH");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 148,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 2, "MK" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 149,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 1, "ML" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 150,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 1, "MM" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 151,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 1, "MN" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 152,
                column: "CountryIso",
                value: "MO");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 153,
                column: "CountryIso",
                value: "MP");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 154,
                column: "CountryIso",
                value: "MQ");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 155,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 1, "MR" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 156,
                column: "CountryIso",
                value: "MS");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 157,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 2, "MT" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 158,
                column: "CountryIso",
                value: "MU");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 159,
                column: "CountryIso",
                value: "MV");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 160,
                column: "CountryIso",
                value: "MW");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 161,
                column: "CountryIso",
                value: "MX");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 162,
                column: "CountryIso",
                value: "MY");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 163,
                column: "CountryIso",
                value: "MZ");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 164,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 1, "NA" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 165,
                column: "CountryIso",
                value: "NC");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 166,
                column: "CountryIso",
                value: "NE");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 167,
                column: "CountryIso",
                value: "NF");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 168,
                column: "CountryIso",
                value: "NG");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 169,
                column: "CountryIso",
                value: "NI");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 170,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 2, "NL" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 171,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 2, "NO" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 172,
                column: "CountryIso",
                value: "NP");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 173,
                column: "CountryIso",
                value: "NR");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 174,
                column: "CountryIso",
                value: "NU");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 175,
                column: "CountryIso",
                value: "NZ");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 176,
                column: "CountryIso",
                value: "OM");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 177,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 1, "PA" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 178,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 1, "PE" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 179,
                column: "CountryIso",
                value: "PF");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 180,
                column: "CountryIso",
                value: "PG");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 181,
                column: "CountryIso",
                value: "PH");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 182,
                column: "CountryIso",
                value: "PK");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 183,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 2, "PL" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 184,
                column: "CountryIso",
                value: "PM");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 185,
                column: "CountryIso",
                value: "PN");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 186,
                column: "CountryIso",
                value: "PR");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 187,
                column: "CountryIso",
                value: "PS");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 188,
                column: "CountryIso",
                value: "PT");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 189,
                column: "CountryIso",
                value: "PW");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 190,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 1, "PY" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 191,
                column: "CountryIso",
                value: "QA");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 192,
                column: "CountryIso",
                value: "RE");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 193,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 2, "RO" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 194,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 2, "RS" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 195,
                column: "CountryIso",
                value: "RU");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 196,
                column: "CountryIso",
                value: "RW");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 197,
                column: "CountryIso",
                value: "SA");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 198,
                column: "CountryIso",
                value: "SB");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 199,
                column: "CountryIso",
                value: "SC");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 200,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 1, "SD" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 201,
                column: "CountryIso",
                value: "SE");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 202,
                column: "CountryIso",
                value: "SG");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 203,
                column: "CountryIso",
                value: "SH");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 204,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 2, "SI" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 205,
                column: "CountryIso",
                value: "SJ");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 206,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 2, "SK" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 207,
                column: "CountryIso",
                value: "SL");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 208,
                column: "CountryIso",
                value: "SM");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 209,
                column: "CountryIso",
                value: "SN");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 210,
                column: "CountryIso",
                value: "SO");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 211,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 1, "SR" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 212,
                column: "CountryIso",
                value: "SS");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 213,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 1, "ST" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 214,
                column: "CountryIso",
                value: "SV");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 215,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 1, "SX" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 216,
                column: "CountryIso",
                value: "SY");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 217,
                column: "CountryIso",
                value: "SZ");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 218,
                column: "CountryIso",
                value: "TC");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 219,
                column: "CountryIso",
                value: "TD");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 220,
                column: "CountryIso",
                value: "TF");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 221,
                column: "CountryIso",
                value: "TG");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 222,
                column: "CountryIso",
                value: "TH");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 223,
                column: "CountryIso",
                value: "TJ");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 224,
                column: "CountryIso",
                value: "TK");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 225,
                column: "CountryIso",
                value: "TL");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 226,
                column: "CountryIso",
                value: "TM");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 227,
                column: "CountryIso",
                value: "TN");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 228,
                column: "CountryIso",
                value: "TO");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 229,
                column: "CountryIso",
                value: "TR");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 230,
                column: "CountryIso",
                value: "TT");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 231,
                column: "CountryIso",
                value: "TV");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 232,
                column: "CountryIso",
                value: "TW");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 233,
                column: "CountryIso",
                value: "TZ");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 234,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 2, "UA" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 235,
                column: "CountryIso",
                value: "UG");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 236,
                column: "CountryIso",
                value: "UM");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 237,
                column: "CountryIso",
                value: "US");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 238,
                column: "CountryIso",
                value: "UY");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 239,
                column: "CountryIso",
                value: "UZ");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 240,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 2, "VA" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 241,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 1, "VC" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 242,
                column: "CountryIso",
                value: "VE");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 243,
                column: "CountryIso",
                value: "VG");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 244,
                column: "CountryIso",
                value: "VI");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 245,
                column: "CountryIso",
                value: "VN");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 246,
                column: "CountryIso",
                value: "VU");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 247,
                columns: new[] { "CalculatorSettingId", "CountryIso" },
                values: new object[] { 1, "WF" });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 248,
                column: "CountryIso",
                value: "WS");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 249,
                column: "CountryIso",
                value: "YE");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 250,
                column: "CountryIso",
                value: "YT");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 251,
                column: "CountryIso",
                value: "ZA");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 252,
                column: "CountryIso",
                value: "ZM");

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Calculators",
                keyColumn: "CalculatorId",
                keyValue: 253,
                column: "CountryIso",
                value: "ZW");

            migrationBuilder.InsertData(
                schema: "Calculator",
                table: "Calculators",
                columns: new[] { "CalculatorId", "CalculatorSettingId", "CountryIso" },
                values: new object[,]
                {
                    { 113, 2, "IS" },
                    { 88, 1, "GL" },
                    { 24, 2, "BE" },
                    { 34, 1, "BQ" },
                    { 49, 1, "CK" },
                    { 54, 1, "CR" },
                    { 57, 1, "CW" },
                    { 59, 2, "CY" }
                });

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Settings",
                keyColumn: "CalculatorSettingId",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2018, 7, 16, 19, 37, 44, 583, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Settings",
                keyColumn: "CalculatorSettingId",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2018, 7, 16, 19, 37, 44, 583, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Settings",
                keyColumn: "CalculatorSettingId",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2018, 7, 16, 19, 37, 44, 584, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Settings",
                keyColumn: "CalculatorSettingId",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2018, 7, 16, 19, 37, 44, 584, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Settings",
                keyColumn: "CalculatorSettingId",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2018, 7, 16, 19, 37, 44, 584, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "Calculator",
                table: "Settings",
                keyColumn: "CalculatorSettingId",
                keyValue: 6,
                column: "CreationTime",
                value: new DateTime(2018, 7, 16, 19, 37, 44, 584, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "AED",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local), new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "ARS",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local), new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "AUD",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local), new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "AZN",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local), new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "BBD",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local), new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "BDT",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local), new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "BGN",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local), new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "BHD",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local), new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "BMD",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local), new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "BOB",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local), new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "BRL",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local), new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "BYR",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local), new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "BZD",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local), new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "CAD",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local), new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "CHF",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local), new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "CLP",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local), new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "CNY",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local), new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "COP",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local), new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "CRC",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local), new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "CZK",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local), new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "DKK",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local), new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "DOP",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local), new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "EGP",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local), new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "EUR",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local), new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "GBP",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local), new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "GIP",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local), new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "GTQ",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local), new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "HKD",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local), new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "HNL",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local), new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "HRK",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local), new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "HUF",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local), new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "IDR",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local), new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "ILS",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local), new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "INR",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local), new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "JMD",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local), new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "JOD",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local), new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "JPY",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local), new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "KHR",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local), new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "KRW",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local), new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "KWD",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local), new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "KZT",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local), new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "LKR",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local), new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "LTL",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local), new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "LVL",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local), new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "MDL",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local), new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "MVR",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local), new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "MXN",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local), new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "MYR",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local), new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "NIO",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local), new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "NOK",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local), new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "NZD",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local), new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "OMR",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local), new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "PAB",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local), new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "PEN",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local), new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "PHP",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local), new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "PKR",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local), new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "PLN",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local), new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "PYG",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local), new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "QAR",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local), new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "ROL",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local), new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "RON",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local), new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "RUB",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local), new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "SAR",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local), new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "SEK",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local), new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "SGD",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local), new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "THB",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local), new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "TRY",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local), new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "TWD",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local), new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "UAH",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local), new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "USD",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local), new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "VEF",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local), new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Currency",
                keyColumn: "Iso",
                keyValue: "ZAR",
                columns: new[] { "CreationTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local), new DateTime(2018, 7, 16, 19, 37, 44, 581, DateTimeKind.Local) });
        }
    }
}
