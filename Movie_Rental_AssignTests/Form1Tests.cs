using Microsoft.VisualStudio.TestTools.UnitTesting;
using Movie_Rental_Assign;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Rental_Assign.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void Form1Test()
        {
            try
            {
                Logic logic = new Logic();
                logic.registerCustomer("Mohit", "mohit@gmail.com", "2345", "NZ");
                Assert.IsTrue(true);
            }
            catch (Exception ex) {
                Assert.IsTrue(false);
            }
        }
        [TestMethod()]
        public void Form2Test()
        {
            try
            {
                Logic logic = new Logic();
                logic.editCustomer(2,"Mohit", "mohit@gmail.com", "2345", "NZ");
                Assert.IsTrue(true);
            }
            catch (Exception ex)
            {
                Assert.IsTrue(false);
            }
        }
    }
}