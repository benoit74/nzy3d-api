using nzy3D.Chart;
using nzy3D.Chart.Controllers.Thread.Camera;
using nzy3D.Colors;
using nzy3D.Colors.ColorMaps;
using nzy3D.Maths;
using nzy3D.Plot3D.Builder;
using nzy3D.Plot3D.Builder.Concrete;
using nzy3D.Plot3D.Primitives;
using nzy3D.Plot3D.Primitives.Axes.Layout;
using nzy3D.Plot3D.Rendering.Canvas;
using nzy3D.Plot3D.Rendering.View;
using nzy3d_wpfDemo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nzy3d_winformsDemo
{
    public partial class Form1 : Form
    {

        private CameraThreadController t;
        private IAxeLayout axeLayout;

        public Form1()
        {
            InitializeComponent();
            //InitRenderer();
        }

        private void InitRenderer()
        {

            // Create the Renderer 3D control.
            //Renderer3D myRenderer3D = new Renderer3D();

            // Add the Renderer control to the panel
           // mainPanel.Controls.Clear();
            //mainPanel.Controls.Add(myRenderer3D);

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
            Chart chart = new Chart(myRenderer3D, Quality.Nicest);
            chart.Scene.Graph.Add(surface);
            axeLayout = chart.AxeLayout;
            
            // All activated by default
            DisplayXTicks = true;
            DisplayXAxisLabel = true;
            DisplayYTicks = true;
            DisplayYAxisLabel = true;
            DisplayZTicks = true;
            DisplayZAxisLabel = true;
            DisplayTickLines = true;

            // Create a mouse control
            nzy3D.Chart.Controllers.Mouse.Camera.CameraMouseController mouse = new nzy3D.Chart.Controllers.Mouse.Camera.CameraMouseController();
            mouse.addControllerEventListener(myRenderer3D);
            chart.addController(mouse);

            // This is just to ensure code is reentrant (used when code is not called in Form_Load but another reentrant event)
            DisposeBackgroundThread();

            // Create a thread to control the camera based on mouse movements
            t = new nzy3D.Chart.Controllers.Thread.Camera.CameraThreadController();
            t.addControllerEventListener(myRenderer3D);
            mouse.addSlaveThreadController(t);
            chart.addController(t);
            t.Start();

            // Associate the chart with current control
            myRenderer3D.setView(chart.View);

            this.Refresh();
        }
        
        private void DisposeBackgroundThread()
        {
            if ((t != null))
            {
                t.Dispose();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DisposeBackgroundThread();
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
                if (axeLayout != null)
                {
                    axeLayout.ZAxeLabelDisplayed = value;
                }
            }
        }

        private void checkBoxes_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDisplayXTicks.Checked != DisplayXTicks)
            {
                DisplayXTicks = chkDisplayXTicks.Checked;
            }
            if (chkDisplayYTicks.Checked != DisplayYTicks)
            {
                DisplayYTicks = chkDisplayYTicks.Checked;
            }
            if (chkDisplayZTick.Checked != DisplayZTicks)
            {
                DisplayZTicks = chkDisplayZTick.Checked;
            }
            if (chkDisplayXAxisLabel.Checked != DisplayXAxisLabel)
            {
                DisplayXAxisLabel = chkDisplayXAxisLabel.Checked;
            }
            if (chkDisplayYAxisLabel.Checked != DisplayYAxisLabel)
            {
                DisplayYAxisLabel = chkDisplayYAxisLabel.Checked;
            }
            if (chkDisplayZAxisLabel.Checked != DisplayZAxisLabel)
            {
                DisplayZAxisLabel = chkDisplayZAxisLabel.Checked;
            }
            if (chkDisplayTickLines.Checked != DisplayTickLines)
            {
                DisplayTickLines = chkDisplayTickLines.Checked;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitRenderer();
        }

    }
}
