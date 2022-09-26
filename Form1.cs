using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ginegator_slov
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        string[] masiv = { "Tyrant Guard - это непревзойденные телохранители, вся цель их создания - защитить",
            "своего Улья Tyrant. Они принимают форму колоссальных живых щитов, практически", 
            "непроницаемых даже для самого тяжелого оружия.",
            "Страж Тирана может быть вооружен парой сокрушительных когтей, костяным", 
            "мечом и хлыстом-плетью или парой колючих когтей. Существует 3 комплекта",
            "каждого варианта оружия, что позволяет всему подразделению быть вооруженным",
            "одинаково. Кроме того, каждый страж Тирана может быть смоделирован с ", 
            "поврежденной в бою наплечной броней.." };
        StringBuilder sb = new StringBuilder(); 

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < numericUpDown1.Value; i++);
            {
                int x=rnd.Next(masiv.Length);
                sb.Append(masiv[x]+" ");

            }
            listBox1.Items.Add(sb);
            sb.Clear();
        }
    }
}
