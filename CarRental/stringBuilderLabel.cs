using Guna.UI.WinForms;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    public partial class MyLabel : GunaLabel
    {
        public MyLabel()
        {
            InitializeComponent();
        }

        public MyLabel(IContainer container)
        {
            container.Add(this);


            InitializeComponent();
           

        }
        private StringBuilder _textBuilder=new StringBuilder();

        

        public StringBuilder TextBuilder
        {
            get => _textBuilder;
            set
            {
                if (_textBuilder != value)
                {
                    _textBuilder = value;
                    OnTextChanged(EventArgs.Empty);
                }
            }
        }

        public override string Text
        {
            get => _textBuilder.ToString();
            set
            {
                if (_textBuilder.ToString() != value)
                {
                    _textBuilder.Clear();
                    _textBuilder.Append(value);
                    OnTextChanged(EventArgs.Empty);
                }
            }
        }

    }
}
