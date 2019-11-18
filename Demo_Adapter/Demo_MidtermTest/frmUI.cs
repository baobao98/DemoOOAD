using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_MidtermTest
{
    public partial class frmUI : Form
    {
        public frmUI()
        {
            InitializeComponent();
            TextBox.CheckForIllegalCrossThreadCalls = false;
            

        }


        private void radio2pin_CheckedChanged(object sender, EventArgs e)
        {

        }
        int Xpin2_Old;
        int Ypin2_Old;
        int Xpin3_Old;
        int Ypin3_Old;
        int Ypin3Adapter_Old;
        int Xpin3Adapter_Old;
        private void frmUI_Load(object sender, EventArgs e)
        {
            Xpin2_Old = pictureBox2.Location.X;
            Ypin2_Old = pictureBox2.Location.Y;
            Xpin3_Old = pictureBox3.Location.X;
            Ypin3_Old = pictureBox3.Location.Y;
            Xpin3Adapter_Old = pictureBox4.Location.X;
            Ypin3Adapter_Old = pictureBox4.Location.Y;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.BringToFront();
            pictureBox2.BringToFront();

        }
       
        private void buttonConnect_Click(object sender, EventArgs e)
        {
            buttonAdapter.Enabled = false;
            buttonReset.Enabled = false;
            buttonConnect.Enabled = false;
            if (radio2pin.Checked == true)
            {
                Thread a = new Thread(() =>
                {
                    connect(2);
                    
                 
                });
                a.Start();
                pictureBox5.Visible = true;
               

            }
            else
            {
                Thread a = new Thread(() =>
                {
                    connect(3);
                });
                a.Start();
                pictureBox6.Visible = true;
                

            }

        }
        void connect(int pin)
        {
            resset();
            switch (pin)
            {
              
              
                case 2:
                    {
                        ThreadStart t = new ThreadStart(pin2);
                        Thread thr1 = new Thread(t);
                        thr1.IsBackground = true;
                        thr1.Start();
                        thr1.Join();
                        
                    }
                 
                    break;
                case 3:
                    {
                        ThreadStart t = new ThreadStart(pin3);
                        Thread thr1 = new Thread(t);
                        thr1.IsBackground = true;
                        thr1.Start();
                        thr1.Join();
                    }
                    break;

            }
           
        }
        void connectAdapter(int pin)
        {
            resset();
            switch (pin)
            {


                case 2:
                    {
                        ThreadStart t = new ThreadStart(pin2Adpater);
                        Thread thr1 = new Thread(t);
                        thr1.IsBackground = true;
                        thr1.Start();
                        thr1.Join();
                    }

                    break;
                case 3:
                    {
                        ThreadStart t = new ThreadStart(pin3Adpater);
                        Thread thr1 = new Thread(t);
                        thr1.IsBackground = true;
                        thr1.Start();
                        thr1.Join();
                    }
                    break;

            }

        }
        void pin2()
        {
           

            pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y + Cons.hight + 10);
            Thread.Sleep(100);

            while (pictureBox2.Location.X < 370)
            {
                pictureBox2.Location = new Point(pictureBox2.Location.X + 10, pictureBox2.Location.Y);
                Thread.Sleep(100);

            }

            pictureBox2.Location = new Point(400, 100);
            pictureBox5.Visible = true;
            pictureBox2.Visible = false;
            pictureBox1.Visible = false;
            //pictureBox1.BackColor = Color.Transparent;
            Thread.Sleep(100);
            MessageBox.Show("Connect!!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            buttonAdapter.Enabled = true;
            buttonReset.Enabled = true;
            buttonConnect.Enabled = true;

        }
        void pin3()
        {
            int xi = pictureBox3.Location.X;
            int yi = pictureBox3.Location.Y;

            pictureBox3.Location = new Point(pictureBox3.Location.X, pictureBox3.Location.Y - Cons.hight - 10);
            Thread.Sleep(100);

            while (pictureBox3.Location.X < 370)
            {
                pictureBox3.Location = new Point(pictureBox3.Location.X + 10, pictureBox3.Location.Y);
                Thread.Sleep(100);

            }

            pictureBox3.Location = new Point(400, 100);
            Thread.Sleep(100);
            pictureBox6.Visible = true;
            pictureBox3.Visible = false;
            pictureBox1.Visible = false;
            MessageBox.Show("No connect!!!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            buttonAdapter.Enabled = true;
            buttonReset.Enabled = true;
            buttonConnect.Enabled = true;


        }
        void pin3Adpater()
        {
            pictureBox3.Visible = false;
            pictureBox4.Visible = true;
            //pictureBox3.Location = new Point(pictureBox3.Location.X, pictureBox3.Location.Y - Cons.hight - 10);
            //Thread.Sleep(100);
            pictureBox4.Location = new Point(pictureBox4.Location.X, pictureBox4.Location.Y - Cons.hight - 10);
            Thread.Sleep(100);

            while (pictureBox4.Location.X < 400)
            {

                pictureBox4.Location = new Point(pictureBox4.Location.X + 10, pictureBox4.Location.Y);
                Thread.Sleep(100);
               

            }

            pictureBox4.Location = new Point(400, 100);
            Thread.Sleep(100);
            pictureBox7.Visible = true;
            pictureBox4.Visible = false;
            pictureBox1.Visible = false;
            MessageBox.Show("Connect!!!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            buttonConnect.Enabled = true;
            buttonReset.Enabled = true;
            buttonAdapter.Enabled = true;

        }
        void pin2Adpater()
        {

            
            MessageBox.Show("Can't connect Adapter!!!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            buttonConnect.Enabled = true;
            buttonReset.Enabled = true;
            buttonAdapter.Enabled = true;

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {

            resset();

        }
        void resset()
        {
            pictureBox2.Location = new Point(Xpin2_Old, Ypin2_Old);
            pictureBox3.Location = new Point(Xpin3_Old, Ypin3_Old);
            pictureBox4.Location = new Point(Xpin3Adapter_Old, Ypin3Adapter_Old);
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox2.Visible = true;
            pictureBox1.Visible = true;
            pictureBox6.Visible = false;
            pictureBox3.Visible = true;
            pictureBox7.Visible = false;
            pictureBox4.Visible = false;

        }

        private void buttonAdapter_Click(object sender, EventArgs e)
        {
            buttonConnect.Enabled = false;
            buttonReset.Enabled = false;
            buttonAdapter.Enabled = false;
            frmAdapter frm = new frmAdapter();
                frm.ShowDialog();
            if (radio2pin.Checked == true)
            {
                
                Thread a = new Thread(() =>
                {
                    
                    connectAdapter(2);
                   
                });
                a.Start();
            }
            else
            {
                pictureBox4.Visible = true;
                Thread a = new Thread(() =>
                {
                    connectAdapter(3);
                });
               
                a.Start();
               
            }
            pictureBox7.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
