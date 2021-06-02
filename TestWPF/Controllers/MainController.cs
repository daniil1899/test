﻿using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWPF.ViewModel;

namespace TestWPF.Controllers
{
    class MainController
    {
        private MainViewModel _model;
        public MainController ()
        {
           _model = CommonServiceLocator.ServiceLocator.Current.GetInstance<MainViewModel>();
            _model.StartCommand = new RelayCommand(Start);
            _model.PropertyChanged += _model_PropertyChanged;

        }

        private void _model_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            switch(e.PropertyName)
            {
                case "Text": break;
                case "ResultText": _model.Text = _model.ResultText; break ;

            }  

        }

        private void Start()
        {
            _model.ResultText = _model.Text;
        }
    }
}
