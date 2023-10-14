using Livet;
using Livet.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpf_design_sandbox.ViewModels
{
    public class FirstPage : ViewModel
    {
        public FirstPage() { }



        private string _text = "サンプル1";

        public string Text
        {
            get
            { return _text; }
            set
            { 
                if (_text == value)
                    return;
                _text = value;
                RaisePropertyChanged();
            }
        }


    }
}
