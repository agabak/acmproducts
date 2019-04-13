using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameValid()
        {
            //...Arrange
            var customer = new Customer
                                {
                                    FirstName = "Agaba",
                                    LastName = "Kabunga"
                                };
            var expected = "Kabunga, Agaba";

            //....Act
            var actual = customer.FullName;

            //...Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //...Arrange
            var customer = new Customer
            {
                LastName = "Kabunga"
            };
            var expected = "Kabunga";

            //....Act
            var actual = customer.FullName;

            //...Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //...Arrange
            var customer = new Customer
            {
                FirstName = "Agaba"
            };
            var expected = "Agaba";

            //....Act
            var actual = customer.FullName;

            //...Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            //...Arrange
            var customer = new Customer();
            customer.FirstName = "Bilbo";
            Customer.InstanceCount += 1;

            var customer2 = new Customer();
            customer2.FirstName = "Frodo";
            Customer.InstanceCount += 1;

            var customer3 = new Customer();
            customer3.FirstName = "Rosie";
            Customer.InstanceCount += 1;

            //....Act


            //...Assert
            Assert.AreEqual(3, Customer.InstanceCount);
        }

        [TestMethod]
        public void ValidateValide()
        {
            //...Arrange
            var customer = new Customer
            {
                LastName = "Kabunga",
                EmailAddress = "agaba_k@hotmmail.com"
            };

            var expected = true;

            //....Act
            var actual = customer.Validate();

            //...Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateLastNameIsEmptyInValide()
        {
            //...Arrange
            var customer = new Customer
            {
                EmailAddress = "agaba_k@hotmmail.com"
            };

            var expected = false;

            //....Act
            var actual = customer.Validate();

            //...Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateEmailAddressIsEmptyInValide()
        {
            //...Arrange
            var customer = new Customer
            {
                LastName = "Kabunga"
            };

            var expected = false;

            //....Act
            var actual = customer.Validate();

            //...Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidatBothFieldAreEmptyInValide()
        {
            //...Arrange
            var customer = new Customer();

            var expected = false;

            //....Act
            var actual = customer.Validate();

            //...Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
