using Logic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    public partial class PickAcolorForm : Form
    {
        private Color m_PickedColor;
        private List<Color> m_InUseColor = new List<Color>();

        public Color PickedColor
        {
            get { return this.m_PickedColor; }
            set { this.m_PickedColor = value; }
        }

        public List<Color> InUseColor
        {
            get { return this.m_InUseColor; }
            set { this.m_InUseColor = value; }
        }

        public PickAcolorForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            colorOptionsButtons();
        }

        private void colorOptionsButtons()
        {
            int colorEnum = 0;
            foreach (Button button in this.Controls)
            {
                eGuessFrom currentColor = (eGuessFrom)colorEnum;
                button.BackColor = Color.FromName(currentColor.ToString());
                colorEnum++;
            }
        }

        private void Color_Click(object sender, EventArgs e)
        {
            this.m_PickedColor = (sender as Button).BackColor;
            this.DialogResult = DialogResult.OK;
            (sender as Button).Enabled = false;
            this.Close();
        }

        internal void UpdateColorList(Color i_PreviusColor, Color i_NewColor)
        {
            foreach (Button button in this.Controls)
            {
                if (button.BackColor.Name.Equals(i_PreviusColor.Name))
                {
                    button.Enabled = true;
                    this.m_InUseColor.Remove(i_PreviusColor);
                }
                if (button.BackColor.Name.Equals(i_NewColor.Name))
                {
                    button.Enabled = false;
                    this.m_InUseColor.Add(i_NewColor);
                }
            }
        }

        internal void ReActivacteUsedColors()
        {
            foreach (Button button in this.Controls)
            {
                button.Enabled = true;
            }

            m_InUseColor.Clear();
        }
    }
}