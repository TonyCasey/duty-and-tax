using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using dt.Calculator.Model.Common;
using dt.Calculator.Model.Domain.Calculator;
using dt.Calculator.Model.Domain.Lookup;

namespace dt.Calculator.Database.Seed
{
    public static class CalculatorsSeed
    {
        public static List<Model.Domain.Calculator.Calculator> GetCalculators()
        {
            List<Model.Domain.Calculator.Calculator> results = new List<Model.Domain.Calculator.Calculator>();


            var calculatorSettings = CalculatorSettingsSeed.GetCalculatorSettings();

          
            int index = 1;
            foreach (CalculatorSetting calculatorSetting in calculatorSettings.Where(x => x.CountryIso != null))
            {
                results.Add(new Model.Domain.Calculator.Calculator()
                {
                    CalculatorId = index,
                    CountryIso = calculatorSetting.CountryIso,
                    CalculatorSettingId = calculatorSetting.CalculatorSettingId
                });
                ++index;
            }

           


            
           
            // for all other countries add a calculator with default settings
            
            foreach (Enumerations.CountryEnum countryIso in (Enumerations.CountryEnum[]) Enum.GetValues(
                typeof(Enumerations.CountryEnum)))
            {
                
                String name = Enum.GetName(typeof(Enumerations.CountryEnum), countryIso);
                Country country = CountrySeed.GetCountries().FirstOrDefault(x => x.Iso == name.ToUpper());
                int calculatorSettingId = country?.RegionId == Enumerations.RegionEnum.Europe ? 2 : 1;

                if (results.All(x => x.CountryIso != name.ToString()))
                {
                    results.Add(new Model.Domain.Calculator.Calculator()
                    {
                        CalculatorId = index,
                        CountryIso = name.ToUpper(),
                        CalculatorSettingId = calculatorSettingId 
                    });
                }

                ++index;

            }

            return results;
        }
    }
}
