using Common.MsgLog;
using Common;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows;
using HistoryDB;
using System.Windows.Controls;
using Cas_1._4.Views;


namespace Cas_1._4.ViewModels
{
    public class InsertDataWindowModel
    {
        private CassandraHistory _cassandraHistory;

        public InsertDataWindowModel(CassandraHistory cassandraHistory)
        {
            _cassandraHistory = cassandraHistory;
        }

   

        private void NodeIdTextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }
    }
}