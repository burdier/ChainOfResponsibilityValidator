using System.Collections.Generic;
using System.Linq;

namespace ChainValidation {
    public class ErrorResult {
        public ErrorResult () {
            ErrorMessage = new Dictionary<string, string> ();
        }
        public bool IsValid { get; set; }
        public Dictionary<string, string> ErrorMessage { get; set; }

    }
}