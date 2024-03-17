using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace BaitapBonus2
{
    public partial class Form1 : Form
    {
        List<CustomButton> seatList = new List<CustomButton>();
        main main = new main();
        private string typeSeat;
        private int num;

        public string TypeSeat { get => typeSeat; set=> typeSeat=value; }
        public int Num { get => num; set => num=value; }

        public Form1(string type, int num)
        {
            InitializeComponent();
            this.TypeSeat = type;
            this.Num = num;

            int h = 30;
            int w = 40;
            int left = 10;
            int distance = 10;

            int normalRow = 3;
            int normalCol = 16;
            int vipRow = 10;
            int vipCol = 16;
            int coupleRow = 1;
            int coupleCol = 6;

           

            // Tạo ghế thường
            createSeat(normalRow, normalCol, left, 0, "Normal");
            // Tạo ghế VIP
            createSeat(vipRow, vipCol, left, normalRow, "VIP");
            // Tạo ghế đôi
            createSeat(coupleRow, coupleCol, left, normalRow + vipRow, "Couple");

            //cmbType.SelectedIndex = 0;
            

            int[] cols = { normalCol, vipCol, coupleCol };
            int maxCol = cols.Max();

            this.ClientSize = new Size(distance + 16 * (w + distance), distance + (normalRow+vipRow+coupleRow)* (distance + h) + pnlheader.Height + pnlFooter.Height);
        }



        public class CustomButton : Button
        {
            public bool state { get; set; }
            public string type { get; set; }
            public bool booked { get; set; }

            public CustomButton() : base()
            {
                state = false;
                type = "Normal"; 
                booked = false;
            }
        }

        private void createSeat(int numRow, int numCol, int left, int numTopSeat, string type)
        {
            int h = 30;
            int w = 40;
            int distance = 10;
            List<char> arr = new List<char>() { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O' };
            CustomButton btn = null;
            int temp = 0;
            for (int row = 1; row <= numRow; row++)
            {
                for (int col = 1; col <= numCol; col++)
                {
                    btn = new CustomButton();
                    btn.ForeColor = Color.White;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.state = false;
                    btn.type = type;
                    btn.Height = h;
                    btn.Top = numTopSeat * (h + distance) + (distance + h) * (row - 1);
                    if (type == "Couple")
                    {
                        btn.BackColor = Color.DeepPink;
                        btn.Width = 2*w;
                        btn.Left = left + (distance + 2*w) * (col - 1);

                        // Row = char, col = num

                        btn.Text = $"{arr[row - 1 + numTopSeat]}{col + temp} {arr[row - 1 + numTopSeat]}{col+1 + temp}";
                        temp += 1;
                    }
                    else
                    {
                        if (type == "Normal")
                        {
                            btn.BackColor = Color.Purple;
                        }
                        else if (type == "VIP")
                        {
                            btn.BackColor = Color.Red;
                        }
                        btn.Width = w;
                        btn.Left = left + (distance + w) * (col - 1);
                        // Row = char, col = num
                        btn.Text = $"{arr[row - 1 + numTopSeat]}{col}";
                    }
                    
                    
                    // Xử lý sự kiện cho Button. Trạng thái choose và not choose
                    btn.Click += btn_Click;
                    pnlMain.Controls.Add(btn);
                }
            }
            
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if ((sender as CustomButton).booked == false)
            {
                if (seatList.Count + 1 <= num || (sender as CustomButton).state == true)
                {
                    if (TypeSeat == (sender as CustomButton).type)
                    {
                        if ((sender as CustomButton).state == false)
                        {
                            AddSeat((sender as CustomButton));
                            (sender as CustomButton).BackColor = Color.Green;
                            (sender as CustomButton).state = true;
                        }
                        else
                        {
                            DeleteSeat((sender as CustomButton));
                            if ((sender as CustomButton).type == "Normal")
                            {
                                (sender as CustomButton).BackColor = Color.Purple;
                            }
                            else if ((sender as CustomButton).type == "VIP")
                            {
                                (sender as CustomButton).BackColor = Color.Red;
                            }
                            else if ((sender as CustomButton).type == "Couple")
                            {
                                (sender as CustomButton).BackColor = Color.DeepPink;
                            }
                            (sender as CustomButton).state = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Bạn đang đặt vé {TypeSeat}");
                    }
                }
                else
                {
                    MessageBox.Show($"Số lượng vé bạn book là {num}");
                }
            }
            else
            {
                MessageBox.Show("Ghế này đã được đặt chỗ!");
            }
            
            

        }
            
        private void AddSeat(CustomButton btn)
        {
            
            seatList.Add(btn);
            lblSeat.Text = PrintStringSeat(seatList);
            decimal totalPrice = calculateSeat(seatList);
            string formattedPrice = totalPrice.ToString("N0") + " Đ";
            lblPrice.Text = formattedPrice;
        }

        private string PrintStringSeat(List<CustomButton> seatList)
        {
            string str = "";
            foreach (Button btn in seatList)
            {
                str += btn.Text + ", ";
            }
            return str;
        }

        private void DeleteSeat(CustomButton btn)
        {

            seatList.Remove(btn);
            if (PrintStringSeat(seatList) == "")
            {
                lblSeat.Text = "Bạn chưa chọn ghế!";
            }    
            else
            {
                lblSeat.Text = PrintStringSeat(seatList);
            }
            decimal totalPrice = calculateSeat(seatList);
            string formattedPrice = totalPrice.ToString("N0") + " Đ";
            lblPrice.Text =  formattedPrice;
        }

        private int calculateSeat(List<CustomButton> seatList)
        {
            int sum = 0; 
            foreach (CustomButton btn in seatList)
            {
                if (btn.type == "Normal")
                {
                    sum = sum + 120000;
                }
                else if (btn.type == "VIP")
                {
                    sum = sum + 130000;
                }
                else
                {
                    sum = sum + 290000;
                }
            }
            return sum;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader reader = new StreamReader(@"C:\Users\Surface\source\repos\dotnetLab4\BaitapBonus2\seat_status.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length >= 3 && parts[2] == "Booked")
                        {
                            string buttonText = parts[1];
                            
                            CustomButton targetButton = pnlMain.Controls.OfType<CustomButton>().FirstOrDefault(btn => btn.Text == buttonText);
                            if (targetButton != null)
                            {
                                
                                targetButton.state = true;
                                targetButton.booked = true;
                                
                                targetButton.BackColor = Color.DarkGray;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading from file: {ex.Message}");
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (seatList.Count != num)
            {
                MessageBox.Show("Bạn chưa đặt đủ chỗ!");
            }
            else
            {
                DateTime now = DateTime.Now;
                saveSate(now, seatList, "Booked");
                MessageBox.Show($"Bạn đã đặt các ghế {PrintStringSeat(seatList)} với số tiền là {lblPrice.Text}");
                List<CustomButton> buttonsToRemove = new List<CustomButton>();

                foreach (CustomButton btn in seatList)
                {
                    buttonsToRemove.Add(btn);
                }

                foreach (CustomButton btn in buttonsToRemove)
                {
                    btn.state = false;
                    if (btn.type == "Normal")
                    {
                        btn.BackColor = Color.Purple;
                    }
                    else if (btn.type == "VIP")
                    {
                        btn.BackColor = Color.Red;
                    }
                    else
                    {
                        btn.BackColor = Color.DeepPink;
                    }
                    seatList.Remove(btn);
                }

                lblPrice.Text = "0 Đ";
                lblSeat.Text = "Bạn chưa chọn ghế!";


                main.FormClosed += closeForm;
                this.Hide();
                main.Show();
            }
        }


        private void saveSate(DateTime now, List<CustomButton> seatList, string state)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(@"C:\Users\Surface\source\repos\dotnetLab4\BaitapBonus2\seat_status.txt", true))
                {
                    foreach (CustomButton seat in seatList)
                    {
                        writer.WriteLine($"{now.ToString()},{seat.Text},{state}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error writing to file: {ex.Message}");
            }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            main.FormClosed += closeForm;
            this.Hide();
            main.Show();
        }

        private void closeForm(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class SeatStatus
    {
        public int SeatNumber { get; set; }
        public bool IsBooked { get; set; }
    }
}

