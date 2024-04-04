
using Cas_1._4.Views;
using HistoryDB;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using static Cas_1._4.Views.ConnectDialog;

// 172.30.221.120


namespace Cas_1._4
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            _cassandraHistory = new CassandraHistory();
        }

        private CassandraHistory _cassandraHistory;

        private void Connect_Click(object sender, RoutedEventArgs e)
        {
            var connectDialog = new ConnectDialog(_cassandraHistory); // Инициализация диалога подключения
            var dialogResult = connectDialog.ShowDialog(); // Показать диалог и получить результат

            if (dialogResult == true)
            {
                // Обработка успешного подключения
         
            }
            else
            {
                // Обработка отмены подключения или ошибки подключения
            }
        }

        private void Disconnect_Click(object sender, RoutedEventArgs e)
        {
            // Логика отключения от базы данных
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void InsertData_Click(object sender, RoutedEventArgs e)
        {
            InsertDataWindow insertDataWindow = new InsertDataWindow(_cassandraHistory);
            insertDataWindow.ShowDialog();
        }

        private void ViewData_Click(object sender, RoutedEventArgs e)
        {
            ReadHistDataWindow readHistDataWindow = new ReadHistDataWindow(_cassandraHistory);
            readHistDataWindow.ShowDialog();
        }

        private void ManageEvents_Click(object sender, RoutedEventArgs e)
        {
            // Открытие окна управления событиями
        }

        private void CreateKeySpace_Click(object sender, RoutedEventArgs e)
        {
            CreateKeySpaceWindow createKeySpaceWindow = new CreateKeySpaceWindow(_cassandraHistory);
            createKeySpaceWindow.ShowDialog(); 
            // Открываете окно создания KeySpace или вызываете соответствующий метод, если создание происходит без отдельного окна
        }

        private void InitializeHistDBColumns_Click(object sender, RoutedEventArgs e)
        {
            InitializeHistDBColumnsWindow initializeHistDBColumnsWindow = new InitializeHistDBColumnsWindow(_cassandraHistory);
            initializeHistDBColumnsWindow.ShowDialog();
        }



    }
}
