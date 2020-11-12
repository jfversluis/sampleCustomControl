using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace sampleCustomControl.Extension
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LabelEntry : StackLayout
    {
        public static readonly BindableProperty EntryTextProperty =
            BindableProperty.Create("EntryText", typeof(string), typeof(LabelEntry), default, BindingMode.TwoWay);

        public string EntryText
        {
            get
            {
                return (string)GetValue(EntryTextProperty);
            }
            set
            {
                SetValue(EntryTextProperty, value);
            }
        }
        public LabelEntry()
        {
            InitializeComponent();
            BindingContext = this;
        }
    }
}