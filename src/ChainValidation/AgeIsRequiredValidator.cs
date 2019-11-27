using System;
using ChainValidation.domain;

namespace ChainValidation {
    public class AgeIsRequiredValidator : ValidatorBase {

        public override ErrorResult HandleValidation (User model, ErrorResult errorResult) {
            if (model.age == DateTime.MinValue) {
                errorResult.ErrorMessage.Add ("age", "Age  is required");
            }

            if (Successor != null) {
                return Successor.HandleValidation (model, errorResult);
            }
            return errorResult;

        }
    }
}