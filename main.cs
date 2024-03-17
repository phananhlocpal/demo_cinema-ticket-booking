using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BaitapBonus2
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            

        }

        private void ReadFileAndPopulateListView()
        {
            try
            {
                ltvBooked.Items.Clear();
                ltvBooked.Columns.Clear();

                ltvBooked.View = View.Details;
                ltvBooked.Columns.Add("Date", 200);
                ltvBooked.Columns.Add("Number of Seats", 100);
                ltvBooked.Columns.Add("Status", 100); 

                string[] lines = File.ReadAllLines(@"C:\Users\Surface\source\repos\dotnetLab4\BaitapBonus2\seat_status.txt");

                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    string date = parts[0];
                    string seatNumbers = parts[1];
                    string state = parts[2];

                    // Create a ListViewItem and add it to the ListView
                    ListViewItem item = new ListViewItem(new string[] { date, seatNumbers, state });
                    ltvBooked.Items.Add(item);   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading file: {ex.Message}");
            }
        }

        private void ckbNormal_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbNormal.Checked )
            {
                nudNormal.Value = 1;
                ckbVIP.Checked = false;
                ckbCouple.Checked = false;
            }
            else
            {
                nudNormal.Value = 0;
            }
        }

        private void ckbVIP_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbVIP.Checked)
            {
                nudVIP.Value = 1;
                ckbNormal.Checked = false;
                ckbCouple.Checked = false;
            }
            else
            {
                nudVIP.Value = 0;
            }
        }

        private void ckbCouple_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbCouple.Checked)
            {
                nudCouple.Value = 1;
                ckbVIP.Checked = false;
                ckbNormal.Checked = false;
            }
            else
            {
                nudCouple.Value = 0;
            }
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            string type = "";
            int num = 0;
            
            if (ckbNormal.Checked && nudNormal.Value != 0)
            {
                type = "Normal";
                num = (int)nudNormal.Value;
                openForm1(type, num);
                
            }
            else if (ckbCouple.Checked && nudCouple.Value != 0)
            {
                type = "Couple";
                num = (int)nudCouple.Value;
                openForm1(type, num);
            }
            else if (ckbVIP.Checked && nudVIP.Value != 0)
            {
                type = "VIP";
                num = (int)nudVIP.Value;
                openForm1(type, num);
            }    
            else
            {
                MessageBox.Show("Bạn cần chọn loại vé và số lượng!");
            }
            
        }

        private void openForm1(string type, int num)
        {
            Form1 form = new Form1(type, num);
            form.FormClosed += Form_FormClosed;
            this.Hide();
            form.Show();
        }
        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void nudNormal_ValueChanged(object sender, EventArgs e)
        {
            if (nudNormal.Value == 0) 
            { 
                ckbNormal.Checked = false;
            }
            else if (nudNormal.Value > 0)
            {
                ckbNormal.Checked = true;
            }
            
        }

        private void nudVIP_ValueChanged(object sender, EventArgs e)
        {
            if (nudVIP.Value == 0)
            {
                ckbVIP.Checked = false;
            }
            else
            {
                ckbVIP.Checked = true;
            }
        }

        private void nudCouple_ValueChanged(object sender, EventArgs e)
        {
            if (nudCouple.Value == 0)
            {
                ckbCouple.Checked = false;
            }
            else 
            {
                ckbCouple.Checked = true;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void main_Load(object sender, EventArgs e)
        {
            ReadFileAndPopulateListView();
        }
    }
}
