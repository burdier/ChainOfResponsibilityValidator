using System;
using System.Linq;
using ChainValidation;
using ChainValidation.domain;
using NUnit.Framework;

namespace test {
    public class Tests {
        [SetUp]
        public void Setup () { }

        [Test]
        public void When_whit_name_is_White_Or_Space () {
            var user = new User { };
            var validatorContext = new ValidatorContext ();
            //act
            var result = validatorContext.Validate (user);
            Assert.That (result.ErrorMessage["name"], Is.EqualTo("name can't be null"));
        }

        [Test]
        public void When_Age_is_default_datetime() {
            var user = new User { Name="hello"};
            var validatorContext = new ValidatorContext ();
            //act
            var result = validatorContext.Validate(user);            
            Assert.That (result.ErrorMessage["age"], Is.EqualTo("Age  is required"));
        }
    }
}