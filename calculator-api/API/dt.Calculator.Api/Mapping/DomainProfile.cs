using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using dt.Calculator.Api.Model;
using dt.Calculator.Model.Domain.Calculator;

namespace dt.Calculator.Api.Mapping
{
    /// <summary>
    /// Class used for mapping of domain models to Dto's
    /// </summary>
    public class DomainProfile : Profile
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public DomainProfile()
        {
            CreateMap<CalculatorSetting, CalculateResponseDto>();
            CreateMap<CalculatorSetting, CanadaCalculateResponseDto>();
        }
    }
}
