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

namespace HotelReservationSystem
{
    public partial class checkoutform : Form
    {
        Reservation reservation;
       // Room room;

        public checkoutform()
        {
            InitializeComponent();
        }
        public checkoutform( Reservation reservation)
        { 
            InitializeComponent();
            this .reservation = reservation;
            if (reservation.room is SeaView)
                label6.Text = "$300";
            else if (reservation.room is PoolView)
                label6.Text = "$250";
            else
                label6.Text = "$200";
            if (reservation.room.capacity == "Single")
                label7.Text = "$10";
            else if (reservation.room.capacity == "Double")
                label7.Text = "$30";
            else if (reservation.room.capacity == "Triple")
                label7.Text = "$50";
            else
                label7.Text = "$70";
            if (reservation.inclusivity == "All Inclusive")
                label8.Text = "$80";
            else
                label8.Text = "$50";
            label9.Text=reservation.count_days().ToString();


        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
           // label8.Text = reservation.room.roomNumber.ToString();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
