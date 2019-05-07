using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace BrickBreaker
{
    public partial class Form1 : Form
    {
        public static bool twoPlayer = true; 
        public Form1()
        {
            InitializeComponent();
        }
        // wow ! ;D
        private void Form1_Load(object sender, EventArgs e)
        {
             //Start the program centred on the Menu Screen
             MenuScreen ms = new MenuScreen();
             this.Controls.Add(ms);

             ms.Location = new Point((this.Width - ms.Width) / 2, (this.Height - ms.Height) / 2);


            
        }

        public static void ChangeScreen(UserControl current, string next)
        {
            //f is set to the form that the current control is on
            Form f = current.FindForm();
            f.Controls.Remove(current);
            UserControl ns = null;
            
            //switches screen
            switch (next)
            {
                case "MenuScreen":
                    ns = new MenuScreen();
                    break;
                case "GameScreen":
                    ns = new GameScreen();
                    break;
                case "HighScreen":
                    ns = new HighScreen();
                    break;
                case "NameScreen":
                    ns = new NameScreen1();
                    break;
            }
            //centres on the screen
            ns.Location = new Point((f.Width - ns.Width) / 2, (f.Height - ns.Height) / 2);
           
            f.Controls.Add(ns);
            ns.Focus();
        }
    }
}
