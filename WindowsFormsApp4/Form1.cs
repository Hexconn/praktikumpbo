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
using System.Globalization;
using System.Text.RegularExpressions;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;

namespace WindowsFormsApp4
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public partial class Form1 : Form
    {
        private const string V = "(),nq}";
        SqlConnection koneksi = new SqlConnection(@"Data Source=LAPTOP-3SU9BJMN;Initial Catalog=pbo;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        public Form1()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = koneksi.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into [leptop] (identitas,nama_leptop,harga,stok,transaksi,leptop_yang_dibeli,stok_leptop_yang_dibeli) values ('"+textBox9+ "','"+textBox10+ "','"+textBox11+ "','"+textBox12+ "','"+textBox13+ "','"+textBox14+ "','"+textBox15+"')";
            cmd.Parameters.Add(new SqlParameter());
            cmd.ExecuteNonQuery();
            koneksi.Close();
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            MessageBox.Show("Data insert Successfully");
        }
        public void display_data()
        {
            koneksi.Open();
            SqlCommand cmd = koneksi.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.BeginExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd);
            dataadp.Fill(dta);
            dataGridView1.DataSource = dta;
            koneksi.Close();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            display_data();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            SqlCommand cmd = koneksi.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from [leptop] where identitas = '"+textBox1.Text"'";
            cmd.EndExecuteNonQuery();
            koneksi.Close();
            textBox1.Text = "";
            MessageBox.Show("data delete sukses");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = koneksi.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update [leptop] set identitas='"+this.textBox1+ "','"+this.textBox2+"','"+this.textBox3+"','"+this.textBox4+"','"+this.textBox5+"','"+this.textBox6+"','"+this.textBox7+"'"
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            MessageBox.Show("Data insert Successfully");
        }



        private void button9_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            SqlCommand cmd = koneksi.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from [leptop] where identitas = '" + textBox1.Text + "'";
            cmd.EndExecuteNonQuery();
            koneksi.Close();
            textBox1.Text = "";
            MessageBox.Show("data delete sukses");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = koneksi.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update [leptop] set identitas='" + this.textBox9 + "', nama_jurusan='" + this.textBox10 + "', harga='" + this.textBox11 + "', stok='" + this.textBox12 + "', transaksi='" + this.textBox13 + "', leptop_yang_dibeli= '" + this.textBox14 + "', stok_leptop_yang_dibeli= '" + this.textBox15 + "'";
        }

        public void read_data()
        {
            koneksi.Open();
            SqlCommand cmd = koneksi.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [leptop]";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd);
            dataadp.Fill(dta);
            dataGridView1.dataSource = dta;
            koneksi.Close()
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            MessageBox.Show("Data insert Successfully");
}
        private void button7_Click(object sender, EventArgs e)
        {
            read_data();
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}