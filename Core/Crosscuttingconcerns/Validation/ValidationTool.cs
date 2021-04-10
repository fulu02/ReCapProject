using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Crosscuttingconcerns.Validation
{
    public class ValidationTool
    {
        public static void Validate(IValidator validator,object entity)
        {
            var context = new ValidationContext<Product>(entity);
            var result = validator.Validate(context);
            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }
        }

        public static void Validate(global::Busines.ValidationRules.FluentValidation.CarValidator carValidators, object car)
        {
            throw new NotImplementedException();
        }

        public static void Validate(global::Busines.ValidationRules.FluentValidation.CarValidator carValidators, object car)
        {
            throw new NotImplementedException();
        }
    }
}
