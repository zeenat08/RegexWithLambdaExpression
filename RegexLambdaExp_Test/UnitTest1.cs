using NUnit.Framework;
using RegexWithLambdaExpression;

namespace RegexLambdaExp_Test
{
    public class Tests
    {
        RegularExpressionValidation regex = new RegularExpressionValidation();

        //Test 1:- Firstname Validation Check
        [Test]
        public void Check_FirstName_Validate()
        {
            string actual = regex.FirstnameCheck("Zeenat");
            Assert.AreEqual("First Name Validated", actual);
        }

        //Test 2:- Lastname Validation Check
        [Test]
        public void Check_LastName_Validate()
        {
            string actual = regex.LastNameCheck("Khan");
            Assert.AreEqual("Last Name Validated", actual);
        }

        //Test 3:- Email Validation Check
        [Test]
        public void Check_Email_Validate()
        {
            string actual = regex.EmailCheck("abc.xyz260@gmail.com");
            Assert.AreEqual("email is Validated", actual);
        }

        //Test 4:- Phno Validation Check
        [Test]
        public void Check_Phno_Validate()
        {
            string actual = regex.PHNoCheck("91 7835462210");
            Assert.AreEqual("phno is Validated", actual);
        }

        //Test 5:- Password Validation Check
        [Test]
        public void Check_Password_Validate()
        {
            string actual = regex.PasswordCheck("hYstr23hSr2#");
            Assert.AreEqual("password is Validated", actual);
        }


        //Test 6:- Invalid Firstname Exception
        [Test]
        public void Given_InvalidFirstname_ThrowException()
        {
            try
            {
                string actual = regex.FirstnameCheck("Zeenat1");
            }
            catch (RegularExpressionCustomException ex)
            {
                Assert.AreEqual("First name starts with Cap and has minimum 3 characters", ex.Message);
            }
        }


        //Test 7:- EmpltyOrNUll Firstname Exception
        [Test]
        public void Given_NUllFirstname_ThrowException()
        {
            try
            {
                string actual = regex.FirstnameCheck(null);
            }
            catch (RegularExpressionCustomException ex)
            {
                Assert.AreEqual("FirstName Could not be Empty or null", ex.Message);
            }
        }

        //Test 8:- Invalid Firstname Exception
        [Test]
        public void Given_InvalidLastname_ThrowException()
        {
            try
            {
                string actual = regex.FirstnameCheck("Zeenat1");
            }
            catch (RegularExpressionCustomException ex)
            {
                Assert.AreEqual("Last name starts with Cap and has minimum 3 characters", ex.Message);
            }
        }


        //Test :- EmpltyOrNUll Firstname Exception
        [Test]
        public void Given_NUllLastname_ThrowException()
        {
            try
            {
                string actual = regex.FirstnameCheck(null);
            }
            catch (RegularExpressionCustomException ex)
            {
                Assert.AreEqual("LastName Could not be Empty or null", ex.Message);
            }
        }
        //Test 10:- Invalid Email Exception
        [Test]
        public void Given_InvalidEmail_ThrowException()
        {
            try
            {
                string actual = regex.EmailCheck("abc.xyz@gmail");
            }
            catch (RegularExpressionCustomException ex)
            {
                Assert.AreEqual("E.g. abc.xyz@bl.co.in - Email has 3 mandatory parts (abc, bl & co) and 2 optional(xyz & in) with precise @ and.positions", ex.Message);
            }
        }


        //Test 11:- EmpltyOrNUll Email Exception
        [Test]
        public void Given_NUllEmail_ThrowException()
        {
            try
            {
                string actual = regex.EmailCheck(null);
            }
            catch (RegularExpressionCustomException ex)
            {
                Assert.AreEqual("Email Could not be Empty or null", ex.Message);
            }
        }


        //Test 12:- Invalid PHNo Exception
        [Test]
        public void Given_InvalidPHNo_ThrowException()
        {
            try
            {
                string actual = regex.PHNoCheck("+91 76834256173");
            }
            catch (RegularExpressionCustomException ex)
            {
                Assert.AreEqual("Phone Number Should Have 10 digits and [+91 ] is Mandatory - E.g. 91 6919819801 - Country code follow by space and 10 digit number", ex.Message);
            }
        }


        //Test 13:- EmpltyOrNUll PHNo Exception
        [Test]
        public void Given_NUllPHNo_ThrowException()
        {
            try
            {
                string actual = regex.PHNoCheck(null);
            }
            catch (RegularExpressionCustomException ex)
            {
                Assert.AreEqual("Phone Number Could not be Empty or null", ex.Message);
            }
        }


        //Test 14:- Invalid Password Exception
        [Test]
        public void Given_InvalidPassword_ThrowException()
        {
            try
            {
                string actual = regex.PasswordCheck("hYstr23hSr2#");
            }
            catch (RegularExpressionCustomException ex)
            {
                Assert.AreEqual("Password Have minimum 8 Characters, Should have at least 1 Upper Case and Should have at least 1 numeric number and Has exactly 1 Special Character", ex.Message);
            }
        }


        //Test 15:- EmpltyOrNUll Password Exception
        [Test]
        public void Given_NUllPassword_ThrowException()
        {
            try
            {
                string actual = regex.PasswordCheck(null);
            }
            catch (RegularExpressionCustomException ex)
            {
                Assert.AreEqual("Password Could not be Empty or null", ex.Message);
            }
        }
    }
}