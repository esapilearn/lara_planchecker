﻿using Prism.Mvvm;

namespace Lara_PlanChecker.ViewModels
{
    public class MainViewModel : BindableBase
    {
        private string _title = "ESAPIX Starter Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
        //test a push
        public MainViewModel()
        {

        }
    }
}
