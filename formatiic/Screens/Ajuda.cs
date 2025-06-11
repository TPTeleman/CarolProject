using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formatiic.Screens
{
    public partial class Ajuda : Form
    {
        public Ajuda()
        {
            InitializeComponent();
        }

        private async void AddSoldier_Click(object sender, EventArgs e)
        {
            string emailDoUsuario = txtEmail.Text;
            string mensagemDoUsuario = txtMensagem.Text;

            try
            {
                await EnviarEmail(emailDoUsuario, mensagemDoUsuario);
                MessageBox.Show("Mensagem enviada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao enviar e-mail: " + ex.Message);
            }
        }

        private async Task EnviarEmail(string emailUsuario, string mensagemUsuario)
        {
            using (HttpClient client = new HttpClient())
            {
                // Aqui vai sua API Key do Resend
                client.DefaultRequestHeaders.Add("Authorization", "Bearer re_NxeTuq59_4aaU7Sy8u7HezB9qM2z2ZehA");

                string json = $@"
                {{
                    ""from"": ""onboarding@resend.dev"",
                    ""to"": ""formatticincc@gmail.com"",
                    ""subject"": ""Novo contato do usuário"",
                    ""html"": ""<p><b>Email do usuário:</b> {emailUsuario}</p><p><b>Mensagem:</b> {mensagemUsuario}</p>""
                }}";

                var content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync("https://api.resend.com/emails", content);

                string resposta = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception($"Erro na API Resend: {resposta}");
                }
            }
        }
    


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

