using NUnit.Framework;
using nzy3D.Plot3D.Builder.Delaunay.Jdt;
using System;
using TechTalk.SpecFlow;

namespace nzy3d_tests
{
    [Binding]
    public class Triangle_DtSteps
    {

        Triangle_dt triangle;
        Point_dt point;

        [Given(@"I have an initial test setup")]
        public void GivenIHaveAnInitialTestSetup()
        {
            System.Configuration.ConfigurationManager.RefreshSection("appSettings");
            bool launchDebuger = false;
            Boolean.TryParse(System.Configuration.ConfigurationManager.AppSettings["launchDebugger"], out launchDebuger);
            if (launchDebuger)
                System.Diagnostics.Debugger.Launch();
        }

        [Given(@"I have a triangle with coordinates \((.*),(.*)\)-\((.*),(.*)\)-\((.*),(.*)\)")]
        public void GivenIHaveATriangleWithCoordinates__(double p0, double p1, double p2, double p3, double p4, double p5)
        {
            triangle = new Triangle_dt(new Point_dt(p0, p1), new Point_dt(p2, p3), new Point_dt(p4, p5));
        }

        [Then(@"the triangle has coordinates \((.*),(.*)\)-\((.*),(.*)\)-\((.*),(.*)\)")]
        public void ThenTheTriangleHasCoordinates__(double p0, double p1, double p2, double p3, double p4, double p5)
        {
            Assert.AreEqual(p0, triangle.a.x, "Unexpected coordinate for a.x");
            Assert.AreEqual(p1, triangle.a.y, "Unexpected coordinate for a.y");
            Assert.AreEqual(p2, triangle.b.x, "Unexpected coordinate for b.x");
            Assert.AreEqual(p3, triangle.b.y, "Unexpected coordinate for b.y");
            Assert.AreEqual(p4, triangle.c.x, "Unexpected coordinate for c.x");
            Assert.AreEqual(p5, triangle.c.y, "Unexpected coordinate for c.y");
        }

        [Given(@"I have a point with coordinates \((.*),(.*)\)")]
        public void GivenIHaveAPointWithCoordinates(double p0, double p1)
        {
            point = new Point_dt(p0, p1);
        }

        [Then(@"The point is inside the triangle")]
        public void ThenThePointIsInsideTheTriangle()
        {
            Assert.IsTrue(triangle.contains(point), "Point is not inside the triangle");
        }

        [Then(@"The point is outside the triangle")]
        public void ThenThePointIsOutsideTheTriangle()
        {
            Assert.IsFalse(triangle.contains(point), "Point is inside the triangle");
        }

        [Then(@"The point is on the boundary of the triangle")]
        public void ThenThePointIsOnTheBoundaryOfTheTriangle()
        {
            Assert.IsTrue(triangle.contains(point), "Point is not inside the triangle");
            Assert.IsFalse(triangle.contains_BoundaryIsOutside(point), "Point is inside the triangle, boundary excluded");
        }

    }
}
