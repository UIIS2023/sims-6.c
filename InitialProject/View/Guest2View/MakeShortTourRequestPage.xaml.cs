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
using InitialProject.ViewModels;

namespace InitialProject.View.Guest2View
{
    /// <summary>
    /// Interaction logic for MakeShortTourRequestPage.xaml
    /// </summary>
    public partial class MakeShortTourRequestPage : Page
    {
        public MakeShortTourRequestPage(NavigationService nav)
        {
            InitializeComponent();
            this.DataContext = new MakeShortTourRequestViewModel(nav);
        }
    }
}
