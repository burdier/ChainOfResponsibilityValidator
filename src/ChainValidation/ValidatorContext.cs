using ChainValidation.domain;

namespace ChainValidation {
    public class ValidatorContext : IvalidatorContext {
        public ValidatorContext () {
            ErrorResult = new ErrorResult ();
        }
        private ErrorResult ErrorResult { get; set; }

        public bool IsValid()
        {
            //TODO:  if errorResult has message, the model is not valid.
            throw new System.NotImplementedException();
        }

        public ErrorResult Validate (User model) {
            NameNotEmptyValidator nameNotEmptyValidator = new NameNotEmptyValidator ();
            AgeIsRequiredValidator ageIsRequiredValidator = new AgeIsRequiredValidator ();
            nameNotEmptyValidator.SetSuccessor (ageIsRequiredValidator);
            return nameNotEmptyValidator.HandleValidation (model, ErrorResult);
        }
    }
    public interface IvalidatorContext {
        ErrorResult Validate (User Model);
        bool IsValid();

    }
}