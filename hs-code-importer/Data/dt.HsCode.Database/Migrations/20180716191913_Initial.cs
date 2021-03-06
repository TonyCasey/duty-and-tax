﻿using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace dt.HsCode.Database.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "HsCode");

            migrationBuilder.EnsureSchema(
                name: "Lookup");

            migrationBuilder.CreateTable(
                name: "Chapters",
                schema: "HsCode",
                columns: table => new
                {
                    ChapterId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chapters", x => x.ChapterId);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                schema: "Lookup",
                columns: table => new
                {
                    Iso = table.Column<string>(maxLength: 2, nullable: false),
                    CountryName = table.Column<string>(nullable: true),
                    RegionId = table.Column<int>(nullable: true),
                    CountryPrintableName = table.Column<string>(nullable: true),
                    Iso3 = table.Column<string>(nullable: true),
                    NumCode = table.Column<short>(nullable: true),
                    PostalCodeNeeded = table.Column<bool>(nullable: false),
                    PrimaryLanguage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Iso);
                });

            migrationBuilder.CreateTable(
                name: "Currency",
                schema: "Lookup",
                columns: table => new
                {
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreationUser = table.Column<string>(maxLength: 250, nullable: false),
                    LastUpdateTime = table.Column<DateTime>(nullable: true),
                    LastUpdateUser = table.Column<string>(maxLength: 250, nullable: true),
                    Iso = table.Column<string>(maxLength: 3, nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    CurrencyNumericCode = table.Column<string>(nullable: true),
                    NonNullableDate = table.Column<DateTime>(nullable: false),
                    Symbol = table.Column<string>(nullable: true),
                    CurrencyName = table.Column<string>(nullable: true),
                    Exponent = table.Column<int>(nullable: false),
                    SymbolAfterPrice = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currency", x => x.Iso);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                schema: "HsCode",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ChapterId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                    table.ForeignKey(
                        name: "FK_Categories_Chapters_ChapterId",
                        column: x => x.ChapterId,
                        principalSchema: "HsCode",
                        principalTable: "Chapters",
                        principalColumn: "ChapterId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    SubCategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.SubCategoryId);
                    table.ForeignKey(
                        name: "FK_SubCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalSchema: "HsCode",
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "Countries",
                columns: new[] { "Iso", "CountryName", "CountryPrintableName", "Iso3", "NumCode", "PostalCodeNeeded", "PrimaryLanguage", "RegionId" },
                values: new object[,]
                {
                    { "AD", "ANDORRA", "Andorra", "AND", (short)20, false, "en", 2 },
                    { "MZ", "MOZAMBIQUE", "Mozambique", "MOZ", (short)508, false, "en", 5 },
                    { "NC", "NEW CALEDONIA", "New Caledonia", "NCL", (short)540, false, "en", 5 },
                    { "NE", "NIGER", "Niger", "NER", (short)562, false, "en", 5 },
                    { "NF", "NORFOLK ISLAND", "Norfolk Island", "NFK", (short)574, false, "en", 5 },
                    { "NG", "NIGERIA", "Nigeria", "NGA", (short)566, false, "en", 5 },
                    { "NI", "NICARAGUA", "Nicaragua", "NIC", (short)558, false, "en", 5 },
                    { "NL", "NETHERLANDS", "Netherlands", "NLD", (short)528, false, "nl", 2 },
                    { "NO", "NORWAY", "Norway", "NOR", (short)578, false, "en", 2 },
                    { "NP", "NEPAL", "Nepal", "NPL", (short)524, false, "en", 5 },
                    { "NR", "NAURU", "Nauru", "NRU", (short)520, false, "en", 5 },
                    { "NU", "NIUE", "Niue", "NIU", (short)570, false, "en", 5 },
                    { "NZ", "NEW ZEALAND", "New Zealand", "NZL", (short)554, false, "en", 5 },
                    { "OM", "OMAN", "Oman", "OMN", (short)512, false, "en", 5 },
                    { "PA", "PANAMA", "Panama", "PAN", (short)591, false, "en", 5 },
                    { "PE", "PERU", "Peru", "PER", (short)604, false, "en", 5 },
                    { "PF", "FRENCH POLYNESIA", "French Polynesia", "PYF", (short)258, false, "en", 5 },
                    { "PG", "PAPUA NEW GUINEA", "Papua New Guinea", "PNG", (short)598, false, "en", 5 },
                    { "PH", "PHILIPPINES", "Philippines", "PHL", (short)608, false, "en", 5 },
                    { "PK", "PAKISTAN", "Pakistan", "PAK", (short)586, false, "en", 5 },
                    { "PL", "POLAND", "Poland", "POL", (short)616, false, "pl", 2 },
                    { "PM", "SAINT PIERRE AND MIQUELON", "Saint Pierre and Miquelon", "SPM", (short)666, false, "en", 5 },
                    { "PN", "PITCAIRN", "Pitcairn", "PCN", (short)612, false, "en", 5 },
                    { "PR", "PUERTO RICO", "Puerto Rico", "PRI", (short)630, false, "en", 5 },
                    { "PS", "PALESTINIAN TERRITORY, OCCUPIED", "Palestinian Territory, Occupied", null, null, false, "en", 5 },
                    { "PT", "PORTUGAL", "Portugal", "PRT", (short)620, false, "en", 5 },
                    { "PW", "PALAU", "Palau", "PLW", (short)585, false, "en", 5 },
                    { "PY", "PARAGUAY", "Paraguay", "PRY", (short)600, false, "en", 5 },
                    { "MY", "MALAYSIA", "Malaysia", "MYS", (short)458, false, "en", 5 },
                    { "MX", "MEXICO", "Mexico", "MEX", (short)484, false, "en", 5 },
                    { "MW", "MALAWI", "Malawi", "MWI", (short)454, false, "en", 5 },
                    { "MV", "MALDIVES", "Maldives", "MDV", (short)462, false, "en", 5 },
                    { "LB", "LEBANON", "Lebanon", "LBN", (short)422, false, "en", 5 },
                    { "LC", "SAINT LUCIA", "Saint Lucia", "LCA", (short)662, false, "en", 5 },
                    { "LI", "LIECHTENSTEIN", "Liechtenstein", "LIE", (short)438, false, "en", 2 },
                    { "LK", "SRI LANKA", "Sri Lanka", "LKA", (short)144, false, "en", 5 },
                    { "LR", "LIBERIA", "Liberia", "LBR", (short)430, false, "en", 5 },
                    { "LS", "LESOTHO", "Lesotho", "LSO", (short)426, false, "en", 5 },
                    { "LT", "LITHUANIA", "Lithuania", "LTU", (short)440, false, "en", 2 },
                    { "LU", "LUXEMBOURG", "Luxembourg", "LUX", (short)442, false, "en", 2 },
                    { "LV", "LATVIA", "Latvia", "LVA", (short)428, false, "en", 2 },
                    { "LY", "LIBYAN ARAB JAMAHIRIYA", "Libyan Arab Jamahiriya", "LBY", (short)434, false, "en", 5 },
                    { "MA", "MOROCCO", "Morocco", "MAR", (short)504, false, "en", 5 },
                    { "MC", "MONACO", "Monaco", "MCO", (short)492, false, "en", 2 },
                    { "MD", "MOLDOVA, REPUBLIC OF", "Moldova, Republic of", "MDA", (short)498, false, "en", 2 },
                    { "QA", "QATAR", "Qatar", "QAT", (short)634, false, "en", 5 },
                    { "ME", "MONTENEGRO", "Montenegro", null, null, false, "en", 2 },
                    { "MG", "MADAGASCAR", "Madagascar", "MDG", (short)450, false, "en", 5 },
                    { "MH", "MARSHALL ISLANDS", "Marshall Islands", "MHL", (short)584, false, "en", 5 },
                    { "MK", "MACEDONIA, THE FORMER YUGOSLAV REPUBLIC OF", "Macedonia, the Former Yugoslav Republic of", "MKD", (short)807, false, "en", 2 },
                    { "ML", "MALI", "Mali", "MLI", (short)466, false, "en", 5 },
                    { "MM", "MYANMAR", "Myanmar", "MMR", (short)104, false, "en", 5 },
                    { "MN", "MONGOLIA", "Mongolia", "MNG", (short)496, false, "en", 5 },
                    { "MO", "MACAO", "Macao", "MAC", (short)446, false, "en", 5 },
                    { "MP", "NORTHERN MARIANA ISLANDS", "Northern Mariana Islands", "MNP", (short)580, false, "en", 5 },
                    { "MQ", "MARTINIQUE", "Martinique", "MTQ", (short)474, false, "en", 5 },
                    { "MR", "MAURITANIA", "Mauritania", "MRT", (short)478, false, "en", 5 },
                    { "MS", "MONTSERRAT", "Montserrat", "MSR", (short)500, false, "en", 5 },
                    { "MT", "MALTA", "Malta", "MLT", (short)470, false, "en", 2 },
                    { "MU", "MAURITIUS", "Mauritius", "MUS", (short)480, false, "en", 5 },
                    { "MF", "SAINT MARTIN (FRENCH PART)", "Saint Martin (French Part)", null, null, false, "en", 5 },
                    { "LA", "LAO PEOPLE'S DEMOCRATIC REPUBLIC", "Lao People's Democratic Republic", "LAO", (short)418, false, "en", 5 },
                    { "RE", "REUNION", "Reunion", "REU", (short)638, false, "en", 5 },
                    { "RS", "SERBIA", "Serbia", null, null, false, "en", 2 },
                    { "TN", "TUNISIA", "Tunisia", "TUN", (short)788, false, "en", 5 },
                    { "TO", "TONGA", "Tonga", "TON", (short)776, false, "en", 5 },
                    { "TR", "TURKEY", "Turkey", "TUR", (short)792, false, "en", 5 },
                    { "TT", "TRINIDAD AND TOBAGO", "Trinidad and Tobago", "TTO", (short)780, false, "en", 5 },
                    { "TV", "TUVALU", "Tuvalu", "TUV", (short)798, false, "en", 5 },
                    { "TW", "TAIWAN, PROVINCE OF CHINA", "Taiwan, Province of China", "TWN", (short)158, false, "en", 5 },
                    { "TZ", "TANZANIA, UNITED REPUBLIC OF", "Tanzania, United Republic of", "TZA", (short)834, false, "en", 5 },
                    { "UA", "UKRAINE", "Ukraine", "UKR", (short)804, false, "en", 2 },
                    { "UG", "UGANDA", "Uganda", "UGA", (short)800, false, "en", 5 },
                    { "UM", "UNITED STATES MINOR OUTLYING ISLANDS", "United States Minor Outlying Islands", null, null, false, "en", 1 },
                    { "US", "UNITED STATES", "United States", "USA", (short)840, false, "en", 1 },
                    { "UY", "URUGUAY", "Uruguay", "URY", (short)858, false, "en", 5 },
                    { "UZ", "UZBEKISTAN", "Uzbekistan", "UZB", (short)860, false, "en", 5 },
                    { "VA", "HOLY SEE (VATICAN CITY STATE)", "Holy See (Vatican City State)", "VAT", (short)336, false, "en", 2 },
                    { "VC", "SAINT VINCENT AND THE GRENADINES", "Saint Vincent and the Grenadines", "VCT", (short)670, false, "en", 5 },
                    { "VE", "VENEZUELA", "Venezuela", "VEN", (short)862, false, "en", 5 },
                    { "VG", "VIRGIN ISLANDS, BRITISH", "Virgin Islands, British", "VGB", (short)92, false, "en", 5 },
                    { "VI", "VIRGIN ISLANDS, U.S.", "Virgin Islands, U.s.", "VIR", (short)850, false, "en", 5 },
                    { "VN", "VIET NAM", "Viet Nam", "VNM", (short)704, false, "en", 5 },
                    { "VU", "VANUATU", "Vanuatu", "VUT", (short)548, false, "en", 5 },
                    { "WF", "WALLIS AND FUTUNA", "Wallis and Futuna", "WLF", (short)876, false, "en", 5 },
                    { "WS", "SAMOA", "Samoa", "WSM", (short)882, false, "en", 5 },
                    { "YE", "YEMEN", "Yemen", "YEM", (short)887, false, "en", 5 },
                    { "YT", "MAYOTTE", "Mayotte", null, null, false, "en", 5 },
                    { "ZA", "SOUTH AFRICA", "South Africa", "ZAF", (short)710, false, "en", 5 },
                    { "ZM", "ZAMBIA", "Zambia", "ZMB", (short)894, false, "en", 5 },
                    { "ZW", "ZIMBABWE", "Zimbabwe", "ZWE", (short)716, false, "en", 5 },
                    { "TM", "TURKMENISTAN", "Turkmenistan", "TKM", (short)795, false, "en", 5 },
                    { "TL", "TIMOR-LESTE", "Timor-Leste", null, null, false, "en", 5 },
                    { "TK", "TOKELAU", "Tokelau", "TKL", (short)772, false, "en", 5 },
                    { "TJ", "TAJIKISTAN", "Tajikistan", "TJK", (short)762, false, "en", 5 },
                    { "RU", "RUSSIAN FEDERATION", "Russian Federation", "RUS", (short)643, false, "en", 5 },
                    { "RW", "RWANDA", "Rwanda", "RWA", (short)646, false, "en", 5 },
                    { "SA", "SAUDI ARABIA", "Saudi Arabia", "SAU", (short)682, false, "en", 5 },
                    { "SB", "SOLOMON ISLANDS", "Solomon Islands", "SLB", (short)90, false, "en", 5 },
                    { "SC", "SEYCHELLES", "Seychelles", "SYC", (short)690, false, "en", 5 },
                    { "SD", "SUDAN", "Sudan", "SDN", (short)736, false, "en", 5 },
                    { "SE", "SWEDEN", "Sweden", "SWE", (short)752, false, "en", 2 },
                    { "SG", "SINGAPORE", "Singapore", "SGP", (short)702, false, "en", 5 },
                    { "SH", "SAINT HELENA", "Saint Helena", "SHN", (short)654, false, "en", 5 },
                    { "SI", "SLOVENIA", "Slovenia", "SVN", (short)705, false, "en", 2 },
                    { "SJ", "SVALBARD AND JAN MAYEN", "Svalbard and Jan Mayen", "SJM", (short)744, false, "en", 5 },
                    { "SK", "SLOVAKIA", "Slovakia", "SVK", (short)703, false, "en", 2 },
                    { "SL", "SIERRA LEONE", "Sierra Leone", "SLE", (short)694, false, "en", 5 },
                    { "RO", "ROMANIA", "Romania", "ROU", (short)642, false, "en", 2 },
                    { "SM", "SAN MARINO", "San Marino", "SMR", (short)674, false, "en", 2 },
                    { "SO", "SOMALIA", "Somalia", "SOM", (short)706, false, "en", 5 },
                    { "SR", "SURINAME", "Suriname", "SUR", (short)740, false, "en", 5 },
                    { "SS", "SOUTH SUDAN", "South Sudan", null, null, false, "en", 5 },
                    { "ST", "SAO TOME AND PRINCIPE", "Sao Tome and Principe", "STP", (short)678, false, "en", 5 },
                    { "SV", "EL SALVADOR", "El Salvador", "SLV", (short)222, false, "en", 5 },
                    { "SX", "SINT MAARTEN (DUTCH PART)", "Sint Maarten (Dutch Part)", null, null, false, "en", 5 },
                    { "SY", "SYRIAN ARAB REPUBLIC", "Syrian Arab Republic", "SYR", (short)760, false, "en", 5 },
                    { "SZ", "SWAZILAND", "Swaziland", "SWZ", (short)748, false, "en", 5 },
                    { "TC", "TURKS AND CAICOS ISLANDS", "Turks and Caicos Islands", "TCA", (short)796, false, "en", 5 },
                    { "TD", "CHAD", "Chad", "TCD", (short)148, false, "en", 5 },
                    { "TF", "FRENCH SOUTHERN TERRITORIES", "French Southern Territories", null, null, false, "en", 5 },
                    { "TG", "TOGO", "Togo", "TGO", (short)768, false, "en", 5 },
                    { "TH", "THAILAND", "Thailand", "THA", (short)764, false, "en", 5 },
                    { "SN", "SENEGAL", "Senegal", "SEN", (short)686, false, "en", 5 },
                    { "KZ", "KAZAKHSTAN", "Kazakhstan", "KAZ", (short)398, false, "en", 5 },
                    { "NA", "NAMIBIA", "Namibia", "NAM", (short)516, false, "en", 5 },
                    { "KW", "KUWAIT", "Kuwait", "KWT", (short)414, false, "en", 5 },
                    { "BT", "BHUTAN", "Bhutan", "BTN", (short)64, false, "en", 5 },
                    { "BV", "BOUVET ISLAND", "Bouvet Island", null, null, false, "en", 5 },
                    { "BW", "BOTSWANA", "Botswana", "BWA", (short)72, false, "en", 5 },
                    { "BY", "BELARUS", "Belarus", "BLR", (short)112, false, "en", 2 },
                    { "BZ", "BELIZE", "Belize", "BLZ", (short)84, false, "en", 5 },
                    { "CA", "CANADA", "Canada", "CAN", (short)124, true, "en", 3 },
                    { "CC", "COCOS (KEELING) ISLANDS", "Cocos (Keeling) Islands", null, null, false, "en", 5 },
                    { "CD", "CONGO, THE DEMOCRATIC REPUBLIC OF THE", "Congo, the Democratic Republic of the", "COD", (short)180, false, "en", 5 },
                    { "CF", "CENTRAL AFRICAN REPUBLIC", "Central African Republic", "CAF", (short)140, false, "en", 5 },
                    { "CG", "CONGO", "Congo", "COG", (short)178, false, "en", 5 },
                    { "CH", "SWITZERLAND", "Switzerland", "CHE", (short)756, false, "en", 2 },
                    { "CI", "COTE D'IVOIRE", "Cote D'Ivoire", "CIV", (short)384, false, "en", 5 },
                    { "CK", "COOK ISLANDS", "Cook Islands", "COK", (short)184, false, "en", 5 },
                    { "BS", "BAHAMAS", "Bahamas", "BHS", (short)44, false, "en", 5 },
                    { "CL", "CHILE", "Chile", "CHL", (short)152, false, "en", 5 },
                    { "CN", "CHINA", "China", "CHN", (short)156, false, "en", 5 },
                    { "CO", "COLOMBIA", "Colombia", "COL", (short)170, false, "en", 5 },
                    { "CR", "COSTA RICA", "Costa Rica", "CRI", (short)188, false, "en", 5 },
                    { "CS", "SERBIA AND MONTENEGRO", "Serbia and Montenegro", null, null, false, "en", 5 },
                    { "CU", "CUBA", "Cuba", "CUB", (short)192, false, "en", 5 },
                    { "CV", "CAPE VERDE", "Cape Verde", "CPV", (short)132, false, "en", 5 },
                    { "CW", "CURACAO", "Curacao", null, null, false, "en", 5 },
                    { "CX", "CHRISTMAS ISLAND", "Christmas Island", null, null, false, "en", 5 },
                    { "CY", "CYPRUS", "Cyprus", "CYP", (short)196, false, "en", 2 },
                    { "CZ", "CZECH REPUBLIC", "Czech Republic", "CZE", (short)203, false, "en", 2 },
                    { "DE", "GERMANY", "Germany", "DEU", (short)276, false, "de", 2 },
                    { "DJ", "DJIBOUTI", "Djibouti", "DJI", (short)262, false, "en", 5 },
                    { "DK", "DENMARK", "Denmark", "DNK", (short)208, false, "en", 2 },
                    { "CM", "CAMEROON", "Cameroon", "CMR", (short)120, false, "en", 5 },
                    { "DM", "DOMINICA", "Dominica", "DMA", (short)212, false, "en", 5 },
                    { "BR", "BRAZIL", "Brazil", "BRA", (short)76, false, "en", 5 },
                    { "BO", "BOLIVIA", "Bolivia", "BOL", (short)68, false, "en", 5 },
                    { "AE", "UNITED ARAB EMIRATES", "United Arab Emirates", "ARE", (short)784, false, "en", 5 },
                    { "AF", "AFGHANISTAN", "Afghanistan", "AFG", (short)4, false, "en", 5 },
                    { "AG", "ANTIGUA AND BARBUDA", "Antigua and Barbuda", "ATG", (short)28, false, "en", 5 },
                    { "AI", "ANGUILLA", "Anguilla", "AIA", (short)660, false, "en", 5 },
                    { "AL", "ALBANIA", "Albania", "ALB", (short)8, false, "en", 2 },
                    { "AM", "ARMENIA", "Armenia", "ARM", (short)51, false, "en", 5 },
                    { "AN", "NETHERLANDS ANTILLES", "Netherlands Antilles", "ANT", (short)530, false, "en", 5 },
                    { "AO", "ANGOLA", "Angola", "AGO", (short)24, false, "en", 5 },
                    { "AQ", "ANTARCTICA", "Antarctica", null, null, false, "en", 5 },
                    { "AR", "ARGENTINA", "Argentina", "ARG", (short)32, false, "en", 5 },
                    { "AS", "AMERICAN SAMOA", "American Samoa", "ASM", (short)16, false, "en", 5 },
                    { "AT", "AUSTRIA", "Austria", "AUT", (short)40, false, "de", 2 },
                    { "AU", "AUSTRALIA", "Australia", "AUS", (short)36, false, "en", 4 },
                    { "BQ", "BONAIRE, SINT EUSTATIUS AND SABA", "Bonaire, Sint Eustatius and Saba", null, null, false, "en", 5 },
                    { "AW", "ARUBA", "Aruba", "ABW", (short)533, false, "en", 5 },
                    { "AZ", "AZERBAIJAN", "Azerbaijan", "AZE", (short)31, false, "en", 5 },
                    { "BA", "BOSNIA AND HERZEGOVINA", "Bosnia and Herzegovina", "BIH", (short)70, false, "en", 2 },
                    { "BB", "BARBADOS", "Barbados", "BRB", (short)52, false, "en", 5 },
                    { "BD", "BANGLADESH", "Bangladesh", "BGD", (short)50, false, "en", 5 },
                    { "BE", "BELGIUM", "Belgium", "BEL", (short)56, false, "en", 2 },
                    { "BF", "BURKINA FASO", "Burkina Faso", "BFA", (short)854, false, "en", 5 },
                    { "BG", "BULGARIA", "Bulgaria", "BGR", (short)100, false, "en", 2 },
                    { "BH", "BAHRAIN", "Bahrain", "BHR", (short)48, false, "en", 5 },
                    { "BI", "BURUNDI", "Burundi", "BDI", (short)108, false, "en", 5 },
                    { "BJ", "BENIN", "Benin", "BEN", (short)204, false, "en", 5 },
                    { "BL", "SAINT BARTHÉLEMY", "Saint Barthelemy", null, null, false, "en", 5 },
                    { "KY", "CAYMAN ISLANDS", "Cayman Islands", "CYM", (short)136, false, "en", 5 },
                    { "BN", "BRUNEI DARUSSALAM", "Brunei Darussalam", "BRN", (short)96, false, "en", 5 },
                    { "AX", "ALAND ISLANDS", "Aland Islands", null, null, false, "en", 2 },
                    { "DO", "DOMINICAN REPUBLIC", "Dominican Republic", "DOM", (short)214, false, "en", 5 },
                    { "BM", "BERMUDA", "Bermuda", "BMU", (short)60, false, "en", 5 },
                    { "EC", "ECUADOR", "Ecuador", "ECU", (short)218, false, "en", 5 },
                    { "HK", "HONG KONG", "Hong Kong", "HKG", (short)344, false, "en", 5 },
                    { "HM", "HEARD ISLAND AND MCDONALD ISLANDS", "Heard Island and Mcdonald Islands", null, null, false, "en", 5 },
                    { "HN", "HONDURAS", "Honduras", "HND", (short)340, false, "en", 5 },
                    { "HR", "CROATIA", "Croatia", "HRV", (short)191, false, "en", 2 },
                    { "HT", "HAITI", "Haiti", "HTI", (short)332, false, "en", 5 },
                    { "HU", "HUNGARY", "Hungary", "HUN", (short)348, false, "en", 2 },
                    { "ID", "INDONESIA", "Indonesia", "IDN", (short)360, false, "en", 5 },
                    { "IE", "IRELAND", "Ireland", "IRL", (short)372, false, "en", 2 },
                    { "IL", "ISRAEL", "Israel", "ISR", (short)376, false, "en", 5 },
                    { "IM", "ISLE OF MAN", "Isle of Man", null, null, false, "en", 2 },
                    { "IN", "INDIA", "India", "IND", (short)356, false, "en", 5 },
                    { "IO", "BRITISH INDIAN OCEAN TERRITORY", "British Indian Ocean Territory", null, null, false, "en", 5 },
                    { "IQ", "IRAQ", "Iraq", "IRQ", (short)368, false, "en", 5 },
                    { "GY", "GUYANA", "Guyana", "GUY", (short)328, false, "en", 5 },
                    { "IR", "IRAN, ISLAMIC REPUBLIC OF", "Iran, Islamic Republic of", "IRN", (short)364, false, "en", 5 },
                    { "JE", "JERSEY", "Jersey", null, null, false, "en", 2 },
                    { "JM", "JAMAICA", "Jamaica", "JAM", (short)388, false, "en", 5 },
                    { "JO", "JORDAN", "Jordan", "JOR", (short)400, false, "en", 5 },
                    { "JP", "JAPAN", "Japan", "JPN", (short)392, false, "en", 5 },
                    { "KE", "KENYA", "Kenya", "KEN", (short)404, false, "en", 5 },
                    { "KG", "KYRGYZSTAN", "Kyrgyzstan", "KGZ", (short)417, false, "en", 5 },
                    { "KH", "CAMBODIA", "Cambodia", "KHM", (short)116, false, "en", 5 },
                    { "KI", "KIRIBATI", "Kiribati", "KIR", (short)296, false, "en", 5 },
                    { "KM", "COMOROS", "Comoros", "COM", (short)174, false, "en", 5 },
                    { "KN", "SAINT KITTS AND NEVIS", "Saint Kitts and Nevis", "KNA", (short)659, false, "en", 5 },
                    { "KP", "KOREA, DEMOCRATIC PEOPLE'S REPUBLIC OF", "Korea, Democratic People's Republic of", "PRK", (short)408, false, "en", 5 },
                    { "KR", "KOREA, REPUBLIC OF", "Korea, Republic of", "KOR", (short)410, false, "en", 5 },
                    { "DZ", "ALGERIA", "Algeria", "DZA", (short)12, false, "en", 5 },
                    { "IT", "ITALY", "Italy", "ITA", (short)380, false, "it", 2 },
                    { "GW", "GUINEA-BISSAU", "Guinea-Bissau", "GNB", (short)624, false, "en", 5 },
                    { "IS", "ICELAND", "Iceland", "ISL", (short)352, false, "en", 2 },
                    { "GT", "GUATEMALA", "Guatemala", "GTM", (short)320, false, "en", 5 },
                    { "EE", "ESTONIA", "Estonia", "EST", (short)233, false, "en", 2 },
                    { "GU", "GUAM", "Guam", "GUM", (short)316, false, "en", 5 },
                    { "EG", "EGYPT", "Egypt", "EGY", (short)818, false, "en", 5 },
                    { "EH", "WESTERN SAHARA", "Western Sahara", "ESH", (short)732, false, "en", 5 },
                    { "ER", "ERITREA", "Eritrea", "ERI", (short)232, false, "en", 5 },
                    { "ES", "SPAIN", "Spain", "ESP", (short)724, false, "es", 2 },
                    { "ET", "ETHIOPIA", "Ethiopia", "ETH", (short)231, false, "en", 5 },
                    { "FI", "FINLAND", "Finland", "FIN", (short)246, false, "en", 2 },
                    { "FK", "FALKLAND ISLANDS (MALVINAS)", "Falkland Islands (Malvinas)", "FLK", (short)238, false, "en", 5 },
                    { "FM", "MICRONESIA, FEDERATED STATES OF", "Micronesia, Federated States of", "FSM", (short)583, false, "en", 5 },
                    { "FO", "FAROE ISLANDS", "Faroe Islands", "FRO", (short)234, false, "en", 2 },
                    { "FR", "FRANCE", "France", "FRA", (short)250, false, "fr", 2 },
                    { "GA", "GABON", "Gabon", "GAB", (short)266, false, "en", 5 },
                    { "GB", "UNITED KINGDOM", "United Kingdom", "GBR", (short)826, false, "en", 2 },
                    { "FJ", "FIJI", "Fiji", "FJI", (short)242, false, "en", 5 },
                    { "GD", "GRENADA", "Grenada", "GRD", (short)308, false, "en", 5 },
                    { "GR", "GREECE", "Greece", "GRC", (short)300, false, "en", 2 },
                    { "GQ", "EQUATORIAL GUINEA", "Equatorial Guinea", "GNQ", (short)226, false, "en", 5 },
                    { "GP", "GUADELOUPE", "Guadeloupe", "GLP", (short)312, false, "en", 5 },
                    { "GS", "SOUTH GEORGIA AND THE SOUTH SANDWICH ISLANDS", "South Georgia and the South Sandwich Islands", null, null, false, "en", 5 },
                    { "GM", "GAMBIA", "Gambia", "GMB", (short)270, false, "en", 5 },
                    { "GL", "GREENLAND", "Greenland", "GRL", (short)304, false, "en", 5 },
                    { "GN", "GUINEA", "Guinea", "GIN", (short)324, false, "en", 5 },
                    { "GI", "GIBRALTAR", "Gibraltar", "GIB", (short)292, false, "en", 2 },
                    { "GH", "GHANA", "Ghana", "GHA", (short)288, false, "en", 5 },
                    { "GG", "GUERNSEY", "Guernsey", null, null, false, "en", 2 },
                    { "GF", "FRENCH GUIANA", "French Guiana", "GUF", (short)254, false, "en", 5 },
                    { "GE", "GEORGIA", "Georgia", "GEO", (short)268, false, "en", 5 }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "Currency",
                columns: new[] { "Iso", "Active", "CreationTime", "CreationUser", "CurrencyName", "CurrencyNumericCode", "Exponent", "LastUpdateTime", "LastUpdateUser", "NonNullableDate", "Symbol", "SymbolAfterPrice" },
                values: new object[,]
                {
                    { "KWD", true, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", "Kuwaiti dinar", "414", 3, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "د.ك", true },
                    { "KRW", true, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", "South Korean won", "410", 0, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "W", false },
                    { "KHR", true, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", "Cambodian riel", "116", 2, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CR", false },
                    { "JPY", true, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", "Japanese yen", "392", 0, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "¥", false },
                    { "JOD", false, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", "Jordanian dinar", "400", 3, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "JD", false },
                    { "KZT", true, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", "Kazakhstani tenge", "398", 2, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "KZT", false },
                    { "JMD", true, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", "Jamaican dollar", "388", 2, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "J$", false }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "Currency",
                columns: new[] { "Iso", "Active", "CreationTime", "CreationUser", "CurrencyName", "CurrencyNumericCode", "Exponent", "LastUpdateTime", "LastUpdateUser", "NonNullableDate", "Symbol", "SymbolAfterPrice" },
                values: new object[,]
                {
                    { "HRK", true, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", "Croatian kuna", "191", 2, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "kn", true },
                    { "ILS", true, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", "Israeli new shekel", "376", 2, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "NIS", false },
                    { "IDR", true, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", "Indonesian rupiah", "360", 0, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rp", false },
                    { "HKD", true, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", "Hong Kong dollar", "344", 2, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "HK$", false },
                    { "HNL", true, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", "Honduran lempira", "340", 2, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "L", false },
                    { "GTQ", true, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", "Guatemalan quetzal", "320", 2, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Q", false },
                    { "LKR", true, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", "Sri Lankan rupee", "144", 2, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SLRs", false },
                    { "INR", true, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", "Indian rupee", "356", 2, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rs", false },
                    { "MDL", true, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", "Moldovan leu", "498", 2, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MDL", false },
                    { "TRY", true, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", "Turkish lira", "949", 2, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TL", false },
                    { "MXN", true, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", "Mexican peso", "484", 2, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mex$", false },
                    { "VEF", true, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", "Venezuelan bolívar", "937", 2, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bs.", false },
                    { "EGP", false, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", "Egyptian pound", "818", 2, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "£E", false },
                    { "UAH", true, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", "Ukrainian hryvnia", "980", 2, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "₴", false },
                    { "TWD", true, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", "New Taiwan dollar", "901", 2, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "NT$", false },
                    { "THB", true, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", "Thai baht", "764", 2, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "฿", false },
                    { "SGD", true, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", "Singapore dollar", "702", 2, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "$", false },
                    { "RUB", true, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", "Russian ruble", "643", 2, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "руб", false },
                    { "PYG", true, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", "Paraguayan guaraní", "600", 0, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gs", false },
                    { "PKR", true, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", "Pakistani rupee", "586", 2, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rs", false },
                    { "PHP", true, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", "Philippine peso", "608", 2, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "₱", false },
                    { "PEN", true, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", "Peruvian nuevo sol", "604", 2, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "S/.", false },
                    { "PAB", true, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", "Panamanian balboa", "590", 2, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "B", false },
                    { "OMR", false, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", "Omani rial", "512", 3, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "RO", false },
                    { "NIO", true, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", "Nicaraguan córdoba", "558", 2, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "C$", false },
                    { "MYR", true, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", "Malaysian ringgit", "458", 2, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "RM", false },
                    { "MVR", false, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", "Maldivian rufiyaa", "462", 2, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rf", false },
                    { "DOP", true, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", "Dominican peso", "214", 2, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "RD$", false },
                    { "CAD", true, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", "Canadian dollar", "124", 2, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CA$", false },
                    { "COP", true, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", "Colombian peso", "170", 2, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Col$", false },
                    { "NOK", true, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", "Norwegian krone", "578", 2, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "kr", false },
                    { "LVL", false, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", "Latvian lats", "428", 2, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ls", false },
                    { "LTL", true, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", "Lithuanian litas", "440", 2, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lt", false },
                    { "HUF", true, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", "Hungarian forint", "348", 2, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ft", true },
                    { "ZAR", true, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", "South African rand", "710", 2, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "R", false },
                    { "DKK", true, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", "Danish krone", "208", 2, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "kr", false },
                    { "NZD", true, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", "New Zealand dollar", "554", 2, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "NZ$", false },
                    { "CZK", true, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", "Czech koruna", "203", 2, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kč", true },
                    { "BGN", true, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", "Bulgarian lev", "975", 2, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "лв", true },
                    { "AUD", true, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", "Australian dollar", "36", 2, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AU$", false },
                    { "GBP", true, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", "Pound sterling", "826", 2, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "£", false },
                    { "USD", true, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", "United States dollar", "840", 2, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "$", false },
                    { "EUR", true, new DateTime(2018, 7, 16, 20, 19, 12, 566, DateTimeKind.Local), "Seed", "Euro", "978", 2, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "€", true },
                    { "GIP", true, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", "Gibraltar pound", "292", 2, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "£", false },
                    { "CHF", true, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", "Swiss franc", "756", 2, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CHF", false },
                    { "PLN", true, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", "Polish zloty", "985", 2, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "zł", true },
                    { "QAR", true, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", "Qatari riyal", "634", 2, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ر.ق", true },
                    { "RON", true, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", "Romanian new leu", "946", 2, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "lei", true },
                    { "CNY", true, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", "Chinese yuan", "156", 2, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Y", false },
                    { "CLP", true, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", "Chilean peso", "152", 0, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ch$", false },
                    { "BZD", true, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", "Belize dollar", "84", 2, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BZ$", false },
                    { "BYR", true, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", "Belarusian ruble", "974", 0, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BR", true },
                    { "BRL", true, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", "Brazilian real", "986", 2, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "R$", false },
                    { "BOB", true, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", "Boliviano", "68", 2, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "$b", false },
                    { "BMD", true, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", "Bermudian dollar", "60", 2, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bd$", false },
                    { "BHD", true, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", "Bahraini dinar", "48", 3, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ".د.ب", true },
                    { "BDT", false, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", "Bangladeshi taka", "50", 2, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tk", false },
                    { "BBD", true, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", "Barbados dollar", "52", 2, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "$", false },
                    { "AZN", true, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", "Azerbaijani manat", "944", 2, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ман", false },
                    { "ARS", true, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", "Argentine peso", "32", 2, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "$", false },
                    { "AED", true, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", "United Arab Emirates dirham", "784", 2, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "د.إ", true },
                    { "SEK", true, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", "Swedish krona/kronor", "752", 2, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "kr", false },
                    { "SAR", true, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", "Saudi riyal", "682", 2, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ر.س", true },
                    { "CRC", true, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", "Costa Rican colon", "188", 2, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "₡", false },
                    { "ROL", true, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", "Romanian leu", "642", 2, new DateTime(2018, 7, 16, 20, 19, 12, 567, DateTimeKind.Local), "Seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "lei", false }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_CategoryId",
                table: "SubCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ChapterId",
                schema: "HsCode",
                table: "Categories",
                column: "ChapterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubCategories");

            migrationBuilder.DropTable(
                name: "Countries",
                schema: "Lookup");

            migrationBuilder.DropTable(
                name: "Currency",
                schema: "Lookup");

            migrationBuilder.DropTable(
                name: "Categories",
                schema: "HsCode");

            migrationBuilder.DropTable(
                name: "Chapters",
                schema: "HsCode");
        }
    }
}
