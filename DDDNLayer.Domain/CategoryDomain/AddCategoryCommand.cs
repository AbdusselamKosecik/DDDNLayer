﻿using DDDDNLayer.Domain.CategoryDomain.Validations;
using FluentValidation;

namespace DDDNLayer.Domain.CategoryDomain
{
    public class AddCategoryCommand : CategoryCommand
    {
        public AddCategoryCommand(string name, int type)
        {
            Name = name;
            Type = type;
        }

        public override bool IsValid()
        {
            ValidationResult = new AddCategoryCommandValidator().Validate(this);

            return ValidationResult.IsValid;
        }
    }
}