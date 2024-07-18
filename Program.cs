namespace CSharp_DZ_7_1_Dedok
{
    //5
    namespace Transportation
    {
        public abstract class Vehicle
        {
            public string Name { get; set; }
            public string Model { get; set; }
            public double FuelConsumption { get; set; }
            public double Cost { get; set; }
            public double CargoCapacity { get; set; }
            public int PassengerCapacity { get; set; }

            public Vehicle(string name, string model)
            {
                Name = name;
                Model = model;
            }

            public abstract void Input();
            public abstract void Output();
            public abstract double CalculateFuelConsumption(double distance);
            public abstract double GetCost();
            public abstract void SetCost(double cost);
            public abstract double GetCargoCapacity();
            public abstract int GetPassengerCapacity();
        }

        public class Car : Vehicle
        {
            public Car(string name, string model, double fuelConsumption, double cost, double cargoCapacity, int passengerCapacity)
                : base(name, model)
            {
                FuelConsumption = fuelConsumption;
                Cost = cost;
                CargoCapacity = cargoCapacity;
                PassengerCapacity = passengerCapacity;
            }

            public override void Input()
            {
                Console.WriteLine("Введите информацию о автомобиле:");
                Console.Write("Название: ");
                Name = Console.ReadLine();
                Console.Write("Модель: ");
                Model = Console.ReadLine();
                Console.Write("Расход топлива (л/100 км): ");
                FuelConsumption = Convert.ToDouble(Console.ReadLine());
                Console.Write("Стоимость: ");
                Cost = Convert.ToDouble(Console.ReadLine());
                Console.Write("Грузоподъёмность (кг): ");
                CargoCapacity = Convert.ToDouble(Console.ReadLine());
                Console.Write("Количество мест для пассажиров: ");
                PassengerCapacity = Convert.ToInt32(Console.ReadLine());
            }

            public override void Output()
            {
                Console.WriteLine($"Автомобиль {Name} {Model}");
                Console.WriteLine($"Расход топлива: {FuelConsumption} л/100 км");
                Console.WriteLine($"Стоимость: {Cost} USD");
                Console.WriteLine($"Грузоподъёмность: {CargoCapacity} кг");
                Console.WriteLine($"Количество мест для пассажиров: {PassengerCapacity}");
            }

            public override double CalculateFuelConsumption(double distance)
            {
                return (FuelConsumption / 100) * distance;
            }

            public override double GetCost()
            {
                return Cost;
            }

            public override void SetCost(double cost)
            {
                Cost = cost;
            }

            public override double GetCargoCapacity()
            {
                return CargoCapacity;
            }

            public override int GetPassengerCapacity()
            {
                return PassengerCapacity;
            }
        }

        public class Plane : Vehicle
        {
            public Plane(string name, string model, double fuelConsumption, double cost, double cargoCapacity, int passengerCapacity)
                : base(name, model)
            {
                FuelConsumption = fuelConsumption;
                Cost = cost;
                CargoCapacity = cargoCapacity;
                PassengerCapacity = passengerCapacity;
            }

            public override void Input()
            {
                Console.WriteLine("Введите информацию о самолёте:");
                Console.Write("Название: ");
                Name = Console.ReadLine();
                Console.Write("Модель: ");
                Model = Console.ReadLine();
                Console.Write("Расход топлива (л/100 км): ");
                FuelConsumption = Convert.ToDouble(Console.ReadLine());
                Console.Write("Стоимость: ");
                Cost = Convert.ToDouble(Console.ReadLine());
                Console.Write("Грузоподъёмность (кг): ");
                CargoCapacity = Convert.ToDouble(Console.ReadLine());
                Console.Write("Количество мест для пассажиров: ");
                PassengerCapacity = Convert.ToInt32(Console.ReadLine());
            }

            public override void Output()
            {
                Console.WriteLine($"Самолёт {Name} {Model}");
                Console.WriteLine($"Расход топлива: {FuelConsumption} л/100 км");
                Console.WriteLine($"Стоимость: {Cost} USD");
                Console.WriteLine($"Грузоподъёмность: {CargoCapacity} кг");
                Console.WriteLine($"Количество мест для пассажиров: {PassengerCapacity}");
            }

            public override double CalculateFuelConsumption(double distance)
            {
                return (FuelConsumption / 100) * distance;
            }

            public override double GetCost()
            {
                return Cost;
            }

            public override void SetCost(double cost)
            {
                Cost = cost;
            }

            public override double GetCargoCapacity()
            {
                return CargoCapacity;
            }

            public override int GetPassengerCapacity()
            {
                return PassengerCapacity;
            }
        }
        //6
        namespace GeometricFigures
        {
            public abstract class GeometricFigure
            {
                public abstract double Area();
                public abstract double Perimeter();
            }

            public class Triangle : GeometricFigure
            {
                private double a, b, c;

                public Triangle(double a, double b, double c)
                {
                    this.a = a;
                    this.b = b;
                    this.c = c;
                }

                public override double Area()
                {
                    double s = Perimeter() / 2;
                    return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
                }

                public override double Perimeter()
                {
                    return a + b + c;
                }
            }

            public class Square : GeometricFigure
            {
                private double side;

                public Square(double side)
                {
                    this.side = side;
                }

                public override double Area()
                {
                    return side * side;
                }

                public override double Perimeter()
                {
                    return 4 * side;
                }
            }

            public class Rhombus : GeometricFigure
            {
                private double d1, d2;

                public Rhombus(double d1, double d2)
                {
                    this.d1 = d1;
                    this.d2 = d2;
                }

                public override double Area()
                {
                    return (d1 * d2) / 2;
                }

                public override double Perimeter()
                {
                    double side = Math.Sqrt((d1 / 2) * (d1 / 2) + (d2 / 2) * (d2 / 2));
                    return 4 * side;
                }
            }

            public class Rectangle : GeometricFigure
            {
                private double length, width;

                public Rectangle(double length, double width)
                {
                    this.length = length;
                    this.width = width;
                }

                public override double Area()
                {
                    return length * width;
                }

                public override double Perimeter()
                {
                    return 2 * (length + width);
                }
            }

            public class Circle : GeometricFigure
            {
                private double radius;

                public Circle(double radius)
                {
                    this.radius = radius;
                }

                public override double Area()
                {
                    return Math.PI * radius * radius;
                }

                public override double Perimeter()
                {
                    return 2 * Math.PI * radius;
                }
            }

            public class CompositeFigure : GeometricFigure
            {
                private List<GeometricFigure> figures = new List<GeometricFigure>();

                public void AddFigure(GeometricFigure figure)
                {
                    figures.Add(figure);
                }

                public override double Area()
                {
                    double totalArea = 0;
                    foreach (var figure in figures)
                    {
                        totalArea += figure.Area();
                    }
                    return totalArea;
                }

                public override double Perimeter()
                {
                    throw new NotImplementedException("Perimeter is not defined for composite figure.");
                }
            }
            internal class Program
            {
                static void Main(string[] args)
                {
                    Console.WriteLine("Task 5:");
                    //Task_5 - Реализовать иерархию классов «Транспортное средство».
                    //В абстрактном базовом классе реализовать набор абстрактных методов
                    //(ввод-вывод, расход топлива, получение стоимости, установка стоимости, грузоподъёмность, количество мест для пассажиров).
                    //Потомки переопределяют абстрактные методы. Создать массив ссылок на базовый класс. Каждый элемент указывает на объект потомка.
                    Vehicle[] vehicles = new Vehicle[2];
                    vehicles[0] = new Car("Tesla", "Model S", 15, 80000, 500, 5);
                    vehicles[1] = new Plane("Boeing", "737", 3000, 100000000, 20000, 150);
                    foreach (var vehicle in vehicles)
                    {
                        vehicle.Output();
                        Console.WriteLine();
                    }
                    Console.WriteLine("Task 6:");
                    //Task_6 - Разработать абстрактный класс «Геометрическая Фигура» с методами «Площадь Фигуры» и «Периметр Фигуры».
                    //Разработать классы-наследники: Треугольник, Квадрат, Ромб, Прямоугольник, Круг.
                    //Реализовать конструкторы, которые однозначно определяют объекты данных классов.
                    //Реализовать класс «Составная Фигура», который может состоять из любого количества «Геометрических Фигур».
                    //Для данного класса определить метод нахождения площади фигуры. 
                    Triangle triangle = new Triangle(3, 4, 5);
                    Square square = new Square(4);
                    Rhombus rhombus = new Rhombus(6, 8);
                    Rectangle rectangle = new Rectangle(3, 7);
                    Circle circle = new Circle(5);

                    Console.WriteLine($"Triangle: Area = {triangle.Area()}, Perimeter = {triangle.Perimeter()}");
                    Console.WriteLine($"Square: Area = {square.Area()}, Perimeter = {square.Perimeter()}");
                    Console.WriteLine($"Rhombus: Area = {rhombus.Area()}, Perimeter = {rhombus.Perimeter()}");
                    Console.WriteLine($"Rectangle: Area = {rectangle.Area()}, Perimeter = {rectangle.Perimeter()}");
                    Console.WriteLine($"Circle: Area = {circle.Area()}, Perimeter = {circle.Perimeter()}");

                    CompositeFigure compositeFigure = new CompositeFigure();
                    compositeFigure.AddFigure(triangle);
                    compositeFigure.AddFigure(square);
                    compositeFigure.AddFigure(rhombus);
                    compositeFigure.AddFigure(rectangle);
                    compositeFigure.AddFigure(circle);

                    Console.WriteLine($"Composite Figure: Total Area = {compositeFigure.Area()}");
                }
            }
        }
    }
}