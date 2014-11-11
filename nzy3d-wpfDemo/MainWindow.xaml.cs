using nzy3D.Chart;
using nzy3D.Colors;
using nzy3D.Colors.ColorMaps;
using nzy3D.Maths;
using nzy3D.Plot3D.Builder;
using nzy3D.Plot3D.Builder.Concrete;
using nzy3D.Plot3D.Primitives;
using nzy3D.Plot3D.Primitives.Axes.Layout;
using nzy3D.Plot3D.Rendering.Canvas;
using nzy3D.Plot3D.Rendering.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace nzy3d_wpfDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        
        private nzy3D.Chart.Controllers.Thread.Camera.CameraThreadController t;
        private IAxeLayout axeLayout;

        public MainWindow()
        {
            InitializeComponent();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        // Create the OnPropertyChanged method to raise the event
        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
        
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // MVVM made simple : DataContext is current object
            this.DataContext = this;

            // Create the interop host control.
            System.Windows.Forms.Integration.WindowsFormsHost host =
                new System.Windows.Forms.Integration.WindowsFormsHost();

            // Create the Renderer 3D control.
            Renderer3D renderer = new Renderer3D();

            // Assign the Renderer 3D control as the host control's child.
            host.Child = renderer;

            // Add the interop host control to the Grid 
            // control's collection of child controls. 
            this.MainGrid.Children.Add(host);

            // Create a range for the graph generation
            Range range = new Range(-150, 150);
            int steps = 50;

            // Build a nice surface to display with cool alpha colors 
            // (alpha 0.8 for surface color and 0.5 for wireframe)
            Shape surface = Builder.buildOrthonomal(new OrthonormalGrid(range, steps, range, steps), new MyMapper());
            surface.ColorMapper = new ColorMapper(new ColorMapRainbow(), surface.Bounds.zmin, surface.Bounds.zmax, new Color(1, 1, 1, 0.8));
            surface.FaceDisplayed = true;
            surface.WireframeDisplayed = true;
            surface.WireframeColor = Color.CYAN;
            surface.WireframeColor.mul(new Color(1, 1, 1, 0.5));

            // Create the chart and embed the surface within
            Chart chart = new Chart(renderer, Quality.Nicest);
            chart.Scene.Graph.Add(surface);
            axeLayout = chart.AxeLayout;
            DisplayXTicks = true;
            DisplayXAxisLabel = true;
            DisplayYTicks = true;
            DisplayYAxisLabel = true;
            DisplayZTicks = true;
            DisplayZAxisLabel = true;
            DisplayTickLines = true;

            // Create a mouse control
            nzy3D.Chart.Controllers.Mouse.Camera.CameraMouseController mouse = new nzy3D.Chart.Controllers.Mouse.Camera.CameraMouseController();
            mouse.addControllerEventListener(renderer);
            chart.addController(mouse);

            // This is just to ensure code is reentrant (used when code is not in Form_Load but another reentrant event)
            DisposeBackgroundThread();

            // Create a thread to control the camera based on mouse movements
            t = new nzy3D.Chart.Controllers.Thread.Camera.CameraThreadController();
            t.addControllerEventListener(renderer);
            mouse.addSlaveThreadController(t);
            chart.addController(t);
            t.Start();

            // Associate the chart with current control
            renderer.setView(chart.View);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            DisposeBackgroundThread();
        }

        private void DisposeBackgroundThread()
        {
            if ((t != null))
            {
                t.Dispose();
            }
        }

        private bool _DisplayTickLines;
        public bool DisplayTickLines
        {
            get
            {
                return _DisplayTickLines;
            }
            set
            {
                _DisplayTickLines = value;
                OnPropertyChanged("DisplayTickLines");
                if (axeLayout != null)
                {
                    axeLayout.TickLineDisplayed = value;
                }
            }
        }

        private bool _DisplayXTicks;
        public bool DisplayXTicks
        {
            get
            {
                return _DisplayXTicks;
            }
            set
            {
                _DisplayXTicks = value;
                OnPropertyChanged("DisplayXTicks");
                if (axeLayout != null)
                {
                    axeLayout.XTickLabelDisplayed = value;
                }
            }
        }

        private bool _DisplayYTicks;
        public bool DisplayYTicks
        {
            get
            {
                return _DisplayYTicks;
            }
            set
            {
                _DisplayYTicks = value;
                OnPropertyChanged("DisplayYTicks");
                if (axeLayout != null)
                {
                    axeLayout.YTickLabelDisplayed = value;
                }
            }
        }

        private bool _DisplayZTicks;
        public bool DisplayZTicks
        {
            get
            {
                return _DisplayZTicks;
            }
            set
            {
                _DisplayZTicks = value;
                OnPropertyChanged("DisplayZTicks");
                if (axeLayout != null)
                {
                    axeLayout.ZTickLabelDisplayed = value;
                }
            }
        }

        private bool _DisplayXAxisLabel;
        public bool DisplayXAxisLabel
        {
            get
            {
                return _DisplayXAxisLabel;
            }
            set
            {
                _DisplayXAxisLabel = value;
                OnPropertyChanged("DisplayXAxisLabel");
                if (axeLayout != null)
                {
                    axeLayout.XAxeLabelDisplayed = value;
                }
            }
        }

        private bool _DisplayYAxisLabel;
        public bool DisplayYAxisLabel
        {
            get
            {
                return _DisplayYAxisLabel;
            }
            set
            {
                _DisplayYAxisLabel = value;
                OnPropertyChanged("DisplayYAxisLabel");
                if (axeLayout != null)
                {
                    axeLayout.YAxeLabelDisplayed = value;
                }
            }
        }

        private bool _DisplayZAxisLabel;
        public bool DisplayZAxisLabel
        {
            get
            {
                return _DisplayZAxisLabel;
            }
            set
            {
                _DisplayZAxisLabel = value;
                OnPropertyChanged("DisplayZAxisLabel");
                if (axeLayout != null)
                {
                    axeLayout.ZAxeLabelDisplayed = value;
                }
            }
        }
    
    }
}
