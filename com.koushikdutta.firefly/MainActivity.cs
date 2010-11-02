using System;
using android.app;
using android.widget;
using android.os;
using System.Windows;
using system.windows;
using System.Windows.Controls;

namespace com.koushikdutta.firefly
{
    public class MainActivity : WindowActivity
    {
        Window myWindow;
        protected override void onCreate (Bundle arg0)
        {
            base.onCreate (arg0);
   
            myWindow = new Window(this);
            setContentView(myWindow.SurfaceView);
            
            myWindow.Content = new StackPanel();
            
        }

        // This constructor is a requirement for all CLR classes that inherit from java.lang.Object
        protected MainActivity (MonoJavaBridge.JNIEnv env) : base(env)
        {
        }
    }
}   

