using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Queue.UserControls
{
    public partial class RollingText : UserControl
    {
        /*******************************************************************************************************/
        #region PRIVATE VARIABLES

        private int _textlength = 0;
        private int _speed;

        #endregion PRIVATE VARIABLES
        /*******************************************************************************************************/
        #region CONSTRUCTOR METHODS

        public RollingText()
        {
            InitializeComponent();
        }

        #endregion CONSTRUCTOR METHODS
        /*******************************************************************************************************/
        #region METHODS

        private void setupControls()
        {
        }

        private void populateData()
        {
        }

        public void Start(string text, int speed, int interval)
        {
            label.Text = text;
            _speed = speed;
            timer.Interval = interval;

            label.Height = this.Height; //set the height to match the container
            label.Width = TextRenderer.MeasureText(label.Text, label.Font).Width; //set width to show the text
            _textlength = label.Width; //memorize the width of the text
            if (_textlength < this.Width) //scroll if width larger than the container
                label.Width = this.Width;
            else
            {
                label.Text += label.Text; //double the text
                label.Width = TextRenderer.MeasureText(label.Text, label.Font).Width; //set width to show the text
                timer.Start();
            }
        }

        public void Stop()
        {
            timer.Stop();
        }
        
        private void timer_Tick(object sender, EventArgs e)
        {
            //scrolling text by moving the label control one pixel to the left
            if (label.Location.X > (-1 * _textlength) + 20)
                label.Location = new Point(label.Location.X - _speed, label.Location.Y);
            else
                label.Location = new Point(0, label.Location.Y);
        }

        #endregion METHODS
        /*******************************************************************************************************/
        #region EVENT HANDLERS

        private void Form_Load(object sender, EventArgs e)
        {
            setupControls();
            populateData();
        }

        #endregion EVENT HANDLERS
        /*******************************************************************************************************/
    }
}
