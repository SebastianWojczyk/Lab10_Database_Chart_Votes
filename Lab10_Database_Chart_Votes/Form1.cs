using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lab10_Database_Chart_Votes
{
    public partial class Form1 : Form
    {
        private decimal grade = 0;
        private DBDataContext dc = new DBDataContext();
        public Form1()
        {
            InitializeComponent();

            radioButton_3_5.Text = (3.5M).ToString();
            radioButton_4_5.Text = (4.5M).ToString();

            labelInfo.ForeColor = Color.Red;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            bool formIsValid = true;
            labelInfo.Text = "";
            
            //email validation
            labelEmail.ForeColor = Color.Black;
            try
            {
                MailAddress mail = new MailAddress(textBoxEmail.Text);
                if (dc.Votes.Count(x => x.Email == textBoxEmail.Text) > 0)
                {
                    formIsValid = false;
                    labelInfo.Text += "Email is in database\n";
                    labelEmail.ForeColor = Color.Red;
                }
            }
            catch
            {
                formIsValid = false;
                labelInfo.Text += "Invalid email format\n";
                labelEmail.ForeColor = Color.Red;
            }

            if (grade == 0)
            {
                formIsValid = false;
                labelInfo.Text += "Choose grade\n";
                labelGrade.ForeColor = Color.Red;
            }
            else
            {
                labelGrade.ForeColor = Color.Black;
            }

            if (formIsValid)
            {
                labelInfo.Text = "";

                Vote v = new Vote()
                {
                    Email = textBoxEmail.Text,
                    Grade = grade
                };

                dc.Votes.InsertOnSubmit(v);
                dc.SubmitChanges();

                //Remove all conrols from form design
                this.Controls.Clear();

                //Add new chart
                Chart chart = new Chart();
                Series s = new Series();
                chart.ChartAreas.Add(new ChartArea());
                chart.Series.Add(s);

                s.Points.AddXY(2, dc.Votes.Count(x => x.Grade == 2));
                s.Points.AddXY(3, dc.Votes.Count(x => x.Grade == 3));
                s.Points.AddXY(3.5, dc.Votes.Count(x => x.Grade == 3.5M));
                s.Points.AddXY(4, dc.Votes.Count(x => x.Grade == 4));
                s.Points.AddXY(4.5, dc.Votes.Count(x => x.Grade == 4.5M));
                s.Points.AddXY(5, dc.Votes.Count(x => x.Grade == 5));

                this.Controls.Add(chart);
            }
        }

        private void RadioButton_Grade_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton)
            {
                RadioButton r = sender as RadioButton;
                if (r.Checked)
                {
                    grade = Decimal.Parse(r.Text);
                }
            }
        }
    }
}
