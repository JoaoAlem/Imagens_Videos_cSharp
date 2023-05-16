using LibVLCSharp.Shared;

namespace Portfolio02
{
    public partial class Form1 : Form
    {
        // variaveis video
        private readonly LibVLC _libVLC;
        private MediaPlayer _mediaPlayer;

        // variaveis imagem
        private String _selectedImageName = "";

        public Form1()
        {
            InitializeComponent();

            // Inicializando os elementos para o LibVLC
            _libVLC = new LibVLC();
            _mediaPlayer = new MediaPlayer(_libVLC);

            // Adicionando eventos ao pausar e soltar
            _mediaPlayer.Playing += (sender, e) => {
                button1.Invoke((MethodInvoker)delegate
                {
                    button1.Text = "Pause";
                });
            };
            _mediaPlayer.Paused += (sender, e) => {
                button1.Invoke((MethodInvoker)delegate
                {
                    button1.Text = "Play";
                });
            };
        }

        // Eventos gerais
        private void sair(object sender, EventArgs e)
        {
            // quando fehcar, fechar o libVLC e mediaPlayer
            _mediaPlayer.Dispose();
            _libVLC.Dispose();

            // sair da aplicação
            Environment.Exit(0);
        }

        // Eventos especificos do video

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            // abrir uma caixa de dialogo com as opções de videos
            using var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Video Files (*.mp4;*.avi;*.mkv)|*.mp4;*.avi;*.mkv";

            // verificar se abrir o dialogo deu certo
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // definir a nova media sendo o nome do arquivo selecionado
                var media = new Media(_libVLC, openFileDialog.FileName);
                _mediaPlayer.Media = media;
            }

            // tocar o video
            videoView1.MediaPlayer = _mediaPlayer;
            _mediaPlayer.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // pausar o video
            _mediaPlayer.Pause();
        }


        // Eventos especificos da imagem

        private void radioChecked(object sender, EventArgs e)
        {
            _selectedImageName = comboBox1.SelectedItem.ToString() + ((RadioButton)sender).Name;
            splitContainer2.Panel2.BackgroundImage = Properties.Resources.ResourceManager.GetObject(_selectedImageName) as Image;
        }
    }
}
