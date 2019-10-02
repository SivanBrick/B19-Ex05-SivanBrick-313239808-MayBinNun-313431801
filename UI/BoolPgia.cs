using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace UI
{
    public partial class BoolPgiaForm : Form
    {

        private readonly Button[][] r_UserChoisesButtons;
        private readonly Button[] r_ShowResultButton;
        private readonly Button[][] r_ResultMatrix;
        private Button[] m_BlackButtonList;
        PickAcolorForm m_PickAColor = new PickAcolorForm();
        private List<Logic.eGuessFrom> m_RandomSequence = Logic.BullsandCows.Randsequence();
        private int m_NumOfTrial = 0;
        private int m_UserAnswerNumOfGuesses = 0;
        private bool m_IsWon = false;
        private const int k_HigthLineSeperator = 60;
        private const int k_SpaceSeperatorUserChoise = 66;
        private const int k_ResultMatrixSpace = 30;
      
        public BoolPgiaForm(int i_NumOfGuesses)
        {
            this.m_UserAnswerNumOfGuesses = i_NumOfGuesses;
            InitializeComponent();
            r_UserChoisesButtons = new Button[i_NumOfGuesses][];
            r_ShowResultButton = new Button[i_NumOfGuesses];
            r_ResultMatrix = new Button[i_NumOfGuesses][];

            createBlackButtons();
            createUserChoiceButtons(i_NumOfGuesses);
            createShowResultButtons(i_NumOfGuesses);
            createResultMatrixs(i_NumOfGuesses);

            enableButtonsRow(r_UserChoisesButtons[m_NumOfTrial], true);
        }


        private void createBlackButtons()
        {
            m_BlackButtonList = new Button[4];

            for (int i = 0; i < 4; i++)
            {
                Button blackButton = new Button();
                blackButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
                blackButton.Enabled = false;
                blackButton.Location = new System.Drawing.Point(13 + (k_SpaceSeperatorUserChoise * i), 12);
                blackButton.Size = new System.Drawing.Size(60, 55);
                m_BlackButtonList[i] = blackButton;
            }

            this.Controls.AddRange(m_BlackButtonList);
        }

        private void createResultMatrixs(int i_NumOfGuesses)
        {
            for (int i = 0; i < i_NumOfGuesses; i++)
            {
                Button[] resultMatrix = new Button[4];

                for (int j = 0; j < 2; j++)
                {
                    Button RigthResultButton = new Button();
                    RigthResultButton.Enabled = false;
                    RigthResultButton.Size = new System.Drawing.Size(23, 24);

                    Button LeftResultButton = new Button();
                    LeftResultButton.Enabled = false;
                    LeftResultButton.Size = new System.Drawing.Size(23, 24);

                    LeftResultButton.Location = new System.Drawing.Point(337 , 98 + (k_ResultMatrixSpace * (2*i+j)));
                    RigthResultButton.Location = new System.Drawing.Point(367 , 98 + (k_ResultMatrixSpace * (2*i+j)));
                    
                    resultMatrix[2*j] = LeftResultButton;
                    resultMatrix[(2*j) + 1] = RigthResultButton;
                    
                }

                r_ResultMatrix[i] = resultMatrix;
                this.Controls.AddRange(resultMatrix);
            }

        }

        private void createShowResultButtons(int i_NumOfGuesses)
        {
            for (int i = 0; i < i_NumOfGuesses; i++)
            {
                Button showResult = new Button();
                showResult.Enabled = false;
                showResult.Location = new System.Drawing.Point(279, (109 + k_HigthLineSeperator*i));
                showResult.Size = new System.Drawing.Size(52, 30);
                showResult.Text = "-->>";
                showResult.UseVisualStyleBackColor = true;
                showResult.Click += new EventHandler(showResult_Click);
                r_ShowResultButton[i] = showResult;        
            }

            this.Controls.AddRange(r_ShowResultButton);
        }

        private void showResult_Click(object sender, EventArgs e)
        {
            (sender as Button).Enabled = false;
            enableButtonsRow(r_UserChoisesButtons[m_NumOfTrial], false);
            List<Logic.eGuessFrom> userCurrentGuess = convertUserGuess(r_UserChoisesButtons[m_NumOfTrial]);
            string userFeedback = Logic.BullsandCows.UserFeedback(m_RandomSequence , userCurrentGuess);
            revealUserFeedback(userFeedback);
            this.m_NumOfTrial++;

            if (m_NumOfTrial < m_UserAnswerNumOfGuesses && (!this.m_IsWon))
            {
                enableButtonsRow(r_UserChoisesButtons[m_NumOfTrial], true);
            }
            else
            {
                revealAnswer();
            }
            
        }

        private void revealAnswer()
        {
            int indexOfBlackButton = 0;

            foreach (Logic.eGuessFrom color in this.m_RandomSequence)
            {
                Color currentColor = Color.FromName(color.ToString());
                this.m_BlackButtonList[indexOfBlackButton].BackColor = currentColor;
                indexOfBlackButton++;
            }
        }

        private void revealUserFeedback(string i_userFeedback)
        {
            int indexInMatrix = 0;
            int numOfHeat = 0;

            foreach (Char ans in i_userFeedback)
            {

                if (ans.Equals('V'))
                {
                    numOfHeat++;
                    (this.r_ResultMatrix[m_NumOfTrial][indexInMatrix]).BackColor = Color.Black;
                }
                else
                {
                    (this.r_ResultMatrix[m_NumOfTrial][indexInMatrix]).BackColor = Color.Yellow;
                }

                indexInMatrix++;
            }

            m_IsWon = (numOfHeat == 4);

            if (!(m_IsWon))
            {
                m_PickAColor.ReActivacteUsedColors();
            }
        }

        private List<Logic.eGuessFrom> convertUserGuess(Button[] i_Buttons)
        {
            List<Logic.eGuessFrom> userGuess = new List<Logic.eGuessFrom>();

            foreach (Button button in i_Buttons)
            {
                Enum.TryParse<Logic.eGuessFrom>(button.BackColor.Name, out Logic.eGuessFrom color);
                userGuess.Add(color);
            }

            return userGuess;
        }

        private void createUserChoiceButtons(int i_NumOfGuesses)
        {
            
            for (int i = 0; i < i_NumOfGuesses; i++)
            {
                Button[] userChoiceLine = new Button[4];
                for (int j = 0; j < 4; j++)
                {
                    Button userChoice = new Button();
                    userChoice.Enabled = false;
                    userChoice.BackColor = System.Drawing.SystemColors.ActiveBorder;
                    userChoice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
                    userChoice.Location = new System.Drawing.Point(13 + (k_SpaceSeperatorUserChoise*j), 97 + (k_HigthLineSeperator*i));
                    userChoice.Size = new System.Drawing.Size(60, 55);
                    userChoice.Click += new EventHandler(userChoice_Click);
                    userChoiceLine[j] = userChoice;
                }

                r_UserChoisesButtons[i] = userChoiceLine;
                this.Controls.AddRange(userChoiceLine);
            }
        }

        private void userChoice_Click(object sender, EventArgs e)
        {
            var result = m_PickAColor.ShowDialog();
            Color currentButtonColor = (sender as Button).BackColor;

            if (result == DialogResult.OK)
            {
                Color change = m_PickAColor.PickedColor;
                m_PickAColor.UpdateColorList(currentButtonColor, change);
                (sender as Button).BackColor = (Color)change;
            }

            if (m_PickAColor.InUseColor.Count == 4)
            {
                r_ShowResultButton[m_NumOfTrial].Enabled = true;
            }

        }

        private void enableButtonsRow(Button[] i_UserChoice , bool i_IfEnable)
        {
            foreach (Button button in i_UserChoice)
            {
                button.Enabled = i_IfEnable;
            }
        }

    }
}
