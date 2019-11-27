using System;
using ChainValidation.domain;

namespace ChainValidation {
    public class NameNotEmptyValidator : ValidatorBase {

        public override ErrorResult HandleValidation (User model, ErrorResult errorResult) {
            if (string.IsNullOrWhiteSpace (model.Name)) {
                errorResult.ErrorMessage.Add ("name", "name can't be null");
            }

            if (Successor != null) {
                return Successor.HandleValidation (model, errorResult);
            }

            return errorResult;

        }
    }
}