using System;
using android.app;
using android.widget;
using android.os;
using System.Windows;
using system.windows;
using System.Windows.Controls;
using System.Windows.Threading;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace com.koushikdutta.firefly
{
    class MainWindow : Window
    {
        DispatcherTimer myTimer;
        AnimationClock myClock;
        public MainWindow(WindowActivity activity) : base(activity)
        {
            SolidColorBrush solidBrush = new SolidColorBrush();

            StackPanel stack = new StackPanel();

            Rectangle rect = new Rectangle();
            rect.Width = 100;
            rect.Height = 100;
            rect.HorizontalAlignment = HorizontalAlignment.Right;
            GradientBrush gradient = new GradientBrush();
            gradient.StartPoint = new Point(0, .5f);
            gradient.EndPoint = new Point(1, .5f);
            gradient.GradientStops.Add(new GradientStop(new Color(1f, 1f, 0f, 1f), 0));
            gradient.GradientStops.Add(new GradientStop(new Color(0, 0, 1f, 1f), 1));
            rect.Fill = gradient;
            stack.Children.Add(rect);

            BitmapSource src = BitmapSource.Create(WindowActivity, R.drawable.funny);

            WrapPanel wrap = new WrapPanel();
            //wrap.HorizontalAlignment = HorizontalAlignment.Center;
            wrap.Orientation = Orientation.Horizontal;

            for (int i = 0; i < 8; i++)
            {
                Image img = new Image();
                img.Margin = new Thickness(5,5,5,5);
                img.ImageSource = src;
                img.HorizontalAlignment = HorizontalAlignment.Center;
                wrap.Children.Add(img);
            }

            stack.HorizontalAlignment = HorizontalAlignment.Stretch;
            stack.Children.Add(wrap);

            Content = stack;

            FloatAnimation anim = new FloatAnimation();
            anim.From = 50;
            anim.To = 300;
            anim.Duration = new Duration(TimeSpan.FromMilliseconds(10000));
            anim.RepeatBehavior = RepeatBehavior.Forever;
            anim.AutoReverse = true;
            myClock = anim.CreateClock();
            myClock.Animate(rect, Rectangle.WidthProperty);


            //myTimer = new DispatcherTimer(TimeSpan.FromMilliseconds(1000), (e, o) => Console.WriteLine("Foo"), Dispatcher.CurrentDispatcher);
            //myTimer.Start();

            //Content = img;
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

