using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrickBreaker
{
    public partial class MenuScreen : UserControl
    {
        Boolean upPress, downPress = false;

        public MenuScreen()
        {
            InitializeComponent();
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            // Goes to the game screen  
            Form1.ChangeScreen(this,"GameScreen");


        }

        private void lorenAllignment()
        {
            playButton.Location = new Point((this.Width - playButton.Width) / 2, 250);
            exitButton.Location = new Point((this.Width - exitButton.Width) / 2, 370);
            title.Location = new Point((this.Width - title.Width) / 2, 90);
        }

        private void MenuScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    upPress = true;                    
                    break;

                case Keys.Down:
                    downPress = true;                    
                    break;
            }
        }

        private void menuTimer_Tick(object sender, EventArgs e)
        {
            if (upPress == true)
            {
                playButton.Select();
                playButton.BackgroundImage = Properties.Resources.purpbutton;
            }
            else if (downPress == true)
            {
                exitButton.Select();
                exitButton.BackgroundImage = Properties.Resources.purpbutton;
            }
        }

        private void MenuScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    upPress = false;
                    break;

                case Keys.Down:
                    downPress = false;
                    break;
            }
        }
    }
}
