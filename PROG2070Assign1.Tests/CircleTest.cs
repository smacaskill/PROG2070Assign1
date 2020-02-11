using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

namespace PROG2070Assign1.Tests
{
    [TestFixture]
    public class CircleTest
    {
        [Test]
        public void GetRadiusMethod_ConstructorSetsTo_1()
        {
            int radius = 5;

            Circle circle = new Circle();

            radius = circle.GetRadius();

            Assert.AreEqual(1, radius);
        }

        [Test]
        public void SetRadiusMethod_SetTo25_CircleRadiusEquals25()
        {
            int radius = 25;

            Circle circle = new Circle();

            circle.SetRadius(radius);

            Assert.AreEqual(25, circle.GetRadius());

        }

        [Test]
        public void GetCircumfrenceMethod_SetCircleRadiusTo35_CircumferenceCalculationUsing35Radius()
        {
            int radius = 35;

            Circle circle = new Circle();

            circle.SetRadius(radius);

            Assert.AreEqual(2 * Math.PI * 35, circle.GetCircumference());
        }

        [Test]
        public void GetAreaMethod_SetCircleRadiusTo45_AreaCalculationUsing45Radius()
        {
            int radius = 45;

            Circle circle = new Circle();

            circle.SetRadius(radius);

            Assert.AreEqual(Math.PI * 45 * 45, circle.GetArea());
        }

        
    }
}
