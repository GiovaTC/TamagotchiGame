namespace TamagotchiGame
{
    public partial class Form1 : Form
    {
        private Tamagotchi miTamagotchi;
        public Form1()
        {
            InitializeComponent();
            miTamagotchi = new Tamagotchi();
            ActualizarInterfaz();
        }

        private void btnAlimentar_Click(object sender, EventArgs e)
        {
            miTamagotchi.Alimentar();
            ActualizarInterfaz();
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            miTamagotchi.Jugar();
            ActualizarInterfaz();
        }

        private void btnDormir_Click(object sender, EventArgs e)
        {
            miTamagotchi.Dormir();
            ActualizarInterfaz();
        }

        private void ActualizarInterfaz()
        {
            lblHambre.Text = $"Hambre: {miTamagotchi.Hambre}";
            lblFelicidad.Text = $"Felicidad: {miTamagotchi.Felicidad}";
            lblEnergia.Text = $"Energía: {miTamagotchi.Energia}";
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            miTamagotchi.PasarTiempo();
            ActualizarInterfaz();
        }
    }
}
