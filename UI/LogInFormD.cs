using System;
using System.Windows.Forms;

namespace UI
{
    public partial class LogInFormD : Form
    {
        int m_clickCounter = 4;

        public LogInFormD()
        {
            InitializeComponent();
            this.buttonChances.Click += new EventHandler(ButtonChances_Click);
            this.buttonStart.Click += new EventHandler(ButtonStart_Click);
        }

        public int GetNumOfGuesses
        {
            get { return m_clickCounter; }
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        
        private void ButtonChances_Click(object sender, EventArgs e)
        {

            m_clickCounter++;

            if (m_clickCounter > 10)
            {
                m_clickCounter = 4;
            }

            if (buttonChances != null)
            {
                this.buttonChances.Text = "Number of chances : " + m_clickCounter.ToString();
            }
            
        }
    }
}
