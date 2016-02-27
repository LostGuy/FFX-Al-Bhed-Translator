using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FFX_Al_Bhed_Translator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Change the title
            this.Text = "Al Bhed Translator";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void englishToAlBhedButton_Click(object sender, EventArgs e)
        {
            //Create Translator object
            Translator translator = new Translator();

            //Show the translation in a message box
            MessageBox.Show(translator.englishToAlBhed(inputBox.Text));
        }

        private void alBhedToEnglishButton_Click(object sender, EventArgs e)
        {
            //Create Translator object
            Translator translator = new Translator();

            //Show the translation in a message box
            MessageBox.Show(translator.alBhedToEnglish(inputBox.Text));
        }
    }
}
