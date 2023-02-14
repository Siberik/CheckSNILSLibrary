using Microsoft.VisualStudio.TestTools.UnitTesting;
using CheckSNILSLibrary;
using System;

namespace CheckSNILSLibraryTests
{
    [TestClass]
    public class CheckSNILSTests
    {
        /// <summary>
        /// Проверка на ввод пустой строки
        /// </summary>
        [TestMethod]
        public void CheckPersonakCode_StringEmpty_ReturnFalse()
        {
            //Arrange
            string textString = String.Empty;
            //Act
            CheckSNILSClass obj= new CheckSNILSClass();
            bool actual= obj.CheckPersonakCode(textString);

            //Assert
            Assert.IsFalse(actual);
        }
        /// <summary>
        /// Проверка на ввод корректного СНИЛСа
        /// </summary>
        [TestMethod]
        public void CheckPersonakCode_CorrectSNILS_ReturnTrue()
        {
            //Arrange
            string textString = "112-233-445 95";
            //Act
            CheckSNILSClass obj = new CheckSNILSClass();
            bool actual = obj.CheckPersonakCode(textString);

            //Assert
            Assert.IsFalse(actual);
        }
        /// <summary>
        /// Проверка на ввод некорректного СНИЛСа
        /// </summary>
        [TestMethod]
        public void CheckPersonakCode_unCorrectSNILS_ReturnFalse()
        {
            //Arrange
            string textString = "333";
            //Act
            CheckSNILSClass obj = new CheckSNILSClass();
            bool actual = obj.CheckPersonakCode(textString);

            //Assert
            Assert.IsFalse(actual);
        }
        /// <summary>
        /// Проверка на ввод некорректного СНИЛСа
        /// </summary>
        [TestMethod]
        public void CheckPersonakCode_unCorrectNumber_ReturnFalse()
        {
            //Arrange
            string textString = "999999999999999999999";
            //Act
            CheckSNILSClass obj = new CheckSNILSClass();
            bool actual = obj.CheckPersonakCode(textString);

            //Assert
            Assert.IsFalse(actual);
        }
    }
}
