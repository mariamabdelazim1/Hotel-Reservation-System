using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservationSystem
{
    public partial class displayform : Form
    {
        Reservation reservation;Customer customer; customerform Customerform;Form form1;
        public displayform()
        {
            InitializeComponent();
        }
        public displayform(customerform Customerform,Form1 form1,Reservation reservation,Customer customer)
        {            
            InitializeComponent();

            label7.Text=reservation.room.roomNumber.ToString();
            label8.Text= reservation.room.capacity;
            label9.Text= reservation.Datefrom.ToString();
            label10.Text= reservation.Dateto.ToString();
            label12.Text = "$"+reservation.FinalPrice().ToString(); 
            this.reservation = reservation;
            this.customer = customer;
            this.Customerform = Customerform;   
            this.form1 = form1;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Thank you for your reservation, {customer.Name}");
            this.Close();
            form1.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            var checkoutform = new checkoutform(reservation);
            checkoutform.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
