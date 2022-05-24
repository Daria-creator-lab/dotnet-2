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
using System.Windows.Shapes;
using TaskClientWPF.ViewModels;

namespace TaskClientWPF.Views
{
    /// <summary>
    /// Логика взаимодействия для TasksView.xaml
    /// </summary>
    public partial class TasksView : Window
    {
        public TasksView()
        {
            InitializeComponent();
        }

        public TasksView(TasksViewModel taskViewModel)
        {
            InitializeComponent();
            DataContext = taskViewModel;
        }
    }
}
