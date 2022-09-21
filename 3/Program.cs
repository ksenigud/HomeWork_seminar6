Console.WriteLine("Количество столбцов: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Количество строк: ");
int r = Convert.ToInt32(Console.ReadLine());


void Matrix (int[,] matrix)
{for (int rows =0; rows< matrix.GetLength(0); rows++)
{
    for (int col =0; col<matrix.GetLength(1); col++)
   {
     matrix [rows,col]= new Random().Next(1,10);
     Console.Write($"{matrix[rows, col]} ");
   }
   Console.WriteLine();
}
}

void TransMatrix1 (int[,] matrix)
{for (int rows =0; rows<matrix.GetLength(0)/2; rows++)
{
    for (int col =0; col<matrix.GetLength(1); col++)
        {int x=matrix[rows,col];
        matrix[rows, col] = matrix[matrix.GetLength(0)-rows-1, col];
        matrix[matrix.GetLength(0)-rows-1, col]=x;
      
         Console.Write($"{matrix[rows, col]} ");
   }
   Console.WriteLine();
}
}
void TransMatrix2 (int[,] matrix)
{for (int rows =0; rows<matrix.GetLength(0)/2; rows++)
{
    for (int col =0; col<matrix.GetLength(1); col++)
        {int x=matrix[rows,col];
        matrix[rows, col] = matrix[matrix.GetLength(0)-rows-2, col];
        matrix[matrix.GetLength(0)-rows-2, col]=x;
      
         Console.Write($"{matrix[rows, col]} ");
   }
   Console.WriteLine();
}
}


int[,]matrix = new int [3,4];
Matrix(matrix);
Console.WriteLine();
TransMatrix1(matrix);
TransMatrix2(matrix);

