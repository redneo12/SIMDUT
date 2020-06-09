
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SIMDUT.PocketGuide
{
    public interface IBaseUrl { string Get(); }
    public class BaseUrlWebView : WebView { }

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageSDSExample : ContentPage
    {
        

        public PageSDSExample()
        {
            //InitializeComponent();

            var source = new HtmlWebViewSource();
            var assembly = IntrospectionExtensions.GetTypeInfo(typeof(SIMDUT.PocketGuide.PageSDSExample)).Assembly;
            Stream stream = assembly.GetManifestResourceStream(Strings.ImgSimdutHTMLFDS);

            using (var reader = new System.IO.StreamReader(stream, Encoding.GetEncoding("iso-8859-1")))
            {
                source.Html = reader.ReadToEnd();
            }

            var labelhtml = new Xamarin.Forms.Label
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.Fill,
                Text = source.Html,
            };
            var webview = new WebView
            {
                Source = source,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
            };
            
            
            var inMemoryScrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.Fill,
                IsClippedToBounds = true,
                Content = labelhtml
            };
            
            Content = new StackLayout
            {
                Children = { webview ,
            }
            };

        }
    }
}