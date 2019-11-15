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
        private ClientRepository clientRepository;
        private Client currentClient;
        public MainForm()
        {
            InitializeComponent();
            currentClient = null;
            clientRepository = new ClientRepository();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DialogResult dialogResult = DialogResult.OK;
            while (dialogResult == DialogResult.OK && currentClient == null)
            {
                PinForm pinForm = new PinForm();
                dialogResult = pinForm.ShowDialog();
                currentClient = clientRepository.GetClientByPin(pinForm.pin);
                if(currentClient == null)
                    MessageBox.Show("пошел нахуй");
            }
            if (currentClient == null)
                Close();
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
