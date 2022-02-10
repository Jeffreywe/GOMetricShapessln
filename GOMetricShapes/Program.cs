using System;

namespace GOMetricShapes {
    class Program {
        static void Main(string[] args) {

            Rectangle rect = new Rectangle(2, 5);
            rect.PrintPerimeter();
            rect.PrintArea();

        }
    }
}
/* we are calling on the class Rectangle and naming the property value
rect and assigning it the values new Rectangle(2, 5);
then, we are linking rect to .PrintPerimeter(); console write line 
to assign the values to our width, and height.
*/