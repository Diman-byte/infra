using Common.MsgLog;
using Common;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows;
using HistoryDB;
using System.Windows.Controls;


namespace Cas_1._4.Views
{
    public partial class InsertDataWindow : Window
    {
        private CassandraHistory _cassandraHistory;

        public InsertDataWindow(CassandraHistory cassandraHistory)
        {
            InitializeComponent();
            _cassandraHistory = cassandraHistory;
        }

        private void InsertData_Click(object sender, RoutedEventArgs e)
        {
            // Получаем данные из UI
            string database = DatabaseTextBox.Text;
            int nodeId = int.Parse(NodeIdTextBox.Text);
            Dictionary<int, List<DataVal>> data = new Dictionary<int, List<DataVal>>();

            // Заполняем данные из таблицы
            foreach (var item in DataGrid.Items)
            {
                DataVal dataVal = item as DataVal;
                int tagId = (int) dataVal.sn;
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

        private void NodeIdTextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }
    }
}
