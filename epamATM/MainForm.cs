using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace epamATM
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    public class Client
    {
        public string Name { get; }
        public string Surname { get; }
        public string PinCode { get; }
        public int Money { get; private set; }
        public Client(string name, string surname, string pinCode, int money)
        {
            Name = name;
            Surname = surname;
            PinCode = pinCode;
            Money = money;
            
        }
    }
}
