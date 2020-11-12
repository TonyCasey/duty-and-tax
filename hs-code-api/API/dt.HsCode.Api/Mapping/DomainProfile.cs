using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using dt.HsCode.Api.Model;
using dt.HsCode.Model.HsCode;

namespace dt.HsCode.Api.Mapping
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
            CreateMap<Code, Code>();
            CreateMap<HsCodeRequestDto, Code>()
                .ForMember(x => x.Country, y => y.Ignore())
                ;
        }
    }
}
