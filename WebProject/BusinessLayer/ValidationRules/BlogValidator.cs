using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator:AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("You can't null");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("You can't null");
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("You can't null");
            RuleFor(x => x.BlogTitle).MaximumLength(50).WithMessage("You can't more than 50");
            
        }
    }
}
