using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Engine;

namespace Stellar_Witch
{
    public partial class Form1 : Form
    {
        private Player _player;
        public Form1()
        {
            InitializeComponent();


            



            _player = new Player(10, 10, 20, 0, 1);

            
            lblHitPoints.Text = _player.CurrentHP.ToString();
            lblGold.Text = _player.Gold.ToString();
            lblExperience.Text = _player.Exp.ToString();
            lblLevel.Text = _player.Level.ToString();

 
        }

    }
}
