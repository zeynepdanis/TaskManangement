using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManangement
{
    public partial class Starred : Form
    {

        List<Card> cards = new List<Card>();
        public Starred()
        {
           
            InitializeComponent();
            button1.BackColor = Color.Lavender;
        }
        public Starred(List<Card> card)
        {
            InitializeComponent();
            button1.BackColor = Color.Lavender;
            this.cards = card;
            if (cards != null)
            {
                foreach (var item in cards)
                {
                    if (item.starred == true)
                    {




                        pnlStarred.Controls.Add(item);





                    }

                }

            }
        }
        private void xuiBtn_AddTask_Click(object sender, EventArgs e)
        {
            if (cards != null)
            {
                AddTask addTask = new AddTask(cards);
                addTask.Show();
            }
            else
            {
                AddTask addTask = new AddTask();
                addTask.Show();
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (cards != null)
            {
                AddTask addTask = new AddTask(cards);
                addTask.Show();
            }
            else
            {
                AddTask addTask = new AddTask();
                addTask.Show();
            }
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            if (cards != null)
            {
                Home home = new Home(cards);
                home.Show();
            }
            else
            {
                Home home = new Home();
                home.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
