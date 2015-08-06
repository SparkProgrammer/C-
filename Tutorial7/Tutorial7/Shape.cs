/*
 * Coded by: Concord Spark Tutor
 * Date: June 28, 2015
 * Purpose: A rudimentary inheritance hierarchy designed to demonstrate virtual method overriding
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7___More_on_Inheritance
{
    abstract class Shape
    {
        public virtual String GetDimensions()
        {
            return "This shape has no dimensions.";
        }
    }

    class Circle : Shape
    {
        public override string GetDimensions()
        {
            return "PI * Circumference";
        }
    }

    class Square : Shape
    {
        public override string GetDimensions()
        {
            return "Width * Height";
        }
    }
}
