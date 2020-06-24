using NUnit.Framework;
using secondtryatmaths;
using System;

namespace UnitTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void SaveUserNameTest()
        {
 

            Win2Logic.testSaveClick("test777777", "standardpassword", 9);
            bool found = MainWinLogic.CheckAndCreate("test777777", "standardpassword");

            Assert.AreEqual(found, true);
        }


        [Test]
        public void SavePasswordTest()
        {
            bool found = MainWinLogic.CheckPassword("test777777", "standardpassword");

            Assert.AreEqual(found, true);
        }


        [Test]
        public void SaveScoreTest()
        {
            bool found = MainWinLogic.CheckScore("test777777", 9);

            Assert.AreEqual(found, true);
        }




        [Test]
        public void areGeneratedNumbersBetween1And99()
        {

            string[] text = Win1Logic.populate().Split('-');
            int firstNum = Int32.Parse(text[0]);
            int secNum = Int32.Parse(text[1]);

            Assert.IsTrue(firstNum > 1 && firstNum < 13);
            Assert.IsTrue(secNum > 1 && secNum < 13);

        }


        [Test]
        public void areGeneratedNumbersAlwaysPositive()
        {

            string[] text = Win1Logic.populate().Split('-');
            int firstNum = Int32.Parse(text[0]);
            int secNum = Int32.Parse(text[1]);

            Assert.IsTrue(firstNum > 0 );
            Assert.IsTrue(secNum > 0 );

        }


        [Test]
        public void doesRightAnswerGameLogicWork()
        {

            string[] text = Win1Logic.populate().Split('-');
            int firstNumInt = Int32.Parse(text[0]);
            int secNumInt = Int32.Parse(text[1]);
            int answer = firstNumInt * secNumInt;
            string answerString = answer.ToString();
            string firstNum = text[0];
            string secNum = text[1];

           bool rightAnswer = Win1Logic.UpdateScoreLogic(answerString, firstNum, secNum);


            Assert.AreEqual(rightAnswer, true);

        }



        [Test]
        public void doesWrongAnswerGameLogicWork()
        {

            string[] text = Win1Logic.populate().Split('-');
            string firstNum = text[0];
            string secNum = text[1];

            bool wrongAnswer = Win1Logic.UpdateScoreLogic(firstNum, firstNum, secNum);

            Assert.AreEqual(wrongAnswer, false);

        }

        [Test]
        public void doesExceptionHandlerGameLogicWork()
        {

            string[] text = Win1Logic.populate().Split('-');

            string ExceptionString = "I don't know the answer!";
            string firstNum = text[0];
            string secNum = text[1];

            bool ExceptionShouldReturnFalse = Win1Logic.UpdateScoreLogic(ExceptionString, firstNum, secNum);

            Assert.AreEqual(ExceptionShouldReturnFalse, false);

        }


    }
}