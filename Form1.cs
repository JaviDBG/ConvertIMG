using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ConvertIMG
{
    public partial class Form1 : Form
    {
        string nameFile = "";
        string formato = "";
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png, *.gif, *.bmp) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png; *.gif; *.bmp" ;           
            openFileDialog1.Multiselect = false;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Text = "<--Formatos-->";
            comboBox1.Items.Add("jpg");
            comboBox1.Items.Add("png");
            comboBox1.Items.Add("gif");
            comboBox1.Items.Add("bmp");
            //comboBox1.Enabled = false;
            
            btnConvertir.Enabled = false;
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            
           
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                //nameFile = Path.GetFileNameWithoutExtension(openFileDialog1.FileName);
                    nameFile = openFileDialog1.SafeFileName;
                    label1.Text ="Archivo '"+nameFile+"' seleccionado ";
                    comboBox1.Enabled = true;
                }                
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btnConvertir.Enabled==false)
            {
                btnConvertir.Enabled = true;
            }
            formato = comboBox1.Items[comboBox1.SelectedIndex].ToString();
        }
    }
}
