using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Name is null");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail is null");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Password null");
            RuleFor(x => x.WriterPassword).Length(8).WithMessage("Password minumum 8 character");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Name minumum 2 character");
            RuleFor(x => x.WriterName).MaximumLength(20).WithMessage("Name maximum 20 character");
            RuleFor(x => x.WriterPassword).Matches(@"[A-Z]+").WithMessage("Your password must contain at least one uppercase letter.")
                .Matches(@"[a-z]+").WithMessage("Your password must contain at least one lowercase letter.")
                .Matches(@"[0-9]+").WithMessage("Your password must contain at least one number.");
            
        }

        
    }
}
