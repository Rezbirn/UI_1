﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UI_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random r = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Close();

        }
        private void Canvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Point p = e.GetPosition(this);
            Canvas.SetLeft(button1, p.X - button1.ActualWidth / 2);
            Canvas.SetTop(button1, p.Y - button1.ActualHeight / 2);
        }
        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            if (Keyboard.IsKeyDown(Key.LeftCtrl) || Keyboard.IsKeyDown(Key.RightCtrl)) return;
            Point p = e.GetPosition(this);
            Canvas.SetLeft(button2, r.NextDouble() * ((Content as Canvas).ActualWidth - 5));
            Canvas.SetTop(button2, r.NextDouble() * ((Content as Canvas).ActualHeight - 5));
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {

            button2.Content = "Змінити";
            button2.MouseMove -= button2_MouseMove;
        }
    }
}