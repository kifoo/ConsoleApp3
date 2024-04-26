using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Multiplication
{
    internal class ParallelClass
    {
        private Matrix matrix1;                 // matrix 1
        private Matrix matrix2;                 // matrix 2
        private volatile Matrix result;         // result matrix
        private int threadsNumber;              // number of threads -> thread max
        public Stopwatch[] threadStopwatches;   // time of calculations for each thread
        public double multiplying_time;         // time of calculations for all threads

        public ParallelClass(Matrix m1, Matrix m2, int tn)
        {
            matrix1 = m1;
            matrix2 = m2;
            threadsNumber = tn;
            result = new Matrix(matrix1.Rows, matrix2.Columns);
            multiplying_time = 0;
            threadStopwatches = new Stopwatch[Environment.ProcessorCount];
            for (int i = 0; i < threadStopwatches.Length; i++)
            {
                threadStopwatches[i] = new Stopwatch();
            }
        }


        public Matrix Multiply()
        {
            if (matrix1.Columns != matrix2.Rows)
            {
                throw new ArgumentException("Number of columns in matrix1 must be equal to number of rows in matrix2.");
            }
            // Start stopwatch for all threads
            var watch = Stopwatch.StartNew();

            Parallel.For(0, threadsNumber, i => 
            { 
                int i_temp = i;  
                MultiplyPart(i_temp); 
            });

            watch.Stop();
            multiplying_time = watch.Elapsed.TotalMilliseconds;

            return result;
        }

        private void MultiplyPart(int i)
        {
            threadStopwatches[i].Start();
            int start = i * matrix1.Rows / threadsNumber;
            int end = i == threadsNumber - 1 ? matrix1.Rows : (i + 1) * matrix1.Rows / threadsNumber;
            // Go through the rows of the first matrix
            for (int row = start; row < end; row++)
            {
                // Go through the columns of the second matrix
                for (int col = 0; col < matrix2.Columns; col++)
                {
                    // Go through the columns of the first matrix
                    for (int k = 0; k < matrix1.Columns; k++)
                    {
                        result[row, col] += matrix1[row, k] * matrix2[k, col];
                    }
                }
            }
            threadStopwatches[i].Stop();
        }

        public string GetInfo()
        {
            string info = $"{threadsNumber} threads ended in {multiplying_time}ms\n";
            for (int i = 0; i < threadsNumber; i++)
            {
                info += $"Thread {i + 1} time: {threadStopwatches[i].Elapsed.TotalMilliseconds}ms\n";
            }
            return info;
        }
    }
}
