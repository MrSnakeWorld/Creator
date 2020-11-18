using System;
using System.Windows;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Creator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            
            string filename = saveFileDialog1.FileName;
            
            Directory.CreateDirectory(filename);
            Directory.CreateDirectory(filename + "\\css");
            Directory.CreateDirectory(filename + "\\js");
            Directory.CreateDirectory(filename + "\\img");

            File.WriteAllText(filename + "\\index.html", "<!DOCTYPE html>\n" +
                "<html lang=\"ru\">\n" +
                "<head>\n\t" +
                "<meta charset=\"UTF-8\">\n\t" +
                "<meta name=\"viewport\" content=\"width=device-width, initial-scale = 1.0\">\n\t" +
                "<title> </title>\n\t" +
                "<link type=\"text/css\" rel=\"stylesheet\" href=\"css/main.css\">\n" +
                "</head>\n" +
                "<body>\n\t" + 
                textBox1.Text +
                "\n\t<script src=\"js/main.js\"></script>\n" +
                "</body>\n" +
                "</html>" );
            File.WriteAllText(filename + "\\css" + "\\main.css", "" + textBox2.Text);
            File.WriteAllText(filename + "\\js" + "\\main.js", "\"use strict;\"\n" + textBox3.Text);

            MessageBox.Show("Все сохранено");
        }
    }
}
