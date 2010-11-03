using System;
using android.app;
using android.widget;
using android.os;
using System.Windows;
using system.windows;
using System.Windows.Controls;
using System.Windows.Threading;
using System.Windows.Media;

namespace com.koushikdutta.firefly
{
    class MainWindow : Window
    {
        public MainWindow(WindowActivity activity) : base(activity)
        {
            Size ff = new Size(480, 640);
            Console.WriteLine(ff);
            BitmapSource src = BitmapSource.Create(WindowActivity, R.drawable.funny);
            
            
            Image img = new Image();
            img.ImageSource = src;
            
            Content = img;
        }
    }

    public class MainActivity : WindowActivity
    {
        protected override void onCreate (Bundle arg0)
        {
            WindowType = typeof(MainWindow);
            base.onCreate (arg0);
        }

        // This constructor is a requirement for all CLR classes that inherit from java.lang.Object
        protected MainActivity (MonoJavaBridge.JNIEnv env) : base(env)
        {
        }
    }
}   

