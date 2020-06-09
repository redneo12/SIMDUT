using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SIMDUT
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TemplatePocketGuide : ContentView
    {


        public TemplatePocketGuide()
        {
            InitializeComponent();


        }
        public string PageTitle
        {
            get => HeaderLabel.Text;
            set
            {
                HeaderLabel.Text = value;
                if (!string.IsNullOrEmpty(HeaderLabel.Text))
                    HeaderLabel.IsVisible = true;
            }
        }

        public View Body
        {
            get => BodyContent.Content;
            set => BodyContent.Content = value;
        }
    }
}