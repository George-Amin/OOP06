using OOP06.Abstraction;

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



        }
    }
}
