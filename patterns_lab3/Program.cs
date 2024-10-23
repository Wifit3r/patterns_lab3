using patterns_lab3;

namespace pattern_lab3
{
    class Program
    {
        static void Main()
        {
            House[,] houseMatrix = new House[4, 4]
            {
                { new House("123 Main St", 0), new House("124 Main St", 3), new House("123 Main St", 0), new House("124 Main St", 3) },
                { new House("125 Main St", 5), new House("126 Main St", 2), new House("123 Main St", 0), new House("124 Main St", 3) },
                { new House("123 Main St", 0), new House("124 Main St", 3), new House("123 Main St", 0), new House("124 Main St", 3) },
                { new House("123 Main St", 1), new House("124 Main St", 3), new House("123 Main St", 0), new House("124 Main St", 3) }

            };
            MyIteratorSimple it = new MyIteratorSimple(houseMatrix);
            for (int i = 0; i < houseMatrix.GetLength(0); i++)
            {
                for(int j = 0; j < houseMatrix.GetLength(1); j++)
                {
                    Console.WriteLine(houseMatrix[i, j]);
                }
            }
            Console.WriteLine("------");
            Console.WriteLine(it.Iterate());
            Console.WriteLine(it.IterateSpiral());
        }
    }
}