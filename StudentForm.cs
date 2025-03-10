using Sabado_JohnVir_Act_GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sabado_JohnVir_Act_GUI
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
            // Mock Student Data
            StudentNameLabel.Text = "Sabado, John-Vir j.";
            StudentAgeLabel.Text = "21";
            StudentAddressLabel.Text = "Wawa Bayambang Pangasinan";
            StudentContactLabel.Text = "09668091675";
            StudentEmailLabel.Text = "j.s80@gmail.com";
            StudentCourseYearLabel.Text = "BSIT Third";
            ParentNameLabel.Text = "Virgilio Sabado";
            ParentContactLabel.Text = "09668091675";
            HobbiesLabel.Text = "Eating/Basketball";
            NicknameLabel.Text = "Jamber";

        }

        private void AddImageBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add Image functionality is not implemented.", "Feature Not Available", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ChangeImageBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Change Image functionality is not implemented.", "Feature Not Available", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void EditUpdateBtn_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm(this);
            this.Hide();
            editForm.Show();
        }

    }
}