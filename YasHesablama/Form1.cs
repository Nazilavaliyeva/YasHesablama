using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YasHesablama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Bu metod istifadəçinin daxil etdiyi ili alır, indiki ili tapır və yaşını hesablayır.    
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int tarix = Convert.ToInt32(textBox1.Text);
                int indiki = DateTime.Now.Year;
                int age = indiki - tarix;

                label1.Text = age.ToString();
            }
            catch (Exception ex)
            { 
                MessageBox.Show("Xahiş olunur ili düzgün daxil edin", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);  

            }
            
        }
    }
}
