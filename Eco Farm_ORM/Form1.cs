using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.EntityClient;
using System.Data.Common;

namespace Eco_Farm_ORM
{
    public partial class Form1 : Form
    {
        public EntityConnection Econ;
        public EntityCommand Ecmd;
        EcoFarmEntities ef = new EcoFarmEntities();
        public Form1()
        {
            InitializeComponent();
            //Form2 form2 = new Form2();
            //form2.Show();
        }

        private void select_pos_code_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource= (from m in ef.Employees
                       where (m.Position_Code > 2 && m.Passport_Number.ToString().StartsWith("0"))
                       orderby m.Full_Name
                       select new
                       {
                           m.Full_Name,
                           m.Employee_Number,
                           m.Passport_Number,
                           m.Passport_Series,
                           m.Birth_Date,
                           m.Position_Code
                       }).ToList();
        }

        private void EntSQL_Click(object sender, EventArgs e)
        {
            int param;
            bool ParamType = int.TryParse(paramming.Text, out param);
            Econ = new EntityConnection("Name=EcoFarmEntities");
            Econ.Open();
            Ecmd = Econ.CreateCommand();
            Ecmd.Parameters.AddWithValue("Parameter", param);
            Ecmd.CommandText = "SELECT VALUE e FROM EcoFarmEntities.Employees as e WHERE e.Position_Code=@Parameter";
            DbDataReader DbRead = Ecmd.ExecuteReader(CommandBehavior.SequentialAccess);
            dataGridView1.Columns.Add("column", "Employee Number");
            dataGridView1.Columns.Add("column", "Name");
            dataGridView1.Columns.Add("column", "Phone");
            dataGridView1.Columns.Add("column", "Adress");
            dataGridView1.Columns.Add("column", "Position Code");
            dataGridView1.Columns.Add("column", "Passport Number");
            dataGridView1.Columns.Add("column", "Passport Series");
            dataGridView1.Columns.Add("column", "Birth");
            while (DbRead.Read())
            {
                dataGridView1.Rows.Add(
                    DbRead["Employee_Number"].ToString(),
                    DbRead["Full_Name"].ToString(),
                    DbRead["Phone_Number"].ToString(),
                    DbRead["Adress"].ToString(),
                    DbRead["Position_Code"].ToString(),
                    DbRead["Passport_Number"].ToString(),
                    DbRead["Passport_Series"].ToString(),
                    DbRead["Birth_Date"].ToString()
                    );
            }
            DbRead.Close();
            Econ.Close();
        }

        private void ObjQuery_Click(object sender, EventArgs e)
        {
            //string con = ef.Database.Connection.ConnectionString;
            ObjectContext context = (new EcoFarmEntities() as IObjectContextAdapter).ObjectContext;
            //context.DefaultContainerName = "EcoFarmEntities";
            ObjectParameter param = new ObjectParameter("Parameter", comboBox1.SelectedItem.ToString());
            string command = "SELECT VALUE p FROM Position as p WHERE p.Position1=@Parameter";
            ObjectQuery<Position> objQuery = context.CreateQuery<Position>(command, param);
            var result = objQuery.ToList();
            dataGridView1.DataSource = result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
