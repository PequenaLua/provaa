﻿using System;
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

namespace esfera
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            esfera x = new esfera();
            x.SetRaio(double.Parse(raio.Text));
            area.Text = x.CalcArea().ToString();
            volume.Text = x.CalcVolume().ToString();
        }

        class esfera
        {
            private double raio;

            public void SetRaio(double v)
            {
                raio = v;
            }

            public double GetRaio()
            {
                return raio;
            }

            public double CalcVolume()
            {
                return 4 * Math.PI * Math.Pow(raio,3) / 3;
            }

            public double CalcArea()
            {
                return 4 * Math.PI * Math.Pow(raio, 2);
            }
        }
    }
}
