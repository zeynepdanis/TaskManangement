using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace TaskManangement
{
    public partial class Home : Form
    {

      
        List<Card> cards = new List<Card>();
        public Home()
        {
            InitializeComponent();
            metroComboBox1.Visible = false;
            btn_Home.BackColor = Color.Lavender;
            lbl_time.Text = DateTime.Now.ToString();
           
        }
        public Home(List<Card> card)
        {

            InitializeComponent();
            metroComboBox1.Visible = true;
            btn_Home.BackColor = Color.Lavender;
            this.cards = card;
          

            lbl_time.Text = DateTime.Now.ToString();
            metroComboBox1.Items.Add("ALL");
            if (cards != null)
            {
                foreach (var item in cards)
                {
                    if (item.Text3 == " Due Date : " + DateTime.Now.ToString("yyyy-MM-dd"))
                    {




                        pnl_TodayTask.Controls.Add(item);
                        metroComboBox1.Items.Add(item.category);




                    }

                }

            }



        }
        private void btn_Home_Click(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {

            if(cards != null)
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

        private void button1_Click(object sender, EventArgs e)
        {

            if (cards != null)
            {
                Starred starred = new Starred(cards);
                starred.Show();
            }
            else
            {
                Starred starred = new Starred();
                starred.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(metroComboBox1.Text))
            {
                pnl_TodayTask.Controls.Clear();
                if (metroComboBox1.SelectedItem == "ALL")
                {
                    foreach (var item in cards)
                    {

                        pnl_TodayTask.Controls.Add(item);
                    }


                }

                else
                {


                    foreach (var item in cards)
                    {


                        if (metroComboBox1.SelectedItem == item.category.ToString())
                        {

                            pnl_TodayTask.Controls.Add(item);
                        }


                    }


                }

            }
        }
    }
}
