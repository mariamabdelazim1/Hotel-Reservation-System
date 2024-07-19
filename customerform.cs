using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HotelReservationSystem
{
    public partial class customerform : Form
    {
        private Room room; private string inclusivity; private DateTime arrival; private DateTime departure;
        Hotel hotel = new Hotel();Customer customer;string name, email, id;int age;Form1 form1;
        public customerform()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text)|| string.IsNullOrWhiteSpace(textBox2.Text)|| string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Please fill all the boxes.");
            }
            else
            {
                getadd();
                customer = new Customer(name, age, email, id);
                Reservation reservation = new Reservation(room, arrival, departure, customer, inclusivity);
                bool flag = hotel.MakeReservation(reservation);
                if (flag == false)
                {
                    MessageBox.Show("Room is unavailable.", "failed", MessageBoxButtons.OK);

                }
                else
                {
                    var displayform = new displayform(this, form1, reservation, customer);
                    displayform.Show();
                }
                this.Close();
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void customerform_Load(object sender, EventArgs e)
        {
            label5.Parent = pictureBox1;
            label5.BackColor = Color.Transparent;
        }

      
       



        public customerform(Form1 form1,Room room, DateTime arrival, DateTime departure, string inclusivity)
        {
            InitializeComponent();
            
            this.room = room;
            this.arrival = arrival;
            this.departure = departure;
            this.inclusivity = inclusivity;
            this.form1 = form1;
           

        }
        public void getadd()
        {
            this.name = textBox1.Text; this.email= textBox2.Text;   this.id = textBox3.Text;
            this.age = Convert.ToInt32(numericUpDown1.Value);
        }
    }
}
