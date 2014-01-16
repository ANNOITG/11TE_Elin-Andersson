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

namespace introduktionnormal
{
    public partial class Form1 : Form
    {
        List<Person> personer = new List<Person>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            




            TextReader tr = new StreamReader("object.txt");

            string rad;
            do
            {
                rad = tr.ReadLine();
                if (rad != null)
                {
                    string[] strings = rad.Split(';');
                    Person p = new Person();
                    p.name = strings[0];
                    p.adress = strings[1];
                    p.pnr = strings[2];
                    p.telenr = strings[3];

                    personer.Add(p);
                }
                //richTextBox1.Text += rad + "\n";
            } while (rad != null);
            tr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            foreach (Person p in personer)
            {
                richTextBox1.Text += p.name + "\n";
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Person p = new Person();
            p.name = textBox4.Text;
            p.adress = textBox3.Text;
            p.pnr = textBox1.Text;
            p.telenr = textBox2.Text;

            personer.Add(p);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            TextWriter tw = new StreamWriter("object.txt");

            foreach (var person in personer)
            {
                tw.WriteLine(person.pnr +";" + person.name + ";" + person.adress + ";" + person.telenr);
            }
            tw.Close();
        }
    }
}
