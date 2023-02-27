﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMDemo.MVVM.ViewModels
{
    public class CommandsViewModel
    {
        public ICommand ClickCommand =>
            new Command(Alert);
        private void Alert(object obj)
        {
            App.Current.MainPage
                .DisplayAlert("Title", "Message", "Ok");
        }
    }
}
