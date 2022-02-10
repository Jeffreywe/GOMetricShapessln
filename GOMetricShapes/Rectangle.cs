using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOMetricShapes {


    public class Rectangle {

        public int Height { get; set; }
        public int Width { get; set; }

        public Rectangle(int height, int width) {
            Height = height;
            Width = width;
        }

        //method called PrintPerimeter
        public void PrintPerimeter() {
            int perimeter = (Height + Width) * 2;
            Console.WriteLine($"A rectangle with a height of {Height} " +
                              $"and width of {Width} " +
                              $"has a perimeter of {perimeter}");
        }
        //method called PrintArea
        public void PrintArea() {
            int area = Height * Width;
            Console.WriteLine($"A rectangle with a height of {Height} " +
                              $"and a width of {Width} " +
                              $"has a area of {area}");

        }

    }
}

/* we created the rectangle class, and created public int values,
 * height and width, and then we created a constructor method to 
 * assign the height and width values
 * then, we created the PrintPerimeter() method and named a value perimeter which would give us
 * the answer to height + width * 2
 * and then we created a console.WriteLine using interpolated string
 * that gave us the values of height, width, and perimeter
 * 
*/
