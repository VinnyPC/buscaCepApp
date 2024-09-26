using Newtonsoft.Json;
using System;
using System.Drawing;
using System.Net.Http;
using System.Windows.Forms;

namespace buscaCep
{
    public partial class Form1 : Form
    {
        private static readonly HttpClient client = new HttpClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private async void btnBuscar_Click_Click(object sender, EventArgs e)
        {
            string cep = mskCEP.Text;
            if (string.IsNullOrEmpty(cep)) {
                MessageBox.Show("Por favor, insira um CEP válido!");
                return;
            }

            string url = $"https://viacep.com.br/ws/{cep}/json/";
            try
            {
                var response = await client.GetStringAsync(url);
                var endereco = JsonConvert.DeserializeObject<Endereco>(response);
                lblLogradouro.Text = $"Logradouro:{ endereco.Logradouro}";
                lblBairro.Text = $"Bairro: {endereco.Bairro}";
                lblLocalidade.Text = $"Localidade:{ endereco.Localidade}";
                lblUf.Text = $"UF: {endereco.Uf}";
                


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar o CEP: {ex.Message}");
            }
        }
    }
    public class Endereco
    {
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Localidade { get; set; }
        public string Uf { get; set; }
        // public string DDD { get; set; }
    }
}
