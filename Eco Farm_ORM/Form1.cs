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

namespace Eco_Farm_ORM
{
    public partial class Form1 : Form
    {
        EcoFarmEntities ef = new EcoFarmEntities();
        public Form1()
        {
            InitializeComponent();
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
            SqlParameter parameterSql = new SqlParameter();
            parameterSql.ParameterName = "@Parameter";
            bool ParamType = int.TryParse(paramming.Text, out param);
            parameterSql.Value = paramming.Text;
            dataGridView1.DataSource = ef.Database.SqlQuery<Employees>("SELECT * FROM Employees where Position_Code=@Parameter", parameterSql).ToList();
        }

        private void ObjQuery_Click(object sender, EventArgs e)
        {
            //string con = ef.Database.Connection.ConnectionString;
            ObjectContext context = (new EcoFarmEntities() as IObjectContextAdapter).ObjectContext;
            context.DefaultContainerName = "EcoFarmEntities";
            ObjectParameter param = new ObjectParameter("Parameter", comboBox1.SelectedItem.ToString());
            string command = "SELECT VALUE p FROM Position as p WHERE p.Position1=@Parameter";
            ObjectQuery<Position> objQuery = context.CreateQuery<Position>(command, param);
            var result = objQuery.ToList();
            dataGridView1.DataSource = result;
        }
    }
}
