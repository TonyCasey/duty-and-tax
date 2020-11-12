using System.Collections.Generic;
using dt.Calculator.Database.Seed;
using dt.HsCode.Model.Lookup;
using Microsoft.EntityFrameworkCore;

namespace dt.HsCode.Database
{
    public static class SeedData
    {
        
        public static void Seed(ModelBuilder modelBuilder)
        {
            AddCountries(modelBuilder);
            AddCurrencies(modelBuilder);
        }
        
        private static void AddCountries(ModelBuilder modelBuilder)
        {

            List<Country> countries = CountrySeed.GetCountries();

            foreach (Country country in countries)
            {
                modelBuilder.Entity<Country>().HasData
                (
                    country
                );
            }

           
        }

        private static void AddCurrencies(ModelBuilder modelBuilder)
        {

            List<Currency> currencies = CurrencySeed.GetCurrencies();

            
            foreach (Currency currency in currencies)
            {
                modelBuilder.Entity<Currency>().HasData
                (
                    currency
                );
            }
            
        }
    }
}
