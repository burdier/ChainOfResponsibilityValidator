using ChainValidation.domain;

namespace ChainValidation {
    public class ValidatorContext : IvalidatorContext {
        public ValidatorContext () {
            ErrorResult = new ErrorResult ();
        }
        private ErrorResult ErrorResult { get; set; }
        public ErrorResult Validate (User model) {
            NameNotEmptyValidator nameNotEmptyValidator = new NameNotEmptyValidator ();
            AgeIsRequiredValidator ageIsRequiredValidator = new AgeIsRequiredValidator ();
            nameNotEmptyValidator.SetSuccessor (ageIsRequiredValidator);
            return nameNotEmptyValidator.HandleValidation (model, ErrorResult);
        }
    }
    public interface IvalidatorContext {
        ErrorResult Validate (User Model);

    }
}