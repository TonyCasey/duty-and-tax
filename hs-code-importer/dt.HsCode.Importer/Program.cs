using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using dt.HsCode.Database;
using dt.HsCode.Importer.Client;
using ExcelDataReader;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace dt.HsCode.Importer
{
    class Program
    {


        
        static void Main(string[] args)
        {
           var client = InitializeApiClient();

            DataSet dataSet = LoadExcel();

            List<HsCodeRequestDto> hsCodeRequestDtos = ParseDataSet(dataSet);
            
            SaveHsCodes(hsCodeRequestDtos, client);

            Console.Read();
        }

        
        private static DataSet LoadExcel()
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            DataSet result;

            using (var stream = File.Open(Path.GetRelativePath(".", "Excel\\hs-data.xls"), FileMode.Open, FileAccess.Read))
            {

                // Auto-detect format, supports:
                //  - Binary Excel files (2.0-2003 format; *.xls)
                //  - OpenXml Excel files (2007 format; *.xlsx)
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {

                    // Choose one of either 1 or 2:

                    // 1. Use the reader methods
                    do
                    {
                        while (reader.Read())
                        {
                            // reader.GetDouble(0);

                        }
                    } while (reader.NextResult());

                    // 2. Use the AsDataSet extension method
                    result = reader.AsDataSet();

                }
            }

            return result;
        }

        static List<HsCodeRequestDto> ParseDataSet(DataSet dataSet)
        {
            List<HsCodeRequestDto> hsCodeRequestDtos =  new List<HsCodeRequestDto>();

            // The result of each spreadsheet is in result.Tables
            int index = 0;
            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                // row 6 is the start of the actual data

                if (index > 4)
                {
                    
                        hsCodeRequestDtos.Add(new HsCodeRequestDto
                        {
                            Country = row.ItemArray[0].ToString(),
                            Year = Convert.ToInt32(row.ItemArray[1]),
                            CodeLevel = Convert.ToInt32(row.ItemArray[2]),
                            Version = row.ItemArray[3].ToString(),
                            HsCode = row.ItemArray[4].ToString(),
                            NumberOfSubHeadings = Convert.ToInt32(row.ItemArray[5]),
                            NumberOfTl = Convert.ToInt32(row.ItemArray[6]),
                            NumberOfAvDuties = Convert.ToDouble(row.ItemArray[7]),
                            AverageOfAvDuties =  row.ItemArray[8] is DBNull ? 0:Convert.ToDouble(row.ItemArray[8]),
                            MinimumAvDuty  = row.ItemArray[9] is DBNull ? 0:Convert.ToDouble(row.ItemArray[9]),
                            MaximumAvDuty =  row.ItemArray[10] is DBNull ? 0:Convert.ToDouble(row.ItemArray[10]),
                            DutyFreeTlPercent = Convert.ToDouble(row.ItemArray[11]),
                            NumberOfNonAvDuty = Convert.ToInt32(row.ItemArray[12]),
                            ListOfNonAvDuties = row.ItemArray[13]?.ToString(),
                            Description = row.ItemArray[17]?.ToString(),
                        });
                    
                }

                ++index;
            }

            return hsCodeRequestDtos;
        }

        static Client.Client InitializeApiClient()
        {
            // TODO:
            //string url = new ConfigurationSection("HsCodeApiUrl").Value.ToString();
            return  new Client.Client("http://localhost:49367");
        }

        static Task PostHsCode(HsCodeRequestDto hsCodeRequestDto, Client.Client client)
        {
            return client.ApiHsCodePostAsync(hsCodeRequestDto);
        }

        static void SaveHsCodes(List<HsCodeRequestDto> hsCodeRequestDtos,  Client.Client client)
        {
            foreach (HsCodeRequestDto hsCodeRequestDto in hsCodeRequestDtos)
            {
                PostHsCode(hsCodeRequestDto, client).Wait();
                Console.WriteLine($"Saved {hsCodeRequestDto.HsCode} - {hsCodeRequestDto.Description}");
            }
        }
    }
}
