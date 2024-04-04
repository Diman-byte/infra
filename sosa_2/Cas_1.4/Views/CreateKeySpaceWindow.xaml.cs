using Common;
using Common.MsgLog;
using HistoryDB;
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
using System.Windows.Shapes;

namespace Cas_1._4.Views
{
    /// <summary>
    /// Логика взаимодействия для CreateKeySpaceWindow.xaml
    /// </summary>
    public partial class CreateKeySpaceWindow : Window
    {
        private readonly CassandraHistory _cassandraHistory;

        public CreateKeySpaceWindow(CassandraHistory cassandraHistory)
        {
            InitializeComponent();
            _cassandraHistory = cassandraHistory;
        }

        private void CreateKeyspace_Click(object sender, RoutedEventArgs e)
        {
            string keyspace = KeyspaceTextBox.Text;
            MsgLogClass msgLog;
            bool success = _cassandraHistory.TryCreateKeyspace(keyspace, out msgLog);

            if (success)
            {
                MessageBox.Show("Keyspace успешно создан.", "Создание Keyspace", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show($"Ошибка при создании Keyspace: {msgLog.LogText}", "Создание Keyspace", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}