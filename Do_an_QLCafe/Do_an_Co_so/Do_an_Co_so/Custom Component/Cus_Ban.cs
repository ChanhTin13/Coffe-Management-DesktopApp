using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace Do_an_Co_so.Custom_Component
{
    public partial class Cus_Ban : UserControl
    {
        DispatcherTimer dt = new DispatcherTimer();
        Stopwatch stopWatch = new Stopwatch();
        string currentTime = string.Empty;
        public Cus_Ban()
        {
            InitializeComponent();
            //timer1.Tick += new EventHandler(timer1_Tick);
            dt.Interval = new TimeSpan(0, 0, 0, 0, 1); 
        }

        private bool is_Ban_trong; 
        public bool Is_Ban_trong
        {
            get => is_Ban_trong;
            set
            {
                is_Ban_trong = value;
                if (is_Ban_trong == false)
                {
                    timer1.Enabled = false;
                    label_trang_thai.Text = "Trống";
                    stopWatch.Stop();

                    custom_btn1.BackColor = Color.White;
                    custom_btn1.BorderColor = SystemColors.Highlight;

                    label_ten_ban.BackColor = Color.White;
                    label_ten_ban.ForeColor = Color.FromArgb(66, 69, 87);

                    label_trang_thai.BackColor = Color.White;
                    label_trang_thai.ForeColor = Color.Black;

                }
                else
                {
                    timer1.Enabled = true;
                    timer1.Tick += timer1_Tick;
                    stopWatch.Start();
                    dt.Start();

                    custom_btn1.BackColor = System.Drawing.ColorTranslator.FromHtml("#06b3f3");
                    custom_btn1.BorderColor = Color.White;


                    label_ten_ban.BackColor = System.Drawing.ColorTranslator.FromHtml("#06b3f3");
                    label_ten_ban.ForeColor = Color.White;

                    label_trang_thai.BackColor = System.Drawing.ColorTranslator.FromHtml("#06b3f3");

                }
            }
        }

        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        private string ten_ban;
        public string Ten_ban
        {
            get { return ten_ban; }
            set
            { 
                ten_ban = value; 
                label_ten_ban.Text = value;
            }
        }
        private TimeSpan time = TimeSpan.FromSeconds(0);
        public TimeSpan Time
        {
            get => time;
            set
            {   time = value;
                label_trang_thai.Text = value.ToString();
            }
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            //x = DateTime.Now;
            //timer1.Interval = 1000;
            //TimeSpan span = DateTime.Now.Subtract(x);
            //label_trang_thai.Text = span.Hours.ToString() + " : " + span.Minutes.ToString() + " : " + span.Seconds.ToString();

            if (stopWatch.IsRunning)
            {
                if (time == TimeSpan.FromSeconds(0))
                {
                    TimeSpan ts = stopWatch.Elapsed;
                    //time = ts;
                    currentTime = String.Format("{0:00}:{1:00}:{2:00}", ts.Hours, ts.Minutes, ts.Seconds);
                    label_trang_thai.Text = currentTime;
                    label_trang_thai.ForeColor = Color.White;
                }
                else
                {
                    var c = time;
                    var cc = stopWatch.Elapsed;
                    time.Add(cc);

                    currentTime = String.Format("{0:00}:{1:00}:{2:00}", time.Hours, time.Minutes, time.Seconds);
                    label_trang_thai.Text = currentTime;
                    label_trang_thai.ForeColor = Color.White;
                }

            }
        }
       
        public event EventHandler OnSelect = null;
       
        private void custom_btn1_Click(object sender, EventArgs e)
        {
            OnSelect?.Invoke(this, e);
        }

    }
}
