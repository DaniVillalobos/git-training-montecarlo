/// <summary>
bug/1-generate-better-random-numbers
/// The MonteCarloPI.cs file
/// </summary>
namespace MontecarloAlgorithms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The MonteCarloPI implementation

/// MonteCarloPI.cs 
/// </summary>
namespace MontecarloAlgorithms
{
    using System.Collections.Generic;
    using System.Linq;
    using System;

    /// <summary>
    /// MonteCarloPI class
develop
    /// </summary>
    public class MonteCarloPI
    {
        /// <summary>
        /// Internal declaration of points dictionary
        /// </summary>
        private List<MPoint> points;
bug/1-generate-better-random-numbers
        private Random rnd;
        public List<MPoint> Points { get { return points; } }

        /// <summary>
        /// The MonteCarloPI constructor.
        /// </summary>
        public MonteCarloPI()
        {
            this.rnd = new Random();
            this.points = new List<MPoint>();
        }

        /// <summary>
        /// Method to generate a new point.


        /// <summary>
        /// The public declaration of points.
        /// </summary>
        public List<MPoint> Points { get { return points; } }

        /// <summary>
        /// Use this method to generate a new point.
 develop
        /// </summary>
        public void GeneratePoint()
        {
            MPoint newPoint = GenerateRandomPoint();
            this.points.Add(newPoint);
        }

        /// <summary>
 bug/1-generate-better-random-numbers
        /// Method to generate PI.
        /// </summary>
        /// <returns></returns>

        /// Returns PI value
        /// </summary>
        /// <returns>The PI approximation</returns>
develop
        public float GetPI()
        {
            int circleCounter = this.points.Count(x=>x.InsideCircle);
            int rectangleCounter = this.points.Count;

            return 4.0f * circleCounter / rectangleCounter;
        }

        /// <summary>
bug/1-generate-better-random-numbers
        /// Generates a new random point.
        /// </summary>
        /// <returns>An instance of MPoint.</returns>

        /// Constructor
        /// </summary>
        public MonteCarloPI()
        {
            this.points = new List<MPoint>();
        }

        /// <summary>
        /// Generates a new random point
        /// </summary>
        /// <returns>The random point</returns>
develop
        private MPoint GenerateRandomPoint()
        {
            float x = GenerateRandomValue();
            float y = GenerateRandomValue();

            double ratio = Math.Sqrt(x * x + y * y);
            bool insideCircle = ratio <= 0.5;

            MPoint newOne = new MPoint(x, y, insideCircle);
            return newOne;
        }

        /// <summary>
bug/1-generate-better-random-numbers
        /// Generates the random coordinates.
        /// </summary>
        /// <returns>The random value.</returns>
        private float GenerateRandomCoordinate()

        /// Generates a random value
        /// </summary>
        /// <returns>The random value</returns>
        private float GenerateRandomValue()
develop
        {
            return (float)rnd.NextDouble() - 0.5f;
        }
    }
}
