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

namespace lab7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
      
        public static RoutedUICommand CustomCommand { get; } = new RoutedUICommand("Custom Command", "CustomCommand", typeof(MainWindow));

        public MainWindow()
        {
            InitializeComponent();
            this.CommandBindings.Add(new CommandBinding(WindowCommands.CustomCommand, CustomCommand_Executed));
            this.CommandBindings.Add(new CommandBinding(WindowCommands.Exit, Exit_Executed));
            this.Loaded += MainWindow_Loaded;
            this.ContentRendered += MainWindow_ContentRendered;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            CustomCommand_Executed(null, null);
        }

        private void MainWindow_ContentRendered(object sender, EventArgs e)
        {
            CustomCommand_Executed(null, null);
        }

        private void Exit_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter("log.txt", true))
            {
                writer.WriteLine("Выход из приложения: " + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString());
                writer.Flush();
            }

            this.Close();
        }

        private void CustomCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if (ucMember != null)
            {
                using (System.IO.StreamWriter writer = new System.IO.StreamWriter("logMember.txt", true))
                {
                    writer.WriteLine("Title: " + ucMember.Title);
                    writer.WriteLine("SubTitle: " + ucMember.SubTitle);
                    writer.WriteLine("URL: " + ucMember.URL);
                }
            }
        }
    }

    public class WindowCommands
    {
        public static RoutedUICommand CustomCommand { get; } = new RoutedUICommand("Custom Command", "CustomCommand", typeof(MainWindow));
        public static RoutedCommand Exit { get; } = new RoutedCommand("Exit", typeof(MainWindow));
    }
}