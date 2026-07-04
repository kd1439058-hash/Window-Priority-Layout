using System;
using System.Windows.Forms;
using Window_Priority_Layout.Models;

namespace Window_Priority_Layout.Forms
{
    public partial class LayoutEdit : Form
    {
        public LayoutEdit()
        {
            InitializeComponent();
        }

        internal void SetValues(LayoutSlot slot)
        {
            txtLabel.Text = slot.Label;
            numX.Value = slot.X;
            numY.Value = slot.Y;
            numWidth.Value = slot.Width;
            numHeight.Value = slot.Height;
        }

        internal LayoutSlot GetSlot()
        {
            return new LayoutSlot
            {
                Label = txtLabel.Text,
                X = (int)numX.Value,
                Y = (int)numY.Value,
                Width = (int)numWidth.Value,
                Height = (int)numHeight.Value
            };
        }


    }
}

