﻿using System;
using NUnit.Framework;

namespace Manipulation
{
    public static class ManipulatorTask
    {

        /// <summary>
        /// Возвращает массив углов (shoulder, elbow, wrist),
        /// необходимых для приведения эффектора манипулятора в точку x и y 
        /// с углом между последним суставом и горизонталью, равному angle (в радианах)
        /// См. чертеж manipulator.png!
        /// </summary>
        public static double[] MoveManipulatorTo(double x, double y, double angle)
        {
            // Используйте поля Forearm, UpperArm, Palm класса Manipulator
            return new[] { double.NaN, double.NaN, double.NaN };
        }
    }

    [TestFixture]
    public class ManipulatorTask_Tests
    {
        [Test]
        public void TestMoveManipulatorTo()
        {
            Assert.Fail("Write real tests here!");
        }
    }
}