using System;
using Xamarin.Forms;
using SIMDUT.Android;

using SIMDUT.ViewModels.Base;

[assembly: Dependency(typeof(BaseUrl_Android))]
namespace SIMDUT.Android
{
    public class BaseUrl_Android : IBaseUrl
    {
        public string Get()
        {
            return "file:///android_asset/";
        }
    }
}