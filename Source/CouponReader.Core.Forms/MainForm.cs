using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CadastroClientsApp;
{
    public partial class MainForm : Form
    {
        public MainForm(){
            InitializeComponent();
        }
    }
}
    private void bntSalvar_Click(object sender, EventArgs e){
        SalvarDadosClientes(txtNome.Text, txtEndereco.Text, txtTelefone.Text, txtEmail.Text);
