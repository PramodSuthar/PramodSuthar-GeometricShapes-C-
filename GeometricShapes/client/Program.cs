using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometricShapes.bus;

namespace GeometricShapes.client
{
    class Program
    {
     //--1--
        public static List<Square> GetSquaresList(List<Shape> shapesList)
        {
            List<Square> squaresList = new List<Square>();
            foreach (Shape record in shapesList)
            {
                if (record is Square)
                {
                    squaresList.Add((Square)record);
                }
            }
            return squaresList;
        }
     // --2--
        public static List<Circle> GetCirclesList(List<Shape> shapesList)
        {
            List<Circle> circlesList = new List<Circle>();
            foreach (Shape record in shapesList)
            {
                if (record is Circle)
                {
                    circlesList.Add((Circle)record);
                }
            }
            return circlesList;
        }
     //--3--
        public static void PrintShapesList(List<Shape> shapesList)
        {
            foreach (Shape record in shapesList)
            {
                Console.WriteLine(record);
            }
        }
     //--4--
        public static void PrintCirclesList(List<Shape> shapesList)
        {
            foreach (Circle record in GetCirclesList(shapesList))
            {
                Console.WriteLine(record);
            }
        }
     //--5--
        public static void PrintSquaresList(List<Shape> shapesList)
        {
            foreach (Square record in GetSquaresList(shapesList))
            {
                Console.WriteLine(record);
            }
        }  
     //--6--
        public static void Update(List<Shape> shapesList, int key)
        {
           int index = SearchIndex(shapesList, key);
            if (index != -1)
            {
                Console.WriteLine("Enter the new color: ");
                shapesList[index].Color = Console.ReadLine();                                           
                Console.WriteLine("SHAPE UPDATED ");
            }
        }
     //--7--
        public static void Remove(List<Shape> shapesList, int key)
        {
            Shape shapeFound = null;
            shapeFound = SearchObject(shapesList, key);
            if (shapeFound != null) { shapesList.Remove(shapeFound); }
        }
    //--8--
        public static int  RemoveAt(List<Shape> shapesList, int key)
        {
                int index = SearchIndex( shapesList, key);         
                if (index != -1) { shapesList.RemoveAt(index); }
                return index;
        }
     //--9--
        public static Shape SearchObject(List<Shape> shapesList , int key)
        {
            bool found = false;
            Shape shapeFound = null;       
            foreach (Shape record in shapesList)
            {
                if (record.IdNumber == key)
                {
                    shapeFound = record;  found = true;  break;
                }
            }
            if (found) { return shapeFound; }
            else return null;
        }
     //--10--
        public static int SearchIndex(List<Shape> shapesList, int key)
        {
            int position = -1;
            for (int index = 0; index < shapesList.Count; index++)
            {
                if (shapesList[index].IdNumber == key)
                {
                    position = index;
                }
            }
            return position;
        }
        /////////////////
       //Entry point of the application
       ///////////////////////////// 
        public static void Main(string[] args)
        {
            List<Shape> shapesList = new List<Shape>();
            List<Square> squaresList = new List<Square>();
            List<Circle> circlesList = new List<Circle>();

            Shape shapeFound = null; int key; int choice; int position;

            Shape square1 = new Square(01, "rose", EnumShapeType.Square, 5);
            shapesList.Add(square1);
            Shape square2 = new Square(02, "violet", EnumShapeType.Square, 12);
            shapesList.Add(square2);
            Shape circle1 = new Circle(03, "green", EnumShapeType.Circle, 2);
            shapesList.Add(circle1);
            Shape circle2 = new Circle(04, "yellow", EnumShapeType.Circle, 7);
            shapesList.Add(circle2);

            do
            {
                Console.Write("\n");
                Console.Write("\n\t****************************");
                Console.Write("\n\t***  1 - Search          ***");
                Console.Write("\n\t***  2 - Update          ***");
                Console.Write("\n\t***  3 - Remove          ***");
                Console.Write("\n\t***  4 - Print shapes    ***");
                Console.Write("\n\t***  5 - Print squares   ***");
                Console.Write("\n\t***  6 - Print circles   ***");
                Console.Write("\n\t***  7 - Exit            ***");
                Console.Write("\n\t*****************************");
                Console.Write("\n\t         Enter your choice: ");              
                         choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1://SEARCH
                        ////2d way:
                                Console.Write("\n Enter a serial number for the shape to search for: ");
                                key = Convert.ToInt32(Console.ReadLine());
                                shapeFound = SearchObject(shapesList, key);
                                if (shapeFound != null) { Console.Write("Shape found \n\t " + shapeFound.ToString()); }
                                else { Console.Write("Shape not found "); }
                                break;

                    ////2d way:
                    //Console.Write("\n Enter a serial number for the shape to search for: ");
                    //key = Convert.ToInt32(Console.ReadLine());
                    //position= SearchIndex(shapesList, key);
                    //if (position != -1) { Console.Write("\n Shape found \n\t" + shapeFound.ToString()); }
                    //else { Console.Write("\n Shape not found "); }
                    //break;                                        
                    case 2: //UPDATE
                            Console.Write("\n Enter a serial number for the shape to update: ");
                            key = Convert.ToInt32(Console.ReadLine());
                            Update(shapesList, key);
                            break;   
                    case 3:  //REMOVE     
                           //1st way:
                                    Console.Write("\n Enter a serial number of the shape to remove: ");
                                    key = Convert.ToInt32(Console.ReadLine());
                                    position = RemoveAt(shapesList, key);
                                    if (position != -1) { Console.Write("\n Shape found \n\t " + shapesList[position].ToString());  Console.Write("\n Shape REMOVED"); }
                                          else { Console.Write("\n Shape not found "); }
                                    break;
                    //2d way:
                    //Console.Write("\n Enter a serial number of the shape to remove: ");
                    //key = Convert.ToInt32(Console.ReadLine());
                    //shapeFound = Remove(shapesList, key);
                    //if (shapeFound != null) { Console.Write("\n Shape found \n\t" + shapeFound.ToString()); shapesList.Remove(shapeFound); Console.Write("\n Shape REMOVED" ); }
                    //     else { Console.Write("\n Shape not found "); 
                    // break;                                                               
                    case 4: 
                        Console.WriteLine("\n Shapes List. ");
                        PrintShapesList(shapesList);
                        break;                                                        
                    case 5:
                        Console.WriteLine("\n Squares List. ");
                        PrintSquaresList(shapesList);
                        break;
                    case 6:
                        Console.WriteLine("\n Circless List. ");
                        PrintCirclesList(shapesList);                     
                        break;
                    case 7:                        
                        break;
                }
            } while (choice != 7);
         Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<END>>>>>>>>>>>>>>>>>");
         Console.ReadKey();
        }
    }
}
