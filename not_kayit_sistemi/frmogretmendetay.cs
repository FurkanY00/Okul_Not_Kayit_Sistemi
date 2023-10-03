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

namespace not_kayit_sistemi
{
    public partial class frmogretmendetay : Form
    {
        public frmogretmendetay()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-KPC6PV7\SQLEXPRESS;Initial Catalog=dbnotkayıt;Integrated Security=True");
        private void frmogretmendetay_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbnotkayıtDataSet.tblders' table. You can move, or remove it, as needed.
            this.tbldersTableAdapter.Fill(this.dbnotkayıtDataSet.tblders);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into tblders (ogrnumara,ograd,ogrsoyad)values (@p1,@p2,@p3)", baglanti);
            komut.Parameters.AddWithValue("@p1", msknumara.Text.ToString());
            komut.Parameters.AddWithValue("@p2", txtad.Text);
            komut.Parameters.AddWithValue("@p3", txtsoyad.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("öğrenci Sisteme eklendi");
            this.tbldersTableAdapter.Fill(this.dbnotkayıtDataSet.tblders);
            baglanti.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string durum;

            double ortalama, s1, s2, s3;
            s1 = Convert.ToDouble(txtsınav1.Text);
            s2 = Convert.ToDouble(txtsınav2.Text);
            s3 = Convert.ToDouble(txtsınav3.Text);
            ortalama=(s1+s2 + s3)/3;
            lblortalama.Text=ortalama.ToString();

            if (ortalama >=50)
            {
                durum = "true";
            }
            else
            {
                durum="false";
            }

            baglanti.Open();
            SqlCommand komut = new SqlCommand("update tblders set ogrs1=@p1,ogrs2=@p2,ogrs3=@p3,ortalama=@p4,durum=@p5 where ogrnumara=@p6",baglanti);
            komut.Parameters.AddWithValue("@p1", txtsınav1.Text);
            komut.Parameters.AddWithValue("@p2", txtsınav2.Text);
            komut.Parameters.AddWithValue("@p3", txtsınav3.Text);
            komut.Parameters.AddWithValue("@p4", decimal.Parse(lblortalama.Text));
            komut.Parameters.AddWithValue("@p5", durum);
            komut.Parameters.AddWithValue("@p6", msknumara.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Öğrençi Notları Güncellendi");

            this.tbldersTableAdapter.Fill(this.dbnotkayıtDataSet.tblders);


            baglanti.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
           msknumara.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtsınav1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtsınav2.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtsınav3.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
