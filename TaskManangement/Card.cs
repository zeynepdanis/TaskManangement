using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XanderUI;

namespace TaskManangement
{
    public class Card:XUICard
    {


        public bool starred { get; set; }
        public string category { get; set; }

        public Card()
        {


            this.Color1 = System.Drawing.Color.DodgerBlue;
            this.Color2 = System.Drawing.Color.BlueViolet;
            this.Dock = System.Windows.Forms.DockStyle.Top;
            this.Height = 100;
           

            starred = false;
            




        }
    }
}
