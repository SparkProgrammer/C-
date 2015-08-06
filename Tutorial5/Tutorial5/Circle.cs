using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial5
{
    class Circle
    {
        private double radius;

        #region properties
        /// <summary>
        /// Allows one to set ande get the radius of this Circle
        /// </summary>
        public double Radius
        {
            set
            {
                if (value >= 0.0)
                {
                    radius = value;
                }
            }
            get
            {
                return radius;
            }
        }
        /// <summary>
        /// Allows one to set and get the Diameter of this Circle
        /// </summary>
        public double Diameter
        {
            set
            {
                if (value >= 0.0)
                {
                    radius = value / 2;
                }
            }
            get
            {
                return radius * 2;
            }
        }
        /// <summary>
        /// Allows one to get the Circumference of this Circle
        /// </summary>
        public double Circumference
        {
            get
            {
                return radius * 2 * 3.14159;
            }
        }
        /// <summary>
        /// Allows one to get the ShapeName of this Circle
        /// </summary>
        public String ShapeName
        {
            get
            {
                return "Circle";
            }
        }
        #endregion

        #region methods

        public Circle()
        {
            radius = 0.0;
        }
        /// <summary>
        /// Allows one to get the Diameter of this Circle.
        /// </summary>
        /// <returns> returns the Diameter</returns>
        public override string ToString()
        {
            return (radius * 2 * 3.14159).ToString();
        }

        #endregion

    }
}
