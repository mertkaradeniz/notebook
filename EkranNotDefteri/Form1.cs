using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Globalization;
using System.Threading;
using System.Runtime.InteropServices;
using formAnimation;
using Microsoft.Win32;
namespace EkranNotDefteri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=db.accdb");
        DateTime SeciliTarih;
        bool Status = false;
      
        static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        static readonly IntPtr HWND_NOTOPMOST = new IntPtr(-2);
        static readonly IntPtr HWND_TOP = new IntPtr(0);
        static readonly IntPtr HWND_BOTTOM = new IntPtr(1);
        const UInt32 SWP_NOSIZE = 0x0001;
        const UInt32 SWP_NOMOVE = 0x0002;
        const UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        private void Form1_Load(object sender, EventArgs e)
        {
            RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            rkApp.SetValue(Application.ProductName, Application.ExecutablePath);

            SetWindowPos(this.Handle, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);

            label6.Text = monthCalendar1.SelectionRange.Start.ToShortDateString().ToString();
            label2.Text = CultureInfo.GetCultureInfo("tr-TR").DateTimeFormat.DayNames[(int)DateTime.Now.DayOfWeek];
            label3.Text = DateTime.Now. ToShortDateString().ToString();
          
            conn.Open();
            SeciliTarih = monthCalendar1.SelectionRange.Start;
            richTextBox1.Text = Yukle(monthCalendar1.SelectionRange.Start.ToShortDateString());
            if (richTextBox1.Text.Trim() == "")
                Status = true;
        }

        void Kayit(string Not,DateTime Tarih)
        {
            OleDbCommand com = new OleDbCommand("insert into tblnot(Notlar,Tarih)Values(@Notlar,@Tarih)", conn);
            com.Parameters.Add("@Notlar", OleDbType.VarChar).Value = Not;
            com.Parameters.Add("@Tarih", OleDbType.VarChar).Value = Tarih.ToShortDateString().ToString(); 
            com.ExecuteNonQuery();
           
        }

        string Yukle(string Tarih)
        {         
            OleDbCommand com = new OleDbCommand("select * from tblnot where Tarih='"+Tarih+"'", conn);
            com.ExecuteNonQuery();
            OleDbDataReader oku = com.ExecuteReader();
            string Veri = "";
            while (oku.Read())
            {
                Veri = oku[1].ToString();
            }           
           
            return Veri;
        }

        void Guncelle(string Not,string Tarih)
        {
            OleDbCommand com = new OleDbCommand("update tblnot set Notlar=@Notlar where Tarih='"+Tarih+"'", conn);
            com.Parameters.Add("@Notlar", OleDbType.VarChar).Value = Not;       
            com.ExecuteNonQuery();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            
            if (Status)
            {
                if (richTextBox1.Text.Trim() != "")
                    Kayit(richTextBox1.Text, SeciliTarih);
                Status = false;
            }
            else
               Guncelle(richTextBox1.Text, SeciliTarih.ToShortDateString().ToString());
           
            label6.Text= monthCalendar1.SelectionRange.Start.ToShortDateString();
            SeciliTarih=monthCalendar1.SelectionRange.Start;


            richTextBox1.Text = Yukle(monthCalendar1.SelectionRange.Start.ToShortDateString());
            if (richTextBox1.Text.Trim() == "")
                Status = true;

        }
       static int indis = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            if (Status)
            {
                if (richTextBox1.Text.Trim() != "")
                    Kayit(richTextBox1.Text, SeciliTarih);
                Status = false;
            }
            else
                Guncelle(richTextBox1.Text, SeciliTarih.ToShortDateString().ToString());
            
            indis++;
            SeciliTarih = monthCalendar1.SelectionRange.Start.AddDays(indis);
            label6.Text = SeciliTarih.ToShortDateString().ToString();
            richTextBox1.Text = Yukle(SeciliTarih.ToShortDateString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Status)
            {
                if (richTextBox1.Text.Trim() != "")
                    Kayit(richTextBox1.Text, SeciliTarih);
                Status = false;
            }
            else
                Guncelle(richTextBox1.Text, SeciliTarih.ToShortDateString().ToString());
            
            indis--;
            SeciliTarih = monthCalendar1.SelectionRange.Start.AddDays(indis);
            label6.Text = SeciliTarih.ToShortDateString().ToString();
            richTextBox1.Text = Yukle(SeciliTarih.ToShortDateString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SeciliTarih = DateTime.Now;
            label6.Text = SeciliTarih.ToShortDateString().ToString();
            richTextBox1.Text = Yukle(SeciliTarih.ToShortDateString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SeciliTarih = DateTime.Now.AddDays(1);
            label6.Text = SeciliTarih.ToShortDateString().ToString();
            richTextBox1.Text = Yukle(SeciliTarih.ToShortDateString());
        }

        private void PlaceLowerRight(int value)
        {
            try
            {
                //Determine "rightmost" screen
                Screen rightmost = Screen.AllScreens[0];
                foreach (Screen screen in Screen.AllScreens)
                {
                    if (screen.WorkingArea.Right > rightmost.WorkingArea.Right)
                        rightmost = screen;
                }

                this.Left = rightmost.WorkingArea.Right - this.Width + 10 + value;
                this.Top = 10;
            }
            catch { }

           
        }
        int kayma = 249;
        bool ayirma = false;
        protected override void OnLoad(EventArgs e)
        {
            PlaceLowerRight(kayma);
            base.OnLoad(e);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            PlaceLowerRight(0);
            ayirma = false;
        }

        void slep()
        {
            Thread.Sleep(700); 
            if(ayirma)
            PlaceLowerRight(kayma);       
        }
        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            Thread th = new Thread(new ThreadStart(slep));
            th.Start();
            ayirma = true;
        }

        void _ayirma()
        {
            ayirma = false;
        }

        private void monthCalendar1_MouseMove(object sender, MouseEventArgs e)
        {
            _ayirma();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void richTextBox1_MouseLeave(object sender, EventArgs e)
        {
            ayirma = true;
            Thread th = new Thread(new ThreadStart(slep));
            th.Start();
        }
    }
}
