using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HomeBankingDV
{
    public partial class Login : Form
    {
    
        public TransfDelegado transfDelegado;
        public Banco elBanco;
        public int dniIngresado;
        public string contraseniaIngresada;

        public Login()
        {
            elBanco = new Banco();
            elBanco.AltaUsuario(39500600, "Tomas", "Rodriguez", "rodriguezt@banco.com", "123456");
            InitializeComponent();
        

        }
        
  

        private void Registrar_Click(object sender, EventArgs e)
        {
            transfDelegado();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dniIngresado = int.Parse(textUsuario.Text);
            contraseniaIngresada = textContrasenia.Text;

            elBanco.IniciarSesion(dniIngresado,contraseniaIngresada);


        }

    }

    public delegate void TransfDelegado();

    
}

