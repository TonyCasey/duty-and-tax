using System;
using System.Collections.Generic;
using System.Text;
using dt.Calculator.Model.Domain.Lookup;

namespace dt.Calculator.Database.Seed
{
    public static class CanadianProvincialTaxRateSeed
    {
        public static List<CanadianProvincialTaxRate> GetCanadianProvincialTaxRates()
        {
            return new List<CanadianProvincialTaxRate>()
            {
                new CanadianProvincialTaxRate { CanadianProvincialTaxRateId = 1, StateCode = "ON", StateName = "Ontario",               HstRate = 0.05M, GstRate = 0, PstRate = 0.08M },
                new CanadianProvincialTaxRate { CanadianProvincialTaxRateId = 2, StateCode = "BC", StateName = "British Columbia",     HstRate = 0, GstRate = 0.05M, PstRate = 0.07M },
                new CanadianProvincialTaxRate { CanadianProvincialTaxRateId = 3, StateCode = "MB", StateName = "Manitoba",             HstRate = 0, GstRate = 0.05M, PstRate = 0.08M },
                new CanadianProvincialTaxRate { CanadianProvincialTaxRateId = 4, StateCode = "AB", StateName = "Alberta",              HstRate = 0, GstRate = 0.05M, PstRate = 0 },
                new CanadianProvincialTaxRate { CanadianProvincialTaxRateId = 5, StateCode = "NB", StateName = "New Brunswick",        HstRate = 0.05M, GstRate = 0, PstRate = 0.1M },
                new CanadianProvincialTaxRate { CanadianProvincialTaxRateId = 6, StateCode = "NL", StateName = "Newfoundland",         HstRate = 0.05M, GstRate = 0, PstRate = 0.1M },
                new CanadianProvincialTaxRate { CanadianProvincialTaxRateId = 7, StateCode = "NT", StateName = "Northwest Territory",  HstRate = 0, GstRate = 0.05M, PstRate = 0},
                new CanadianProvincialTaxRate { CanadianProvincialTaxRateId = 8, StateCode = "NS", StateName = "Nova Scotia",          HstRate = 0.05M, GstRate = 0, PstRate = 0.1M },
                new CanadianProvincialTaxRate { CanadianProvincialTaxRateId = 9, StateCode = "NU", StateName = "Nunavut",              HstRate = 0, GstRate = 0.05M, PstRate = 0 },
                new CanadianProvincialTaxRate { CanadianProvincialTaxRateId = 10, StateCode = "PE", StateName = "Prince Edward Island", HstRate = 0, GstRate = 0.05M, PstRate = 0.01M },
                new CanadianProvincialTaxRate { CanadianProvincialTaxRateId = 11, StateCode = "QC", StateName = "Quebec",               HstRate = 0, GstRate = 0.05M, PstRate = 0.0998M },
                new CanadianProvincialTaxRate { CanadianProvincialTaxRateId = 12, StateCode = "SK", StateName = "Saskatchewanq",        HstRate = 0, GstRate = 0.05M, PstRate = 0.06M },
                new CanadianProvincialTaxRate { CanadianProvincialTaxRateId = 13, StateCode = "YT", StateName = "Yukon",                HstRate = 0, GstRate = 0.05M, PstRate = 0 },
            };

            
        }
    }
}
