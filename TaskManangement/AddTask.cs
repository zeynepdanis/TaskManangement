using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManangement.Properties;
using XanderUI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace TaskManangement
{
    public partial class AddTask : Form
    {
        List<Card> cards = new List<Card>();
        public List<string> Category = new List<string>();

        Label ilabel = new Label();
        bool hidden = true;

        Card xUICard = null;
        public AddTask()
        {
            InitializeComponent();
            metroComboBox2.Visible = false;
            pnlUptade.Visible = false;
            if (cards !=null)
            {
                Control_Today();
                
                foreach (var item in cards)
                {

                    pnlTask.Controls.Add(item);
                    metroComboBox2.Items.Add(item.category);

                }
            }

            btn_Add.BackColor = Color.Lavender;
        }
        public AddTask(List<Card> card)
        {
            InitializeComponent();
            metroComboBox2.Visible = true;
            pnlUptade.Visible = false;
            this.cards = card;
            if (cards != null)
            {
                foreach (var item in cards)
                {

                    pnlTask.Controls.Add(item);
                    metroComboBox2.Items.Add(item.category);

                }
               
                Control_Today();
            }

            btn_Add.BackColor = Color.Lavender;
        }


       

        private void Card_Click(object sender, EventArgs e)
        {
            xUICard = (Card)sender;
            pnlUptade.Visible = true;
            txt_update.Text = xUICard.Text2;
            if (xUICard.starred == true)
            {
                xuiCheckBox_uptade.Checked = true;
            }
            textBox_uptade_category.Text = xUICard.category;
          


        }

        public void Control_Today()
        {
            if (cards != null)
            {
                foreach (var item in cards)
                {
                    if (item.Text3 == " Due Date : "+DateTime.Now.ToString("yyyy-MM-dd"))
                    {

                        Card card = new Card();
                        card = item;




                         pnlTodayTasks.Controls.Add(card);
                          




                    }
                    
                }

            }

        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
           if(cards != null)
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

       
        private void btnStarred_Click(object sender, EventArgs e)
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

      

        private void metroComboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
           
            if(!string.IsNullOrEmpty(metroComboBox2.Text))
            {
                pnlTask.Controls.Clear();
                if (metroComboBox2.SelectedItem == "ALL")
                {
                    print_Task();

                }

                else
                {


                    foreach (var item in cards)
                    {
                       

                        if (metroComboBox2.SelectedItem == item.category.ToString())
                        {

                            pnlTask.Controls.Add(item);
                        }


                    }


                }

            }

            

        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (rchtxt_task.Text != "")
                {
                    Card card = new Card();
                    card.Text = null;
                    card.Text1 = null;

                    if (xuiCheckBox1.Checked)
                    {
                        card.starred = true;
                        Label ilabel = new Label();

                        Image i = Image.FromFile(@"Images\\icons8-star-30.png"); // read in image
                        
                        ilabel.Size = new Size(i.Width, i.Height); //set label to correct size
                        ilabel.Image = i; // put image on label                        
                      


                        card.Controls.Add(ilabel); // add label t

                    }

                    if (Category.Count!=0)
                    {
                        if (!Category.Contains(textBox1.Text))
                        {
                            Category.Add(textBox1.Text.ToUpper());
                            
                           




                        }

                    }
                    else
                    {

                        if (textBox1.Text != "")
                        {
                            Category.Add(textBox1.Text.ToString());
                           
                           
                        }

                    }


                    card.category = textBox1.Text.ToUpper();

                    card.Text2 = rchtxt_task.Text;
                    card.Text3 = " Due Date : "+ metroDateTime1.Value.ToString("yyyy-MM-dd"); ;
                    cards.Add(card);
                    card.Click += Card_Click;



                    foreach (var item in cards)
                    {

                        pnlTask.Controls.Add(item);
                    }
                    metroComboBox2.Items.Clear();
                    metroComboBox2.Items.Add("ALL");
                    foreach (var item in cards)
                    {
                        if (!metroComboBox2.Items.Contains(item.category))
                        {
                            

                            metroComboBox2.Items.Add(item.category);




                        }

                       
                    }
                    rchtxt_task.Text = "";
                    xuiCheckBox1.Checked = false;
                    textBox1.Text = "";

                }
                else
                {

                    MessageBox.Show("Text Cannot be null");
                }




            }
            catch (Exception)
            {

                throw;
            }
            finally
            {

                Control_Today();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            if (hidden)
            {
                pnlUptade.Visible = true;
                hidden= false;
                
            }
            else
            {
                pnlUptade.Visible = false;
                hidden= true;
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            xUICard.Text2 = txt_update.Text;
            xUICard.Text3=metroDateTime_uptade.Text;
            xUICard.category=textBox_uptade_category.Text;

            


            if (xuiCheckBox_uptade.Checked == true && xUICard.starred==false)
            {
                xUICard.starred = true;
               

                Image i = Image.FromFile(@"Images\\icons8-star-30.png"); 
                ilabel.Size = new Size(i.Width, i.Height); 
                ilabel.Image = i;
                xUICard.Controls.Add(ilabel);



            }
            else if(xUICard.starred == true) 
            {

                xUICard.Controls.Remove(ilabel);
                xUICard.Controls.Clear();
                xuiCheckBox_uptade.Checked=false;



            }

            pnlUptade.Visible = false;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            cards.Remove(xUICard);
            pnlTask.Controls.Clear();
            pnlTodayTasks.Controls.Clear();
            pnlUptade.Visible= false;

            print_Task();
            Control_Today();

        }

        private void print_Task()
        {
            foreach (var item in cards)
            {

                pnlTask.Controls.Add(item);
            }
        }


        private void Check_Category()
        {

            metroComboBox2.Items.Clear();
            metroComboBox2.Items.Add("ALL");
            foreach (var item in cards)
            {
                if (!metroComboBox2.Items.Contains(item.category))
                {


                    metroComboBox2.Items.Add(item.category);




                }


            }

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            pnlUptade.Visible = false;

        }
    }
}
