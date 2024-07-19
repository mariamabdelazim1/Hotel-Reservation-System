using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HotelReservationSystem
{
    public partial class ReservationForm : Form
    {
        Hotel hotel=new Hotel(); Form1 form1;
        private string roomtype; private string capacity; private string inclusivity;private DateTime arrival; private DateTime departure; int roomnumber;
        public void getAdd()
        {
             roomtype = comboBox1.SelectedItem.ToString();
            capacity = comboBox2.SelectedItem.ToString();
            arrival = dateTimePicker1.Value;
            departure = dateTimePicker2.Value;

        }
        public ReservationForm(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton selectedRadioButton = (RadioButton)sender;
            if (selectedRadioButton.Checked)
            {
                inclusivity = "All Inclusive";
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
             getAdd(); Room room; 
            if (roomtype == "Sea View")
            { 
            
                if (capacity == "Single")
                {
                    foreach (SeaView seaRoom in hotel.SeaRooms)
                    {
                        if (seaRoom.capacity == "Single")
                        {
                            roomnumber = seaRoom.roomNumber;
                        }
                    }
                }
                else if (capacity == "Double")
                {
                    foreach (SeaView seaRoom in hotel.SeaRooms)
                    {
                        if (seaRoom.capacity == "Double")
                        {
                            roomnumber = seaRoom.roomNumber;
                        }
                    }
                }
                else if (capacity == "Triple")
                {
                    foreach (SeaView seaRoom in hotel.SeaRooms)
                    {
                        if (seaRoom.capacity == "Triple")
                        {
                            roomnumber = seaRoom.roomNumber;
                        }
                    }
                }
                else
                {
                    foreach (SeaView seaRoom in hotel.SeaRooms)
                    {
                        if (seaRoom.capacity == "Suite")
                        {
                            roomnumber = seaRoom.roomNumber;
                        }
                    }
                }

                room = new SeaView(roomnumber, capacity);
            }
            
            else if (roomtype=="Garden View")
            {
                if (capacity == "Single")
                {
                    foreach (GardenView gardenRooom in hotel.GardenRooms)
                    {
                        if (gardenRooom.capacity == "Single")
                        {
                            roomnumber = gardenRooom.roomNumber;
                        }
                    }
                }
                else if (capacity == "Double")
                {
                    foreach (GardenView gardenRooom in hotel.GardenRooms)
                    {
                        if (gardenRooom.capacity == "Double")
                        {
                            roomnumber = gardenRooom.roomNumber;
                        }
                    }
                }
                else if (capacity == "Triple")
                {
                    foreach (GardenView gardenRooom in hotel.GardenRooms)
                    {
                        if (gardenRooom.capacity == "Triple")
                        {
                            roomnumber = gardenRooom.roomNumber;
                        }
                    }
                }
                else
                {
                    foreach (GardenView gardenRooom in hotel.GardenRooms)
                    {
                        if (gardenRooom.capacity == "Suite")
                        {
                            roomnumber = gardenRooom.roomNumber;
                        }
                    }
                }
                room = new GardenView(roomnumber, capacity);

            }
            else
            {
                if (capacity == "Single")
                {
                    foreach (PoolView poolRoom in hotel.PoolRooms)
                    {
                        if (poolRoom.capacity == "Single")
                        {
                            roomnumber = poolRoom.roomNumber;
                        }
                    }
                }
                else if (capacity == "Double")
                {
                    foreach (PoolView poolRoom in hotel.PoolRooms)
                    {
                        if (poolRoom.capacity == "Double")
                        {
                            roomnumber = poolRoom.roomNumber;
                        }
                    }
                }
                else if (capacity == "Triple")
                {
                    foreach (PoolView poolRoom in hotel.PoolRooms)
                    {
                        if (poolRoom.capacity == "Triple")
                        {
                            roomnumber = poolRoom.roomNumber;
                        }
                    }
                }
                else
                {
                    foreach (PoolView poolRoom in hotel.PoolRooms)
                    {
                        if (poolRoom.capacity == "Suite")
                        {
                            roomnumber = poolRoom.roomNumber;
                        }
                    }
                }

                room = new PoolView(roomnumber,capacity);
            }

            //room = new SeaView();
            var customerform = new customerform(form1, room, arrival, departure, inclusivity);
            customerform.Show();
            //this.Hide();
            this.Close();   
        }

        private void ReservationForm_Load(object sender, EventArgs e)
        {
            label7.Parent = pictureBox1;
            label7.BackColor = Color.Transparent;
            hotel.AddSeaRoom(new SeaView(1, "Single"));
            hotel.AddSeaRoom(new SeaView(2, "Double"));
            hotel.AddSeaRoom(new SeaView(3, "Triple"));
            hotel.AddSeaRoom(new SeaView(4, "Suite"));
            hotel.AddPoolRoom(new PoolView(5, "Single"));
            hotel.AddPoolRoom(new PoolView(6, "Double"));
            hotel.AddPoolRoom(new PoolView(7, "Triple"));
            hotel.AddPoolRoom(new PoolView(8, "Suite"));
            hotel.AddGardenRoom(new GardenView(9, "Single"));
            hotel.AddGardenRoom(new GardenView(10, "Double"));
            hotel.AddGardenRoom(new GardenView(11, "Triple"));
            hotel.AddGardenRoom(new GardenView(12, "Suite"));
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            RadioButton selectedRadioButton = (RadioButton)sender;
            if (selectedRadioButton.Checked)
            {
                inclusivity = "Half Board";
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
