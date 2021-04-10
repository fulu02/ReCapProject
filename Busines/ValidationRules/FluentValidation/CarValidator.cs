using Busines.Abstract;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Busines.ValidationRules.FluentValidation
{
   public  class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(car => car.CarName).NotEmpty();
            RuleFor(car => car.CarName).MinimumLenght(3);
            RuleFor(car => car.DailyPrice).NotEmpty();
            RuleFor(car => car.DailyPrice).GreterThan();
            RuleFor(car => car.DailyPrice).GreterThanOrEquealTo(5).When(Car => Car.BrandId == 2);
        }

        internal object Validate(object context)
        {
            throw new NotImplementedException();
        }
    }
}
