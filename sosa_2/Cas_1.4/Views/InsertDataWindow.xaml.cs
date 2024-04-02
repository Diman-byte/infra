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
using Cas_1._4.ViewModels;
using Common.MsgLog;
using Common;
using HistoryDB;

namespace Cas_1._4.Views
{
    /// <summary>
    /// Логика взаимодействия для InsertDataWindow.xaml
    /// </summary>
    public partial class InsertDataWindow
    {
        public InsertDataWindow(CassandraHistory cassandraHistory)
        {
            InitializeComponent();
            _cassandraHistory = cassandraHistory;
        }

        private CassandraHistory _cassandraHistory;

        public void InsertData_Click(object sender, RoutedEventArgs e)
        {
            // Получаем данные из UI
            string database = DatabaseTextBox.Text;
            int nodeId = int.Parse(NodeIdTextBox.Text);
            Dictionary<int, List<DataVal>> data = new Dictionary<int, List<DataVal>>();

            // Заполняем данные из таблицы
            foreach (var item in DataGrid.Items)
            {
                DataVal dataVal = item as DataVal;
                int tagId = (int)dataVal.sn;
                if (!data.ContainsKey(tagId))
                {
                    data[tagId] = new List<DataVal>();
                }
                data[tagId].Add(dataVal);
            }

            // Вызываем метод TryInsertData
            MsgLogClass msgLog;
            bool success = _cassandraHistory.TryInsertData(database, nodeId, data, out msgLog);

            //    // Обновляем лог
            //    if (success)
            //    {
            //        LogTextBox.Text += "Data inserted successfully.\n";
            //    }
            //    else
            //    {
            //        LogTextBox.Text += $"Failed to insert data. Error: {msgLog?.LogText}\n";
            //    }
        }
    }
}
