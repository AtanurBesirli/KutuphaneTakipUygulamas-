﻿using KutuphaneTakipUygulaması.Model;
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

namespace KutuphaneTakipUygulaması
{
    public partial class KurulumFormu : Form
    {
        public KurulumFormu()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnKaydol_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAd.Text) ||
                string.IsNullOrEmpty(txtSoyad.Text) ||
                string.IsNullOrEmpty(txtKullaniciAdi.Text) ||
                string.IsNullOrEmpty(txtSifre.Text) ||
                string.IsNullOrEmpty(txtSifreTekrar.Text))
            {
                MessageBox.Show("Tüm Alanları Doldurunuz!");
                return;
            }

            if (txtSifre.Text != txtSifreTekrar.Text)
            {
                MessageBox.Show("Şifre Tekrarları Uyuşmuyor!");
                return;
            }


            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@adi", SqlDbType.VarChar) { Value = txtAd.Text });
            parameters.Add(new SqlParameter("@soyadi", SqlDbType.VarChar) { Value = txtSoyad.Text });
            parameters.Add(new SqlParameter("@kullaniciAdi", SqlDbType.VarChar) { Value = txtKullaniciAdi.Text });
            parameters.Add(new SqlParameter("@sifre", SqlDbType.VarChar) { Value = txtSifre.Text });
            IDataBase.executeNonQuery("insert into kullanicilar (adi, soyadi, kullaniciAdi, sifre) values (@adi, @soyadi, @kullaniciAdi, @sifre)", parameters);

            LoginForm formLogin = new LoginForm();
            formLogin.Show();

            this.Hide();
        }
    }
}
