using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using Infra.models;

namespace Infra.Validation

{
   public class validation:AbstractValidator<User>
    {
        public validation()
        {
            RuleFor(x => x.username)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty()
                .WithErrorCode("100")
                .MaximumLength(20)
                .WithErrorCode("101");

            RuleFor(y => y.id)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .WithErrorCode("102")
                .GreaterThan(99)
                .WithErrorCode("103")
                .LessThan(1001)
                .WithErrorCode("104");
        }
    }
}
