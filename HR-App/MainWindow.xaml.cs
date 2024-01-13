using System.Windows;
using AduSkin.Controls.Metro;

namespace HR_App
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            StateChanged += (o, e) =>
            {
                if (WindowState == WindowState.Minimized)
                {
                    Hide();
                }
            };
        }
        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }
        System.Windows.Forms.NotifyIcon icon = null;
        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            icon = new System.Windows.Forms.NotifyIcon();
            icon.BalloonTipText = this.Title;
            icon.Text = Title;
            //icon.Icon = new System.Drawing.Icon(@"icon.ico");
            icon.Visible = true;
            icon.Click += (o, e1) =>
            {
                this.Show();
                WindowState = WindowState.Normal;
            };

        }
    }
}
