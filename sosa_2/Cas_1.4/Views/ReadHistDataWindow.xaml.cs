using Common.MsgLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using HistoryDB;
using Common;


namespace Cas_1._4.Views
{

    public partial class ReadHistDataWindow : Window
    {
        private CassandraHistory _cassandraHistory;

        public ReadHistDataWindow(CassandraHistory cassandraHistory)
        {
            InitializeComponent();
            _cassandraHistory = cassandraHistory;
        }

        private void ViewData_Click(object sender, RoutedEventArgs e)
        {
            // Получаем значения из интерфейса
            string database = DatabaseTextBox.Text;
            int nodeId = int.Parse(NodeIdTextBox.Text);
            DateTime beginDateTime = BeginDateTimePicker.SelectedDate ?? DateTime.MinValue;
            DateTime endDateTime = EndDateTimePicker.SelectedDate ?? DateTime.MaxValue;
            List<int> idTags = ParseIdTags(TagIdTextBox.Text);

            // Вызываем метод TryReadHistData
            Dictionary<int, List<(DateTime, bool, float)>> result;
            MsgLogClass msgLog;
            bool success = _cassandraHistory.TryReadHistData(database, nodeId, beginDateTime, endDateTime, idTags, out result, out msgLog);

            // Проверяем результат
            if (success)
            {
                // Выводим результат на экран или обрабатываем его дальше
                ShowResultInUI(result);
                MessageBox.Show("Данные успешно прочитаны.", "Чтение данных", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                // Выводим сообщение об ошибке
                MessageBox.Show($"Ошибка при чтении данных: {msgLog.LogText}", "Чтение данных", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private List<int> ParseIdTags(string idTagsString)
        {
            // Разбиваем строку на массив чисел и парсим каждое число
            string[] idTagsArray = idTagsString.Split(',');
            List<int> idTags = new List<int>();
            foreach (var idTag in idTagsArray)
            {
                if (int.TryParse(idTag.Trim(), out int parsedIdTag))
                {
                    idTags.Add(parsedIdTag);
                }
            }
            return idTags;
        }

        private void ShowResultInUI(Dictionary<int, List<(DateTime, bool, float)>> result)
        {
            // Выводим результат на экран вашим способом
        }
    }
}