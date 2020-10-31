using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Interfaces *****\n");
            // Make an array of Shapes.
            Shape[] myShapes = { new Hexagon(), new Circle(), new Triangle("Joe"), new Circle("JoJo")};
            for (int i = 0; i < myShapes.Length; i++)
            {
                IPointy firstPointyItem = FindFirstPointyShape(myShapes);
                Console.WriteLine("The item has {0} points", firstPointyItem.Points);

                // Recall the Shape base class defines an abstract Draw()
                // member, so all shapes know how to draw themselves.
                myShapes[i].Draw();
                // Who's pointy?
                if (myShapes[i] is IPointy ip)
                    Console.WriteLine("-> Points: {0}", ip.Points);
                else
                    Console.WriteLine("-> {0}\'s not pointy!", myShapes[i].PetName);

                if (myShapes[i] is IDraw3D)
                    DrawIn3D((IDraw3D)myShapes[i]);

                IPointy[] myPointyObjects = {new Hexagon(), new Knife(), new Triangle(), new Fork(), new PitchFork()};
                foreach (IPointy it in myPointyObjects)
                    Console.WriteLine("Object has {0} points.", it.Points);
                Console.WriteLine();
            }

            Console.ReadLine();
        }

        static void DrawIn3D(IDraw3D itf3d)
        {
            Console.WriteLine("-> Drawing IDraw3D compatible type");
            itf3d.Draw3D();
        }

        static IPointy FindFirstPointyShape(Shape[] shapes)
        {
            foreach (Shape s in shapes)
            {
                if (s is IPointy ip)
                    return ip;
            }
            return null;
        }
    }
}
