using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using EntityFrameWorkTest1;
using Npgsql;

using EntityFrameWorkTest1.DB;

namespace WpfApp2
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //var connectionString = "Server = 192.168.10.50; Port = 5432; User Id = postgres; Database=testdb";

            //var conn = new NpgsqlConnection(connectionString);

            //try
            //{
            //    conn.Open();
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.ToString());
            //}

            using (var con = new TestConnection())
            {
                var test = con.Table.ToList();
                foreach (var item in test)
                {
                    Console.WriteLine("ID is : {0}",item.Id);
                }
            }                


        }
    }
}
