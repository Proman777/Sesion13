using MetodoBurbuja.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetodoBurbuja
{
    public partial class Form1 : Form
    {
        int[] numbers = new int[10];
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void number_Click(object sender, EventArgs e)
        {
            int number = int.Parse(btnadd.Text);
            numbers[i++] = number;
            Shownumbers();
            Clear();
        }
        public void Shownumbers()
        {
            if (lbnumbers.Items.Count > 0)
            {
                lbnumbers.Items.Clear();


            } foreach (int number in numbers)
            {
                lbnumbers.Items.Add(number);
            }
        } private void Clear()
        {
            tbnumber.Clear();
            tbnumber.Focus();
        }

        private void btnordenar_Click(object sender, EventArgs e)
        {
            Burbuja burbuja =new Burbuja();
            burbuja.SortBubble(numbers);
            Shownumbers();
        }
    }
}
