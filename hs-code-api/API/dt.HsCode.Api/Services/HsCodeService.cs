using AutoMapper;
using dt.HsCode.Database;
using dt.HsCode.Model.HsCode;
using System;
using System.Linq;
using dt.HsCode.Api.Model;
using dt.HsCode.Model.Common;
using Microsoft.EntityFrameworkCore;
using NLog.Fluent;

namespace dt.HsCode.Api.Services
{
    /// <summary>
    /// Hs Code service
    /// </summary>
    public class HsCodeService : IHsCodeService
    {
        private readonly DtDbContext _dbContext;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="dbContext"></param>
        /// <param name="mapper"></param>
        public HsCodeService(DtDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        /// <summary>
        /// Add or update a HsCode entry
        /// </summary>
        /// <param name="hsCodeRequestDto"></param>
        /// <returns></returns>
        public Code AddOrUpdate(HsCodeRequestDto hsCodeRequestDto)
        {
            int regionId = (int)GetRegionId(hsCodeRequestDto.Country);
            
            Code code = null;

            try
            {
                code =
                    _dbContext.Codes.FirstOrDefault(x => x.HsCode == hsCodeRequestDto.HsCode && x.RegionId == regionId);

                if (code != null)
                {
                    // TODO: Update if newer
                   // _dbContext.Codes.Update(_mapper.Map(hsCodeRequestDto, code));
                }
                else
                {
                    code = _mapper.Map(hsCodeRequestDto, new Code());
                    code.RegionId = regionId;
                    _dbContext.Codes.Add(code);
                }


                _dbContext.SaveChanges();
            }
            catch (Exception e)
            {
                Log.Error(e.StackTrace);
            }

            return code;
        }

        private Enumerations.RegionEnum GetRegionId(string region)
        {
            switch (region)
            {
                case "European Union" :
                    return Enumerations.RegionEnum.Europe;
                default:
                    return Enumerations.RegionEnum.RestOfWorld;
            }
        }
        
    }

    /// <summary>
    /// Hs Code Service interface
    /// </summary>
    public interface IHsCodeService
    {
        /// <summary>
        /// Add or update a HsCode entry
        /// </summary>
        /// <param name="hsCode"></param>
        /// <returns></returns>
        Code AddOrUpdate(HsCodeRequestDto hsCodeRequestDto);
    }

    
}
