using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Divisible.Test
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void Check_CountOfPositiveRange()
        {
            int number1 = 1, number2 = 25, divider = 3;

            //number1 = GetValidNumber("Type your number");
            //number2 = GetValidNumber("Type another number");
            //divider = GetValidNumber("Type a number to divide the interval");

            DivisibleWithNoRemainder testObj = new(number1, number2, divider);
            var actual = testObj.Count;
            var expected = 8;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Check_CountOfNegativeRange()
        {
            int number1 = 0, number2 = -100, divider = 20;

            //number1 = GetValidNumber("Type your number");
            //number2 = GetValidNumber("Type another number");
            //divider = GetValidNumber("Type a number to divide the interval");

            DivisibleWithNoRemainder testObj = new(number1, number2, divider);
            var actual = testObj.Count;
            var expected = 5;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Check_SequenceOfPositiveRange()
        {
            int number1 = 1, number2 = 25, divider = 3;

            //number1 = GetValidNumber("Type your number");
            //number2 = GetValidNumber("Type another number");
            //divider = GetValidNumber("Type a number to divide the interval");

            DivisibleWithNoRemainder testObj = new(number1, number2, divider);
            var actual = testObj.GetNumbersInRange();
            var expected = "3 | 6 | 9 | 12 | 15 | 18 | 21 | 24";

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Check_SequenceOfNegativeRange()
        {
            int number1 = -10, number2 = -20, divider = 3;

            //number1 = GetValidNumber("Type your number");
            //number2 = GetValidNumber("Type another number");
            //divider = GetValidNumber("Type a number to divide the interval");

            DivisibleWithNoRemainder testObj = new(number1, number2, divider);
            var actual = testObj.GetNumbersInRange();
            var expected = "3 | 6 | 9 | 12 | 15 | 18 | 21 | 24";

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Check_ForIntervalZero()
        {
            int number1 = 1, number2 = 25, divider = 0;
            DivisibleWithNoRemainder testObj = new(number1, number2, divider);
            var actual = testObj.GetNumbersInRange();
            var expected = "3 | 6 | 9 | 12 | 15 | 18 | 21 | 24";

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Check_ForIntervalGreaterThanEnd()
        {
            int number1 = 1, number2 = 25, divider = 26;
            DivisibleWithNoRemainder testObj = new(number1, number2, divider);
            var actual = testObj.GetNumbersInRange();
            var expected = "3 | 6 | 9 | 12 | 15 | 18 | 21 | 24";

            Assert.AreEqual(expected, actual);
        }
        int GetValidNumber(string message)
        {
            const int guardClause = 0;
            int number = 0;
            while (number == guardClause)
            {
                Console.WriteLine($"\n{message}: ");
                if (!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("Not a number\n");
                }
            }

            return number;
        }
    }
}