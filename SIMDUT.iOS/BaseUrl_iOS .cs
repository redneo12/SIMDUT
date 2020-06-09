using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIMDUT.iOS;
using Foundation;
using SIMDUT.ViewModels.Base;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(BaseUrl_iOS))]
namespace SIMDUT.iOS
{
    public class BaseUrl_iOS : IBaseUrl
    {
        public string Get()
        {
            return NSBundle.MainBundle.BundlePath;
        }
    }
}