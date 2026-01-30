namespace Övning_9._6___Area_under_kurva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double startX = -1;
            double endX = 4;
            double width = 0.000001; // width of each rectangle
            double totalArea = 0.0; // total area
            int rectangleNumber = 1;

            for (double x = startX; x < endX; x = x + width)
            {
                double height = -0.1 * x * x + 5;
                double rectangleArea = height * width;

                totalArea += rectangleArea;

                //Console.WriteLine($"Rektangel {rectangleNumber}: x={x}, rektangelarea={rectangleArea} ");
                //rectangleNumber++;
            }
            Console.WriteLine($"Total area: {totalArea}");
        }
    }
}
