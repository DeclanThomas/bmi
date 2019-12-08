using Microsoft.VisualStudio.TestTools.UnitTesting;

using BMICalculator;

namespace BMIUnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            BMI bmi = new BMI() { WeightStones = 12, WeightPounds = 0, HeightFeet = 5, HeightInches = 10 };
            Assert.AreEqual(bmi.BMICategory, BMICategory.Normal);
        }



        [TestMethod]
        public void TestBMIValue_ValidValuesEntered_HappyPath()
        {
            //Arrange
            BMI bmi = new BMI();
            bmi.WeightStones = 10;
            bmi.WeightPounds = 10;
            bmi.HeightInches = 10;
            bmi.HeightFeet = 5;

            //Act
            string expectedResult = "21.5225205960616";

            //Assert
            Assert.AreEqual(expectedResult, bmi.BMIValue.ToString());
        }

        [TestMethod]
        public void TestBMICategory_BMIValueIsUnderweight_ReturnUnderweight()
        {
            //Arrange
            BMI bmi = new BMI();
            bmi.WeightStones = 5;
            bmi.WeightPounds = 5;
            bmi.HeightInches = 10;
            bmi.HeightFeet = 7;

            //Act
            BMICategory expectedResult = bmi.BMICategory;

            //Assert
            Assert.AreEqual(BMICategory.Underweight, expectedResult);
        }


        [TestMethod]
        public void TestBMICategory_BMIValueIsNormal_ReturnNormal()
        {
            //Arrange
            BMI bmi = new BMI();
            bmi.WeightStones = 10;
            bmi.WeightPounds = 5;
            bmi.HeightInches = 10;
            bmi.HeightFeet = 5;

            //Act
            BMICategory expectedResult = bmi.BMICategory;

            //Assert
            Assert.AreEqual(BMICategory.Normal, expectedResult);
        }

        [TestMethod]
        public void TestBMICategory_BMIValueIsOverweight_ReturnOverweight()
        {
            //Arrange
            BMI bmi = new BMI();
            bmi.WeightStones = 6;
            bmi.WeightPounds = 10;
            bmi.HeightInches = 1;
            bmi.HeightFeet = 4;

            //Act
            BMICategory expectedResult = bmi.BMICategory;

            //Assert
            Assert.AreEqual(BMICategory.Overweight, expectedResult);
        }

        [TestMethod]
        public void TestBMICategory_BMIValueIsObese_ReturnObese()
        {
            //Arrange
            BMI bmi = new BMI();
            bmi.WeightStones = 20;
            bmi.WeightPounds = 10;
            bmi.HeightInches = 10;
            bmi.HeightFeet = 5;

            //Act
            BMICategory expectedResult = bmi.BMICategory;

            //Assert
            Assert.AreEqual(BMICategory.Obese, expectedResult);
        }

        [TestMethod]
        public void TestCalorieRange_GenderIsMaleCaloriesAreLow_ReturnLow()
        {
            //Arrange
            BMI bmi = new BMI();
            bmi.PersonGender = "male";
            bmi.CaloriesIntake = 1800;

            //Act
            CalorieRange expectedResult = bmi.CalorieRange;

            //Assert
            Assert.AreEqual(CalorieRange.Low, expectedResult);
        }

        [TestMethod]
        public void TestCalorieRange_GenderIsFemaleCaloriesAreLow_ReturnLow()
        {
            //Arrange
            BMI bmi = new BMI();
            bmi.PersonGender = "female";
            bmi.CaloriesIntake = 1500;

            //Act
            CalorieRange expectedResult = bmi.CalorieRange;

            //Assert
            Assert.AreEqual(CalorieRange.Low, expectedResult);
        }

        [TestMethod]
        public void TestCalorieRange_GenderIsMaleCaloriesAreAverage_ReturnAverage()
        {
            //Arrange
            BMI bmi = new BMI();
            bmi.PersonGender = "male";
            bmi.CaloriesIntake = 2500;

            //Act
            CalorieRange expectedResult = bmi.CalorieRange;

            //Assert
            Assert.AreEqual(CalorieRange.Average, expectedResult);
        }

        [TestMethod]
        public void TestCalorieRange_GenderIsFemaleCaloriesAreAverage_ReturnAverage()
        {
            //Arrange
            BMI bmi = new BMI();
            bmi.PersonGender = "female";
            bmi.CaloriesIntake = 2200;

            //Act
            CalorieRange expectedResult = bmi.CalorieRange;

            //Assert
            Assert.AreEqual(CalorieRange.Average, expectedResult);
        }

        [TestMethod]
        public void TestCalorieRange_GenderIsMaleCaloriesAreHigh_ReturnHigh()
        {
            //Arrange
            BMI bmi = new BMI();
            bmi.PersonGender = "male";
            bmi.CaloriesIntake = 3500;

            //Act
            CalorieRange expectedResult = bmi.CalorieRange;

            //Assert
            Assert.AreEqual(CalorieRange.High, expectedResult);
        }

        [TestMethod]
        public void TestCalorieRange_GenderIsFemaleCaloriesAreHigh_ReturnHigh()
        {
            //Arrange
            BMI bmi = new BMI();
            bmi.PersonGender = "female";
            bmi.CaloriesIntake = 3200;

            //Act
            CalorieRange expectedResult = bmi.CalorieRange;

            //Assert
            Assert.AreEqual(CalorieRange.High, expectedResult);
        }

        [TestMethod]
        public void TestCalorieRange_GenderIsMaleCaloriesAreExcessive_ReturnExcessive()
        {
            //Arrange
            BMI bmi = new BMI();
            bmi.PersonGender = "male";
            bmi.CaloriesIntake = 5000;

            //Act
            CalorieRange expectedResult = bmi.CalorieRange;

            //Assert
            Assert.AreEqual(CalorieRange.Excessive, expectedResult);
        }

        [TestMethod]
        public void TestCalorieRange_GenderIsFemaleCaloriesAreExcessive_ReturnExcessive()
        {
            //Arrange
            BMI bmi = new BMI();
            bmi.PersonGender = "female";
            bmi.CaloriesIntake = 5000;

            //Act
            CalorieRange expectedResult = bmi.CalorieRange;

            //Assert
            Assert.AreEqual(CalorieRange.Excessive, expectedResult);


        }

    }
}
