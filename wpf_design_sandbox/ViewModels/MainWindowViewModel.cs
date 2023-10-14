using Livet;
using Livet.Commands;
using Livet.EventListeners;
using Livet.Messaging;
using Livet.Messaging.IO;
using Livet.Messaging.Windows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using wpf_design_sandbox.Models;

namespace wpf_design_sandbox.ViewModels
{
    public class MainWindowViewModel : ViewModel
    {
        public void Initialize()
        {

        }


        
        public ViewModel ActiveView
        {
            get => _activeView;
            set => RaisePropertyChangedIfSet(ref _activeView, value);
        }
        private ViewModel _activeView = new FirstPage();

        public void pageChange(string param)
        {
            switch (param)
            {
                case "First":
                    ActiveView = new FirstPage();
                    break;
                case "Second":
                    ActiveView = new SecondPage();
                    break;
            }
        }
        private ListenerCommand<string> _pageChangeCommand;
        public ListenerCommand<string> PageChangeCommand => _pageChangeCommand ??
            (_pageChangeCommand = new ListenerCommand<string>(pageChange));


    }
}
