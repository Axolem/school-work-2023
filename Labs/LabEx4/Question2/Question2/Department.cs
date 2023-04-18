using System;

namespace Question2
{
    internal class Department
    {
        // init a private array
        private readonly double[][] sales;

        //  constructor 
        public Department()
        {
            // init the sales array with 4 rows and 3 columns
            sales = new double[4][];
            for (int i = 0; i < sales.Length; i++)
            {
                // make each row have 3 columns
                sales[i] = new double[3];
            }
        }

        public void populateArray()
        {
            // loop through the rows and columns of the sales 
            for (int i = 0; i < sales.Length; i++)
            {
                for (int j = 0; j < sales[i].Length; j++)
                {
                    // Prompt the user to enter sales data for each department and month
                    Console.Write("Enter sales for department {0}, month {1}: ", i + 1, j + 1);
                    // Store the entered data in the sales array
                    sales[i][j] = double.Parse(Console.ReadLine());
                }
            }
        }

        public double[] calculateAvgSalesPerMonth()
        {
            // init aray
            double[] avarageSales = new double[3];
            // loop through the columns
            for (int i = 0; i < avarageSales.Length; i++)
            {
                // Initialize a sum variable to 0
                double sum = 0;
                // loop through the rows 
                for (int j = 0; j < sales.Length; j++)
                {
                    // add the current element to total 
                    sum += sales[j][i];
                }
                avarageSales[i] = sum / sales.Length;
            }
            return avarageSales;
        }

        public double[] calculateAvgSalesPerDepart()
        {
            // init array 
            double[] avarageSales = new double[4];
            // Loop through the rows 
            for (int i = 0; i < avarageSales.Length; i++)
            {
                double total = 0;
                // Loop through the columns 
                for (int j = 0; j < sales[i].Length; j++)
                {
                    // add the current element to total 
                    total += sales[i][j];
                }
                avarageSales[i] = total / sales[i].Length;
            }
            return avarageSales;
        }

        public int determineHighestMonthlySales(int month)
        {
            // init
            int highestSalesDepart = 0;
            double highestSales = 0;
            // ;oop through the rows of the sales 
            for (int i = 0; i < sales.Length; i++)
            {
                // if the current element of the sales array is greater than the current highest sales value
                if (sales[i][month - 1] > highestSales)
                {
                    // update the highest sales value and the  department
                    highestSales = sales[i][month - 1];
                    highestSalesDepart = i + 1;
                }
            }
            return highestSalesDepart;
        }

        public int determineHighestDepartSales(int depart)
        {
            int highestSalesMonth = 0;
            double highestSales = 0;
            // loop through the columns of the specified row of the sales array
            for (int i = 0; i < sales[depart - 1].Length; i++)
            {
                //  if the current element of the sales array is greater than the current highest sales value
                if (sales[depart - 1][i] > highestSales)
                {
                    //  update the highest sales value and the  month
                    highestSales = sales[depart - 1][i];
                    highestSalesMonth = i + 1;
                }
            }
            return highestSalesMonth;
        }
    }
}
