using OOP06.Abstraction;
using OOP06.Abstraction.Static;

namespace OOP06
{
    internal class Program
    {
        #region OOP06 Abstraction Class
        static void processShape(Shape shape)
        {
            if (shape != null)
            {
                Console.WriteLine();
                Console.WriteLine($"Area Of Shape :{shape.CalcArea()}");
                Console.WriteLine($"Perimeter Of Shape :{shape.Perimeter}");
                Console.WriteLine("...................................................................");
            }
        }
        static void Draw_2D_Shape(ITwoDrawDim _2DShape)
        {
            _2DShape.Draw();
        }
        static void Draw_3D_Shape(IThreeDrawDim _3DShape)
        {
            _3DShape.Draw();
        }
        #endregion
        static void Main(string[] args)
        {

            #region OOP06 Abstraction Class V1

            //Rectangle rectangle = new Rectangle()
            //{
            //    Dim01 = 10,
            //    Dim02 = 20
            //};
            //processShape(rectangle);
            ////Console.WriteLine($"rectangle CalcArea {rectangle.CalcArea()}");
            ////Console.WriteLine($"rectangle Perimeter {rectangle.Perimeter}");


            //Square square = new Square(10);
            //processShape(square);
            ////Console.WriteLine($"Square CalcArea {square.CalcArea()}");
            ////Console.WriteLine($"Square Perimeter {square.Perimeter}");



            //Circle circle = new Circle(10);
            //processShape(circle);
            ////Console.WriteLine($"Circle CalcArea {circle.CalcArea()}");
            ////Console.WriteLine($"Circle Perimeter {circle.Perimeter}");


            ////Shape shapRef = new Circle(20);

            ////Console.WriteLine($"Circle CalcArea {shapRef.CalcArea()}");
            ////Console.WriteLine($"Circle Perimeter {shapRef.Perimeter}");
            //Shape s = new Circle(10);
            //processShape(s);
            #endregion
            // no V2
            #region V3
            //Utilty ut01 = new Utilty(10, 20);
            ////Console.WriteLine(ut01.MterToCM(1.2));

            //ut01.X = 10;
            //ut01.Y = 20;
            ////Console.WriteLine("After => " + ut01.MterToCM(1.2));



            //Utilty ut02 = new Utilty(30, 40);

            ////Console.WriteLine(ut02.MterToCM(2));

            //Console.WriteLine(Utilty.CalcArea(2)); // non static method shold be called by object
            //Utilty u03 = new Utilty(20, 2);
            ////Console.WriteLine(u03.CalcArea(2));
            //Console.WriteLine(Utilty.MterToCM(2));

            Utilty u04 = new Utilty(10, 20);

            //u04.Pi = 100;  // readonly property not allow to set value

            Console.WriteLine(u04.Pi); //  - > initialized by static constructor = 3.14159
            // Console.WriteLine(u04.i); // static member should be called by class name not by object

            Console.WriteLine(Utilty.i); // static member should be called by class name not by object
                                         // Utilty.i = 200; // static member can be assigned in static method if it is not readonly => Invalid
                                         //Test test = new Test(); 
            #endregion

            #region V5 Seald

            #endregion

        }
    }
}
