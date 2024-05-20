using System;

class Program
{
    static void Main(string[] args)
    {
        // double areaSquare;
        // double areaRectangle;
        // double areaCircle;

        List<Shape> shapes = new List<Shape>();

        Console.WriteLine();

        Square sqr = new Square("Blue", 4);
        shapes.Add(sqr);

        Rectangle rec = new Rectangle("Red", 4, 2);
        shapes.Add(rec);

        Circle cir = new Circle("Yellow", 3);
        shapes.Add(cir);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area  = s.GetArea();
            string name  = s.GetName();

            // Console.WriteLine($"The area of the {color} {name} is {area.ToString()}");
            Console.WriteLine($"The area of the {color} {name} is {area}");
        }

        // Square sqr = new Square("Blue", 4);
        // areaSquare = sqr.GetArea();
        // Console.WriteLine($"The area of the square is {areaSquare.ToString()}");
        
        // Rectangle rec = new Rectangle("Red", 4, 2);
        // areaRectangle = rec.GetArea();
        // Console.WriteLine($"The area of the rectangle is {areaRectangle.ToString()}");
        
        // Circle cir = new Circle("Yellow", 3);
        // areaCircle = cir.GetArea();
        // Console.WriteLine($"The area of the circle is {areaCircle.ToString()}");
    
        Console.WriteLine();
    }
}