using FizzBuzzTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzTask.Tests
{
    
    public class FizzBuzzDetectorTests
    {
        [Fact]// anotation to mention that tere is a test case without it the method will be considered as a normal method not a test case 
        public void ThirdWord_Should_Return_Fizz()
        {
            var detector = new FizzBuzzDetector();// here the data is prepared to test 

            Result result = detector.GetOverlappings(
                "one two three"
            );// هنا بقوله استدعى الميثود دى واديها ال Input "one two three"

            Assert.Equal(
                "one two Fizz" // Exepected parameter
                ,
                result.OutputString// Actual parameter
            );// هنا بقوله اتاكد ان الاتنين دوول متساويين

            Assert.Equal(1, result.Count);//here is the same as the last step
        }

        [Fact]
        public void FifthWord_Should_Return_Buzz()
        {
            var detector = new FizzBuzzDetector();

            Result result = detector.GetOverlappings(
                "one two three four five"
            );

            Assert.Equal(
                "one two Fizz four Buzz",
                result.OutputString
            );

            Assert.Equal(2, result.Count);
        }


        [Fact]
        public void FifteenthWord_Should_Return_FizzBuzz()
        {
            var detector = new FizzBuzzDetector();

            string input =
                "1 2 3 4 5 6 7 8 9 10 11 12 13 14 15";


            Result result = detector.GetOverlappings(input);


            Assert.Equal(
                "1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz",
                result.OutputString
            );

            Assert.Equal(7, result.Count);
        }

        [Fact]
        public void InputLessThanMinimumLength_Should_ThrowException()
        {
            var detector = new FizzBuzzDetector();


            Assert.Throws<ArgumentOutOfRangeException>(
                () => detector.GetOverlappings("abc")
            );
        }



        [Fact]
        public void InputGreaterThanMaximumLength_Should_ThrowException()
        {
            var detector = new FizzBuzzDetector();


            string input = new string('a', 101);// make a string has a 101 char 


            Assert.Throws<ArgumentOutOfRangeException>(
                () => detector.GetOverlappings(input)// هنا بقوله انى متوقع انه يرمى Exception  وبقوله بقا فى الميثود دى اللامدا خد ال فانكشن دى عندك ونفذها وشوف لو طلع اكسبشن يعمل باسس غير كددا لا
            );
        }


    }
}
