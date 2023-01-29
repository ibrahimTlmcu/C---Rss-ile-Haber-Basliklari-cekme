using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace RSSileVeriCekme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Getir_Click(object sender, EventArgs e)
        {
            XmlTextReader xmloklu = new XmlTextReader("https://www.cumhuriyet.com.tr/rss/son_dakika.xml");
            while (xmloklu.Read())
            {
                if(xmloklu.Name == "title")
                {
                    listBox1.Items.Add(xmloklu.ReadString());   
 
                }
                
            }
        }

        private void Temizle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            
        }
    }
}
