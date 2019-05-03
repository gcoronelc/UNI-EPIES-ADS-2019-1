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


namespace InformeBebidas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-UMKM1D37; Initial Catalog=DISEÑO_PREFERENCIA;Integrated Security=True");

        public void logear(string usuario, string contrasena)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Usuario,Clave from tb_encuestador WHERE  Usuario=@usuario and Clave=@pas", con);
                cmd.Parameters.AddWithValue("usuario", usuario);
                cmd.Parameters.AddWithValue("pas", contrasena);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    if (dt.Rows[0][1].ToString() == "Admin")
                    {
                        
                    }
                    else if (dt.Rows[0][1].ToString() == "Incorrecto")
                    { }
                }
                else
                {
                    MessageBox.Show("Usuario y / o contraseña Incorrecto");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                con.Close();
            }



        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            logear(this.textBox1.Text, this.textBox2.Text);
            Form btnInfomre = new Informe();
            btnInfomre.Show();

        }
    }
}
