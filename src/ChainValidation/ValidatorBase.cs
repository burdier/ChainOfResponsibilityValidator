using System;
using ChainValidation.domain;

namespace ChainValidation {
    public abstract class ValidatorBase {
        protected ValidatorBase Successor { get; private set; }
        public abstract ErrorResult HandleValidation (User model, ErrorResult errorresult);
        public void SetSuccessor (ValidatorBase succesor) {
            this.Successor = succesor;
        }
    }

}