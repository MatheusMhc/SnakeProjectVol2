using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;

namespace SnakeProjectVol2
{
    public class Test : Form
    {
        protected WaveOut soundPlayer = new WaveOut();


        public void openNewForm(SnakeProjectVol2Form gameScreen)
        {
            this.Hide();
            gameScreen.Show();

        }
    }
}
