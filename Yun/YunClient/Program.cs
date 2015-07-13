using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YunClient.YunServiceReference;
using System.Data;

namespace YunClient
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ServiceClient client = new ServiceClient();

                DataTable dataTable = client.SelectProjectByUser("Zbm007");
                int row = dataTable.Rows.Count;
                int column = dataTable.Columns.Count;
                for (int i = 0; i < column; i++)
                {
                    Console.Write(string.Format("{0} ", dataTable.Columns[i]));
                }
                Console.WriteLine();
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        Console.Write(string.Format("{0} ", dataTable.Rows[i][j]));
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
