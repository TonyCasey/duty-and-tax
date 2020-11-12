using System;
using System.ComponentModel.DataAnnotations;
using AutoMapper;
using AutoMapper.Configuration;

namespace dt.HsCode.Model
{
    public class BaseEntity
    {
        [Required]
        public DateTime CreationTime { get; set; }

        [Required]
        [StringLength(250)]
        public string CreationUser { get; set; }

        public DateTime? LastUpdateTime { get; set; }

        [StringLength(250)]
        public string LastUpdateUser { get; set; }

        /// <summary>
        /// Maps the values of the entity given to the entity except the key and tracking fields
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        public void UpdateFromEntity<T>(T entity)
        {
            string entityIdPropertyName = this.GetType().Name + "Id";

            if (this.GetType().GetProperty(entityIdPropertyName) == null)
            {
                throw new Exception("Entity primary key not found");
            }

            var cfg = new MapperConfigurationExpression();
            cfg.CreateMap(typeof(T), this.GetType())
                .ForMember(entityIdPropertyName, opt => opt.Ignore())
                .ForMember("CreationUser", opt => opt.Ignore())
                .ForMember("CreationTime", opt => opt.Ignore())
                .ForMember("LastUpdateUser", opt => opt.Ignore())
                .ForMember("LastUpdateTime", opt => opt.Ignore());

            var mapperConfig = new MapperConfiguration(cfg);
            IMapper mapper = new Mapper(mapperConfig);

            mapper.Map(entity, this);
        }
    }
    
}
