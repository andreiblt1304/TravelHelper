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

namespace ProiectPAW_BaltariuAndrei
{
    public partial class clientMenu : Form
    {
        public static void arataTot(string arata)
        {
            if (arata != null)
            {
                arata = File.ReadAllText("fisier.txt");
                Console.WriteLine(arata);
            }
            else
            {
                Console.WriteLine("Fisierul este gol!");
            }
        }

        internal bool arataTot()
        {
            throw new NotImplementedException();
        }

        public static void arataPreferinte(string arata)
        {

        }

        public clientMenu()
        {
            InitializeComponent();
        }

        private void btInclusive_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void clientMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
