namespace VisualizadorDeProdutos {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) {
            string pastaImagens = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Carros");

            if (!Directory.Exists(pastaImagens)) {
                MessageBox.Show("Pasta de imagens não encontrada: " + pastaImagens);
                return;
            }

            string[] arquivos = Directory.GetFiles(pastaImagens);

            if (arquivos.Length == 0) {
                MessageBox.Show("Nenhuma imagem encontrada na pasta: " + pastaImagens);
                return;
            }

            foreach (string caminhoCompleto in arquivos) {
                string nomeArquivoSemExtensao = Path.GetFileNameWithoutExtension(caminhoCompleto);

                if (comboBox2.Text == nomeArquivoSemExtensao) {
                    if (File.Exists(caminhoCompleto)) {
                        pictureBox2.ImageLocation = caminhoCompleto;
                        pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else {
                        MessageBox.Show("Imagem não encontrada em: " + caminhoCompleto);
                    }

                    return; // para evitar iteração desnecessária
                }
            }

            MessageBox.Show("Imagem não encontrada para o modelo selecionado.");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {

            comboBox2.Text = string.Empty;

            if (comboBox1.Text == "FIAT") {

                comboBox2.Items.Clear();
                comboBox2.Items.Add("ARGO DRIVE 1.0");
                comboBox2.Items.Add("CRONOS DRIVE 1.0");
                comboBox2.Items.Add("MOBI LIKE 1.0");
            }

            else if (comboBox1.Text == "HYUNDAI") {

                comboBox2.Items.Clear();
                comboBox2.Items.Add("HB20 COMFORT PLUS 1.0");
                comboBox2.Items.Add("HB20S COMFORT PLUS 1.0");

            }

            else if (comboBox1.Text == "CHEVROLET") {

                comboBox2.Items.Clear();
                comboBox2.Items.Add("ONIX PLUS LTZ 1.0");
                comboBox2.Items.Add("ONIX LT 1.0");
                comboBox2.Items.Add("TRACKER LT 1.0");

            }

            else if (comboBox1.Text == "VOLKSWAGEN") {

                comboBox2.Items.Clear();
                comboBox2.Items.Add("POLO TRACK 1.0");
                comboBox2.Items.Add("T-CROSS 1.0");
                comboBox2.Items.Add("NIVUS HIGHLINE 1.0");

            }

            else if (comboBox1.Text == "RENAULT") {

                comboBox2.Items.Clear();
                comboBox2.Items.Add("KWID ZEN 1.0");
                comboBox2.Items.Add("DUSTER ICONIC 1.6");
                comboBox2.Items.Add("OROCH PRO 1.6");

            }
        }
    }
}
