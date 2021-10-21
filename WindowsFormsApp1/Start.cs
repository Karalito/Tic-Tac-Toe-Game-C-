using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();

        }

        private static int levelValue;
        private int randomStart;

        public int AvailableLevels(string levelName)
        {
            if (levelName == "3x3")
                return 3;
            else if (levelName == "4x4")
                return 4;
            else if (levelName == "5x5")
                return 5;
            else if (levelName == "6x6")
                return 6;
            else
                return 0;
        }
        public int RandomXorO(int range, int range1)
        {
            Random rnd = new Random();
            return rnd.Next(range,range1);
        }
        public void startButton_Click(object sender, EventArgs e)
        {
            // Vieta žaidimo lygiui tikrinti
            if (levelBox.SelectedItem != null)
            {
                string levelName = levelBox.Text;
                levelValue = AvailableLevels(levelName);

                // Tikrinimas kuris žaidėjas pirmas praddės žaidimą
                if(!checkX.Checked && !checkO.Checked || checkX.Checked && checkO.Checked)
                {
                    checkX.Checked = false;
                    checkO.Checked = false;
                    randomStart = RandomXorO(0,2);
                    if (randomStart == 0)
                        checkX.Checked = true;
                    else if (randomStart == 1)
                        checkO.Checked = true;
                    else
                        MessageBox.Show("Klaida! 00");

                }
                if(checkX.Checked)
                {
                    Game game = new Game(levelValue, checkX.Text);
                    this.Hide();
                    game.FormClosed += (s, args) => this.Close();
                    game.Show();

                }
                else if (checkO.Checked)
                {
                    Game game = new Game(levelValue, checkO.Text);
                    this.Hide();
                    game.FormClosed += (s, args) => this.Close();
                    game.Show();
                }
            }
            else
                MessageBox.Show("Privalote pasirinkti žaidimo lygį!", "Negalima pradėti žaidimo");

        }
    }
}
