using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pascal_s_triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> test_answer = new List<int>();
            test_answer = (PascalsTriangle(15));
            for (int i = 0; i < test_answer.Count; i++)
            {
                Console.Write(test_answer[i]);
            }
            Console.ReadLine();
        }

        public static List<int> PascalsTriangle(int n)
        {
            List<int> pascal_values = new List<int>();
            pascal_values.Add(1);

            List<int> previous_row = new List<int>();
            previous_row.Add(1);

            List<int> current_row = new List<int>();

            for (int i = 2; i <= n; i++)     //if n=1, it will skip this for loop
            {
                current_row.Add(previous_row[0]);  //fills current_row's first member
                for (int j = 1; j < i - 1; j++)
                {
                    current_row.Insert(j, previous_row[j - 1] + previous_row[j]);   //fills current_row's middle members
                }
                current_row.Add(previous_row[i - 2]);     //fills current_row's last member

                previous_row.Clear();
                for (int k = 0; k < i; k++)
                {
                    pascal_values.Add(current_row[k]);    //adds every integer from current row into master list
                    previous_row.Add(current_row[k]);    //adds every integer from current row into previous_row to prepare for next iteration
                }
                current_row.Clear();
            }
            return pascal_values;
        }
    }
}
