using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eco_Farm_ORM
{
    public partial class Form2 : Form
    {
        EmployeeContext ec = new EmployeeContext();
        public Form2()
        {
            InitializeComponent();
            CompaniesCB.DataSource = ec.Langs.Select(x => x.Company).Distinct().ToList();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ec.Employ.Where(x => x.Name.Contains(textBox2.Text)).ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var count = (from m in ec.Employ where m.Age == 28 select m.Age).Count();
            textBox3.Text = count.ToString();
            yongTB.Text = ec.Employ.Min(m => m.Name+", "+m.Age);
            oldTB.Text = ec.Employ.Max(m => m.Name+", " + m.Age);
            avTB.Text = Convert.ToInt32(ec.Employ.Average(m => m.Age)).ToString();
        }

        private void select_by_companies_Click(object sender, EventArgs e)
        {
            //var emps = ec.Employ.ToList();
            //var langs = ec.Langs.ToList();
            var res = from em in ec.Employ
                       join lan in ec.Langs on em.Company equals lan.Company
                       where lan.Company == CompaniesCB.SelectedItem.ToString()
                       select new
                       {
                           em.Name,
                           em.Company,
                           lan.Language
                       };
            dataGridView1.DataSource = res.ToList();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Languages lang = new Languages(textBox1.Text, textBox4.Text);
            ec.Langs.Add(lang);
            ec.SaveChanges();
        }
    }
}
