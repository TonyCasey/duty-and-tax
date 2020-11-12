using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using dt.Calculator.Database.Seed;
using dt.Calculator.Model.Common;
using dt.Calculator.Model.Domain.Calculator;
using dt.Calculator.Model.Domain.Lookup;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Update;

namespace dt.Calculator.Database
{
    public static class SeedData
    {
        
        public static void Seed(ModelBuilder modelBuilder)
        {
            AddCountries(modelBuilder);
            AddCurrencies(modelBuilder);
            AddCalculatorSettings(modelBuilder);
            AddCalculators(modelBuilder);
            AddCanadianProvincialTaxRates(modelBuilder);
        }

        private static void AddCountries(ModelBuilder modelBuilder)
        {

            List<Country> countries = CountrySeed.GetCountries();

            foreach (Country country in countries)
            {
                modelBuilder.Entity<Model.Domain.Lookup.Country>().HasData
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
                modelBuilder.Entity<Model.Domain.Lookup.Currency>().HasData
                (
                    currency
                );
            }
            
        }

        private static void AddCalculators(ModelBuilder modelBuilder)
        {

            List<Model.Domain.Calculator.Calculator> calculators = CalculatorsSeed.GetCalculators();

            foreach (Model.Domain.Calculator.Calculator calculator in calculators)
            {
                modelBuilder.Entity<Model.Domain.Calculator.Calculator>().HasData
                (
                    calculator
                );
            }
            
        }
 
        private static void AddCalculatorSettings(ModelBuilder modelBuilder)
        {
            List<CalculatorSetting> calculatorSettings = CalculatorSettingsSeed.GetCalculatorSettings();

            
            foreach (CalculatorSetting calculatorSetting in calculatorSettings)
            {
                modelBuilder.Entity<Model.Domain.Calculator.CalculatorSetting>().HasData
                (
                    calculatorSetting
                );
            }
            
            
        }

        private static void AddCanadianProvincialTaxRates(ModelBuilder modelBuilder)
        {
            List<CanadianProvincialTaxRate> list =
                CanadianProvincialTaxRateSeed.GetCanadianProvincialTaxRates();

            
            foreach (var record in list)
            {
                modelBuilder.Entity<CanadianProvincialTaxRate>().HasData
                (
                    record
                );
            }
        }

    }
}
