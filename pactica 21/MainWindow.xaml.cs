using System.Windows;
using System.Windows.Controls;

namespace pactica_21
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Добавляем обработчик события Loaded
            this.Loaded += MainWindow_Loaded;

            // Добавляем обработчик события SizeChanged
            this.SizeChanged += MainWindow_SizeChanged;

            // Добавляем обработчик события Closing
            this.Closing += MainWindow_Closing;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Форма загружена!");
        }

        private void MainWindow_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            MessageBox.Show("Размер формы изменен!");
        }

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вы уверены, что хотите закрыть форму?", "Подтверждение", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.No)
            {
                e.Cancel = true; // Отменяем закрытие формы, если пользователь выбрал "Нет"
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Кнопка была нажата!");
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            MessageBox.Show("Текст в текстовом поле был изменен!");
        }
    }
}
