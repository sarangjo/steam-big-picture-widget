using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;

namespace BigPictureWidget
{
    class BigPicture
    {
        static string uriToLaunch = @"steam://open/bigpicture";

        public static IAsyncOperation<bool> Open()
        {
            Uri uri = new Uri(uriToLaunch);
            return Windows.System.Launcher.LaunchUriAsync(uri);
        }
    }
}
