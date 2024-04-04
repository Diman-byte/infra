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
            string database = DatabaseTextBox.Text;
            int nodeId = int.Parse(NodeIdTextBox.Text);
            int tagId = int.Parse(TagIdTextBox.Text);
            DateTime dateTime = DateTimePicker.SelectedDate ?? DateTime.Now;
            double value = double.Parse(ValueTextBox.Text, CultureInfo.InvariantCulture);

            var data = new Dictionary<int, List<DataVal>>();
            var dataVals = new List<DataVal>();


            new DataVal { DateTime = dateTime, Val = value, IsGood = true };


            data.Add(tagId, dataVals);

            MsgLogClass msgLog;
            bool success = _cassandraHistory.TryInsertData(database, nodeId, data, out msgLog);

            if (success)
            {
                MessageBox.Show("Data inserted successfully.");
            }
            else
            {
                MessageBox.Show($"Failed to insert data. Error: {msgLog.LogDetails}");
            }

            Close();
            void NodeIdTextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
            {

            }
        }

    }
}