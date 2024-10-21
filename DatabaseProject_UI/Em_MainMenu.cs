using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseProject_UI
{
    public partial class Em_MainMenu : Form
    {
        //Fields
        private Button currentButon;
        private Random random;
        private int tempindex;
        private Form activeForm;
        public Em_MainMenu()
        {
            InitializeComponent();
            random = new Random();
        }

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemesColor.ColorList.Count);  
            while (tempindex == index) { 
               index = random.Next(ThemesColor.ColorList.Count);
            }
            tempindex = index;
            string color = ThemesColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if(btnSender != null)
            {
                if (currentButon != (Button)btnSender) 
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButon = (Button)btnSender;
                    currentButon.BackColor = color;
                    currentButon.ForeColor = Color.White;
                    currentButon.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    LogoPBox.BackColor = ThemesColor.ChangeColorBrightness(color, -0.3);
                }
            }
        }

        private void DisableButton ()
        {
            foreach(Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button)) 
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childform, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(childform);
            this.panelDesktopPanel.Tag = childform;
            childform.BringToFront();
            childform.Show();
            lblTitle.Text = childform.Text;
        }
        private void Appointment_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms11.FormAppointments(), sender);
        }

        private void Job_btn_Click(object sender, EventArgs e)
        {
            
            OpenChildForm(new Forms11.FormJobs(), sender);

        }

        private void Transaction_btn_Click(object sender, EventArgs e)
        {
        
            OpenChildForm(new Forms11.FormTransactions(), sender);


        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            Login childfrm = new Login();
            this.Hide();
            childfrm.ShowDialog();
            this.Close();
        }

        private void Em_MainMenu_Load(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToString();    
        }

        
    }
}
