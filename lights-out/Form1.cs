using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lights_out
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Array of buttons which will serve as lights
        private Button[,] lights;
        
        //Boolean array which will serve to check if the buttons(lights) are on or off
        private bool[,] checkLights = new bool[20, 20];
        public MessageBoxButtons MB_OK { get; set; }

        //Coordinates of the lights
        private int gridXPosition;
        private int gridYPosition;

        public void GenerateLights(int gridSizeX, int gridSizeY)
        {
            panel.Controls.Clear();

            lights = new Button[gridSizeX, gridSizeY];

            //Loop through lights array declared above and generate buttons
            for (int i = 0; i < lights.GetLength(1); i++)
            {
                for (int j = 0; j < lights.GetLength(0); j++)
                {
                    lights[i, j] = new Button();
                    lights[i, j].Size = new Size(40, 40);
                    lights[i, j].Name = i.ToString() + j.ToString();
                    lights[i, j].Click += ClickLight;
                    lights[i, j].Location = new Point(20 + (j * 40), 20 + (i * 40));
                    lights[i, j].BackColor = Color.Black;
                    checkLights[i, j] = false;
                    panel.Controls.Add(lights[i, j]);
                }
            }

            GenerateRandomLightsOn();
        }


        #region Helper Methods
        public void GenerateRandomLightsOn()
        {
            Random randomNumber = new Random();
            for (int i = 0; i < randomNumber.Next(1, 100); i++)
            {
                //Get random position of the lights
                int xPosition = randomNumber.Next(0, lights.GetLength(1));
                int yPosition = randomNumber.Next(0, lights.GetLength(0));
                
                ChangeButtonValue(lights[xPosition, yPosition], xPosition, yPosition);
            }
        }

        private TextBox textBox
        {
            get => movesCounter;
            set => moves = movesCounter.Text;
        }

        private string moves;
        int count = 0;
        public void ClickLight(object sender, EventArgs e)
        {
            Button light = sender as Button;
            //Get the index of the button clicked
            int i = (int)Char.GetNumericValue(light.Name[0]);
            int j = (int)Char.GetNumericValue(light.Name[1]);

            //Foreach click of the light we count the moves
            count++;
            if (light != null)
            {
                textBox.Text = count.ToString();
            }

            //Change value of clicked button
            ChangeButtonValueHandler(lights[i, j], i, j);

            //Check if game has finished
            EndGame();
        }


        public void ChangeButtonValueHandler(object sender, int i, int j)
        {
            //Change value of the clicked button
            ChangeButtonValue(lights[i, j], i, j);

            //Change the value of the correct buttons around the clicked one
            if (i > 0)
            {
                ChangeButtonValue(lights[i - 1, j], i - 1, j);
            }
            if (i < (lights.GetLength(1) - 1))
            {
                ChangeButtonValue(lights[i + 1, j], i + 1, j);
            }
            if (j > 0)
            {
                ChangeButtonValue(lights[i, j - 1], i, j - 1);
            }
            if (j < (lights.GetLength(1) - 1))
            {
                ChangeButtonValue(lights[i, j + 1], i, j + 1);
            }

        }

        public void ChangeButtonValue(object sender, int i, int j)
        {
            Button b = sender as Button;

            //Change the boolean value of the button if it's on or off
            checkLights[i, j] = !checkLights[i, j];

            //Set colours of the buttons(lights)
            if (checkLights[i, j] == true)
            {
                b.BackColor = Color.Yellow;
            }
            else
            {
                b.BackColor = Color.Black;
            }

        }

        public void EndGame()
        {
            //Loop through bool array, to check if lights are on or off
            for (int i = 0; i < checkLights.GetLength(1); i++)
            {
                for (int j = 0; j < checkLights.GetLength(0); j++)
                {
                    // If any light is on, the game still continues
                    // Else the game has finished
                    if (checkLights[i, j] == true)
                    {
                        return;
                    }
                }
            }
            
            MessageBox.Show("You won!", "Press ok to exit!", MB_OK);

            ResetToDefault();

        }

        public void ResetToDefault()
        {
            foreach (var item in this.Controls)
            {
                if (item.GetType().Equals(typeof(TextBox)))
                {
                    textBox.Text = string.Empty;
                }

                if (item.GetType().Equals(typeof(Panel)))
                {
                    panel.Controls.Clear();
                }

                if (item.GetType().Equals(typeof(NumericUpDown)))
                {
                    gridX.Value = 0;
                    gridY.Value = 0;
                }
            }
        }
        #endregion

        private void gridX_ValueChanged(object sender, EventArgs e)
        {
            gridXPosition = (int)gridX.Value;
        }

        private void gridY_ValueChanged(object sender, EventArgs e)
        {
            gridYPosition = (int)gridY.Value;
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            GenerateLights(gridXPosition, gridYPosition);
        }

        private void movesCounter_TextChanged(object sender, EventArgs e)
        {
            moves = textBox.Text;
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            ResetToDefault();
        }

        
    }
}
