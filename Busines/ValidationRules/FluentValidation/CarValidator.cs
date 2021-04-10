using Busines.Abstract;
using Entities.Concrete;
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
            RuleFor(car => car.CarName).MinimumLength(3);
            RuleFor(car => car.DailyPrice).NotEmpty();
            RuleFor(car => car.DailyPrice).GreaterThan();
            RuleFor(car => car.DailyPrice).GreaterThanOrEqualTo(5).When(Car => Car.BrandId == 2);
        }

        internal object Validate(object context)
        {
            throw new NotImplementedException();
        }
    }
}
