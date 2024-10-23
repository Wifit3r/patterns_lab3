using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patterns_lab3
{
    internal class MyIteratorSimple: MyIterable<House>
    {
        private House[,] HousesMatrix;
        private int _col;
        private int _row;
        public MyIteratorSimple(House[,] hosesMatrix)
        {
            HousesMatrix = hosesMatrix;
            _col = 0;
            _row = 0;
        }
        public bool HasNext()
        {
            return _row< HousesMatrix.GetLength(0)&& _col<HousesMatrix.GetLength(1);
        }
        public int Iterate()
        {
            _col = HousesMatrix.GetLength(1) - 1;
            _row = 0;
            int counter = 0;

            for (int i = 0; i < HousesMatrix.GetLength(0) + HousesMatrix.GetLength(1); i++)
            {
                if (_row % 2 != 0)
                {
                    
                    
                        House houseNext = HousesMatrix[_row, _col];
                        _col++;
                        if (_col <= HousesMatrix.GetLength(1))
                        {
                            _col = HousesMatrix.GetLength(1) - 1;
                            _row++;
                           
                        }
                        if(houseNext.residents == 0)
                        {
                            counter++;
                        }
                        Console.WriteLine($"res =={ houseNext.residents}");
                    
                }
                if (_row % 2 == 0)
                {
                        House houseNext = HousesMatrix[_row, _col];
                        _col--;
                        if (_col < 0)
                        {
                            _col = 0;
                            _row++;
                            if (houseNext.residents == 0)
                            {
                                counter++;
                            }
                        }
                        
                        if (houseNext.residents == 0)
                        {
                            counter++;
                        }

                    
                }
                
            }
            return counter;
        }
        public int partOfIterateColl(int start, int end, int row ,bool reverse)
        {
            int counter = 0;
            if (!reverse)
            {
                for (int i = start; i < end; i++)
                {
                    if (HousesMatrix[_row, i].residents == 0)
                    {
                        counter++;
                    }
                }
            }
            else
            {
                for (int i = end; i < start; i--)
                {
                    if (HousesMatrix[row, i].residents == 0)
                    {
                        counter++;
                    }
                }
            }
            return counter;
        }
        public int partOfIteraterRow(int start, int end, int coll, bool reverse)
        {
            int counter = 0;
            if(!reverse)
            {
                for(int i = start; i < end; i++)
                {
                    if (HousesMatrix[coll, i].residents == 0) { 
                        counter++;
                    };
                }
            }
            else
            {
                for(int i = end; i < start; i--)
                {
                    if (HousesMatrix[coll, i].residents == 0)
                    {
                        counter++;
                    };
                }
            }
            return counter ;
        }
        public int IterateSpiral()
        {
            int startCol = 0;
            int startRow = 0;
            int counter = 0;
            int row = 0;
            int col= 0;
            int maxCol = HousesMatrix.GetLength(0)-1;
            int maxRow = HousesMatrix.GetLength(1)-1;
            for(int i = 0; i < HousesMatrix.Length; i++)
            {

                if (col < maxCol && row == maxRow)
                {
                    col++;
                }
                else if (row < maxRow && col == maxCol)
                {
                    row++;
                }
                else if (col > startCol && row == maxRow)
                {
                    col--;
                }
                else if (row > startRow + 1 && col == startCol)
                {
                    maxRow--;
                }
                else
                {
                    startRow++;
                    maxRow--;
                    startCol++;
                    maxCol--;
                    
                }
                if (HousesMatrix[row, col].residents == 0)
                {
                    counter++;
                }
                
            }
            return counter;
        }
    }
}
