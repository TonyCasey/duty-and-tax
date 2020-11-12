using dt.HsCode.Api.Model;
using FluentValidation;

namespace dt.HsCode.Api.Infrastructure.Validation
{
    /// <summary>
    /// Validate the Calculator Request
    /// </summary>
    public class HsCodeRequestValidator  : AbstractValidator<HsCodeRequestDto>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public HsCodeRequestValidator()
        {
            //RuleFor(m => m.MerchandiseTotal)
            //    .NotEmpty()
            //    .GreaterThan(1)
            //    .WithMessage("You must speicify the merchandise total");
            
        }
    }
}
