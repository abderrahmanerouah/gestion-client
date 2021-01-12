using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection cnx = new SqlConnection(@"data source=ABMOULA;initial catalog=client;integrated security=true");
        DataSet DS = new DataSet();
        SqlDataAdapter DA;

        private void Form1_Load(object sender, EventArgs e)
        {
            DA = new SqlDataAdapter("Select * from clientinfo", cnx);
            DA.Fill(DS,"clinf");
            dataGridView1.DataSource = DS.Tables["clinf"];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
        private void label1_Click_1(object sender, EventArgs e)
        {
            

        }

        private void buttonajt_Click(object sender, EventArgs e)
        {
            DataRow ligne = DS.Tables["clinf"].NewRow();
            ligne[0] = int.Parse(textBox1.Text);
            ligne[1] = textBox2.Text;
            ligne[2] = textBox3.Text;
            ligne[3] = textBox4.Text;
            ligne[4] = textBox5.Text;
            DS.Tables["clinf"].Rows.Add(ligne);
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                    item.Text = String.Empty;
            }

        }

        private void buttonmdf_Click(object sender, EventArgs e)
        {
            int p = -1;
            for (int i = 0; i < DS.Tables["clinf"].Rows.Count; i++)
            {
                if (textBox1.Text == DS.Tables["clinf"].Rows[i][0].ToString())
                {
                    p = i;
                }
                if (p == -1)
                {
                    MessageBox.Show("Employé introuvable");
                }
                else
                {
                    DS.Tables["clinf"].Rows[p][0] = int.Parse(textBox1.Text);
                    DS.Tables["clinf"].Rows[p][1] = textBox2.Text;
                    DS.Tables["clinf"].Rows[p][2] = textBox3.Text;
                    DS.Tables["clinf"].Rows[p][3] = textBox4.Text;
                    DS.Tables["clinf"].Rows[p][4] = textBox5.Text;
                    MessageBox.Show("Employé modifié");
                    
                }


            }
        }

        

        private void buttonsupp_Click(object sender, EventArgs e)
        {
     
        int p = -1;
            for(int i = 0; i < DS.Tables["clinf"].Rows.Count; i++)
            {
                if (textBox1.Text == DS.Tables["clinf"].Rows[i][0].ToString())
                {
                    p = i;
                }
                if (p == -1)
                {
                    MessageBox.Show("Employé introuvable");
                }
                else { DS.Tables["clinf"].Rows.RemoveAt(p);
                    MessageBox.Show("Employé supprimé");
                    foreach (Control item in Controls)
                    {
                        if (item is TextBox)
                            item.Text = String.Empty;
                    }
                }

             
            }
        }

        private void buttonenrg_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder cb = new SqlCommandBuilder(DA);
            DA.Update(DS, "clinf");
            MessageBox.Show("Les données ont été bien Enregistrées");
        }

        private void buttonrech_Click(object sender, EventArgs e)
        {
           
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
