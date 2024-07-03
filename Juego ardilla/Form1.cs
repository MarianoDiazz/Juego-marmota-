using System.Media;
namespace Juego_ardilla
{
    public partial class JuegoMarmota : Form
    {
        // Variables del juego
        int numeroMarmotaActual = 1; // Número de marmota actual
        int tiempoNivel = 80; // Tiempo que se disminuye en cada nivel
        int puntuacion = 0; // Puntuación del jugador
        int fallas = 0; // Contador de fallas
        int limiteDeFallas = 3; // Límite de fallas permitidas
        Random rnd = new Random(); // Generador de números aleatorios
        PictureBox pbxatrapame; // PictureBox para mostrar la marmota a atrapar

        public JuegoMarmota()
        {
            InitializeComponent();
            // Inicialización del PictureBox para la marmota a atrapar
            pbxatrapame = new PictureBox();
            pbxatrapame.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(pbxatrapame);
        }

        // Método para iniciar el juego
        public void IniciarJuego()
        {
            // Reiniciar variables de juego
            numeroMarmotaActual = 1;
            tiempoNivel = 80;
            puntuacion = 0;
            fallas = 0;
            limiteDeFallas = 3;
            contadorPuntos.Text = "0";
            contadorFallas.Text = "0";

            // Limpiar el panel de juego y agregar nuevas PictureBox
            panelJuego.Controls.Clear();
            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    var FichaJuego = new PictureBox();
                    FichaJuego.Image = Properties.Resources.AgujeroVacio;
                    FichaJuego.Name = $"{i}_{j}";
                    FichaJuego.Size = new Size(100, 100);
                    FichaJuego.SizeMode = PictureBoxSizeMode.StretchImage;
                    FichaJuego.Click += Jugar;
                    FichaJuego.Tag = "No";
                    panelJuego.Controls.Add(FichaJuego, j, i);
                }
            }

            // Iniciar los temporizadores
            timer1.Start();
            timer2.Start();
        }

        // Método para manejar el clic del usuario en una ficha de juego
        private void Jugar(object sender, EventArgs e)
        {
            var fichaSeleccionadaUsuario = (PictureBox)sender;
            if (fichaSeleccionadaUsuario.Tag.ToString() != "No")
            {
                if (fichaSeleccionadaUsuario.Tag.ToString() == "marmota_" + numeroMarmotaActual)
                {
                    Sonido("falla");
                    puntuacion++;
                    contadorPuntos.Text = puntuacion.ToString();
                    timer1.Interval = Math.Max(1, timer1.Interval - tiempoNivel);
                }
                else
                {
                    Sonido("bien");
                    fallas++;
                    contadorFallas.Text = fallas.ToString();
                }
            }
            else
            {
                Sonido("error");
            }
        }

        // Método para reproducir un sonido
        public void Sonido(string NombreSonido)
        {
            var sonido = (Stream)Properties.Resources.ResourceManager.GetObject(NombreSonido);
            SoundPlayer SonidoCargado = new SoundPlayer(sonido);
            SonidoCargado.Play();
        }

        // Evento que se dispara cuando el formulario se carga
        private void JuegoMarmota_Load(object sender, EventArgs e)
        {
            IniciarJuego();
        }

        // Evento que se dispara en cada tick del timer1
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Limpiar todas las imágenes y etiquetas de las PictureBox
            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    PictureBox pbOcultar = this.Controls.Find($"{i}_{j}", true).FirstOrDefault() as PictureBox;
                    if (pbOcultar != null)
                    {
                        pbOcultar.Image = Properties.Resources.AgujeroVacio;
                        pbOcultar.Tag = "No";
                    }
                }
            }

            // Generar una nueva marmota aleatoria y mostrarla en una posición aleatoria
            int rndColor = rnd.Next(1, 5);
            int rndi = rnd.Next(0, 3);
            int rndj = rnd.Next(0, 3);

            PictureBox pbx = this.Controls.Find($"{rndi}_{rndj}", true).FirstOrDefault() as PictureBox;
            if (pbx != null)
            {
                pbx.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject($"marmota_{rndColor}");
                Sonido("salidaMarmota");
                pbx.Tag = $"marmota_{rndColor}";
            }

            // Verificar si se alcanzó el límite de fallas
            if (fallas == limiteDeFallas)
            {
                timer1.Stop();
                MessageBox.Show($"Juego terminado puntos = {contadorPuntos.Text}");
                timer2.Stop();
                IniciarJuego();
            }
        }

        // Evento que se dispara en cada tick del timer2
        private void timer2_Tick(object sender, EventArgs e)
        {
            // Cambiar la marmota que el jugador debe atrapar
            int numeroMarmota = rnd.Next(1, 5);
            numeroMarmotaActual = numeroMarmota;
            var imageResource = Properties.Resources.ResourceManager.GetObject($"a{numeroMarmotaActual}") as Bitmap;
            if (pbxatrapame != null && imageResource != null)
            {
                pbxatrapame.Image = imageResource;
            }
        }
    }
}
