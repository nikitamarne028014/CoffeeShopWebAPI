using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShopWebAPI.Models
{
    public class ReservationValidator : AbstractValidator<Reservation>
    {
        public ReservationValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .NotNull()
                .MaximumLength(30);

            RuleFor(x => x.Email)
                .NotNull()
                .NotEmpty()
                .EmailAddress();

            RuleFor(x => x.Phone)
                .NotNull()
                .NotEmpty()
                .Matches(@"^((\+91)?|91)?[789][0-9]{9}");

            RuleFor(x => x.TotalPeople)
                .NotNull()
                .InclusiveBetween(1, 50);

            RuleFor(x => x.Date)
                .NotNull();

            RuleFor(x => x.Time)
                .NotNull()
                .NotEmpty();
        }
    }
}
