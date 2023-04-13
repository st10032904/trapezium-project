using System;

namespace abstraction
{
    internal class Class1
    {
        private double topBase = 0;
        private double bottomBase = 0;
        private double leftBase = 0;
        public Class1(Double topBase, Double lowerBase, Double height)
        {
            this.topBase = topBase;
            this.bottomBase = lowerBase;
            this.leftBase = height;
        }

        public String calculateArea()
        {
            double result  = (topBase + bottomBase) / 2 * leftBase;
            return "The area is " + result;
        }
    }
}
