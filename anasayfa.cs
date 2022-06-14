using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PB_Cafe
{
    public partial class Home : Form
    {
        private Button currentButton;
        private Random random = new Random();
        private int tempIndex;
        private Form activeForm;

        public Home()
        {
            InitializeComponent();
            
        }

        private Color SelectThemeColor()
        {
            int index = random.Next(MultiColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(MultiColor.ColorList.Count);
            }
            tempIndex = index;
            string color = MultiColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Trajan Pro", 10.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTop.BackColor = color;
                    panelLogo.BackColor = MultiColor.ChangeColorBrightness(color, -0.3);
                    MultiColor.PrimaryColor = color;
                    MultiColor.SecondaryColor = MultiColor.ChangeColorBrightness(color, -0.3);
                    btn_FormClose.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(0, 206, 209);
                    previousBtn.ForeColor = Color.Black;
                    previousBtn.Font = new System.Drawing.Font("Trajan Pro", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelMenu.Text = childForm.Text;
        }

        private void btn_Personel_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Personel(), sender);
        }

        private void btn_KasaIslemleri_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Kasa(), sender);
        }

        private void btn_Kampanyalar_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Kampanya(), sender);
        }

        private void btn_Mutfak_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Mutfak(), sender);
        }

        private void btn_Raporlar_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Rapor(), sender);
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Menu(), sender);
        }

        private void btn_Masalar_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Masa(), sender);
        }

        private void Reset()
        {
            DisableButton();
            labelMenu.Text = "ANA SAYFA";
            panelTop.BackColor = Color.FromArgb(135, 206, 235);
            panelLogo.BackColor = Color.FromArgb(173, 216, 230);
            currentButton = null;
            btn_FormClose.Visible = false;
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void btn_FormClose_Click(object sender, EventArgs e)
        {
            
             if (activeForm != null)
                 activeForm.Close();
             Reset();
            
        }
    }
}
