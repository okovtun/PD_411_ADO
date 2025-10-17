//#define EXAMPLE_1
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace LINQ
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			AllocConsole();

#if EXAMPLE_1
			//1) Создаем источник данных:
			int[] arr = { 3, 5, 8, 13, 21, 34, 55 };

			//2) Определяем query expression:
			IEnumerable<int> FibonacciQuery =
				from i in arr
				where i > 20
				orderby i descending
				select i;

			//3) Выполнение запроса:
			foreach (int i in FibonacciQuery)
			{
				Console.Write($"{i}\t");
			}
			Console.WriteLine(); 
#endif

			string connectionString 
				= "Data Source=DESKTOP-QHG18FL\\SQLEXPRESS;Initial Catalog=PD_321;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
			SqlConnection connection = new SqlConnection(connectionString);
			//(from direction in connection select )
		}
		[DllImport("kernel32.dll")]
		public static extern bool AllocConsole();
		[DllImport("kernel32.dll")]
		public static extern bool FreeConsole();
	}
}
