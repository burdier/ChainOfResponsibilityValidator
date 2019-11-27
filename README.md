# Chain Of Responsibility Validator


Chain of Responsibility in C# Chain of Responsibility is behavioral design pattern that allows passing request along the chain of potential handlers until one of them handles request. The pattern allows multiple objects to handle the request without coupling sender class to the concrete classes of the receivers


#Example
```C#
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

```
