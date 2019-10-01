using System;

namespace PulsionTechTest
{
    /// <summary>
    /// Star class containing shine factors, names and events that the star can do.
    /// </summary>
    public class Star
    {
        #region Fields
        private double shineFactor;
        public string Name;
        #endregion

        #region Contructor
        public Star(double _shineFactor)
        {
            this.shineFactor = _shineFactor;
        }
        #endregion

        #region Program Entry

        public static void Main(string[] args)
        {
            // Code for debugging the test case NewStarsCanShine
            double shineFactor = 1d;
            Star star = new Star(shineFactor);
            Console.WriteLine($"Are equal: {object.Equals(shineFactor, star.Shine())}, expected: {shineFactor}, actual: {star.Shine()}");

            // Code for debugging the case StarsCanBeNamed
            double starsNamedShineFactor = 0.8d;
            Star starName = new Star(starsNamedShineFactor);
            starName.Name = "Sun";
            Console.WriteLine($"Stars can be named: {Equals(starName.Name, "Sun")}, expected: {starName.Name}, actual: Sun");

            // Code for faded out stars cannot shine
            try
            {
                double cannotShineFactor = 1.5d;
                Star cannotShineStar = new Star(cannotShineFactor);
                star.FadeOut();
                cannotShineStar.Shine();
                Console.WriteLine("This star can shine");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);           
            }
        }
        #endregion

        #region Methods

        /// <summary>
        /// Return the Shine Factor
        /// </summary>
        /// <returns></returns>
        public double Shine()
        {
            if (shineFactor % 1 == 0)
            {
                return shineFactor;             
            }
            else
            {
                throw new InvalidOperationException("Faded out stars cannot shine.");
            }
        }

        /// <summary>
        /// Star fades out
        /// </summary>
        public void FadeOut()
        {
            
        }

        #endregion

    }
}