﻿namespace FileFormat.AForge.Tests.NetStandard.AForge.Math.Tests.Geometry
{
    using FileFormat.AForge.Math.NetStandard.Geometry;
    using NUnit.Framework;

    [TestFixture]
    public class ClosePointsMergingOptimizerTest
    {
        private IShapeOptimizer optimizer = new ClosePointsMergingOptimizer( 3 );

        
        [TestCase( new int[] { 0, 0, 10, 0, 10, 10 }, new int[] { 0, 0, 10, 0, 10, 10 } )]
        [TestCase( new int[] { 0, 0, 10, 0, 1, 1 }, new int[] { 0, 0, 10, 0, 1, 1 } )]
        [TestCase( new int[] { 0, 0, 10, 0, 10, 10, 2, 2 }, new int[] { 1, 1, 10, 0, 10, 10 } )]
        [TestCase( new int[] { 0, 0, 10, 0, 10, 10, 3, 3 }, new int[] { 0, 0, 10, 0, 10, 10, 3, 3 } )]
        [TestCase( new int[] { 0, 0, 8, 0, 10, 2, 10, 10 }, new int[] { 0, 0, 9, 1, 10, 10 } )]
        [TestCase( new int[] { 2, 0, 8, 0, 10, 2, 10, 8, 8, 10, 0, 2 }, new int[] { 1, 1, 9, 1, 9, 9 } )]
        public void OptimizationTest( int[] coordinates, int[] expectedCoordinates )
        {
            ShapeOptimizerTestBase.TestOptimizer( coordinates, expectedCoordinates, this.optimizer );
        }
    }
}
