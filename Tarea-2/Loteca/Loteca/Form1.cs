using System.Diagnostics;

namespace Loteca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ResetearColores()
        {
            foreach (TextBox txt in new TextBox[] { txtPrimera, txtSegunda, txtTercera })
            {
                txt.BackColor = Color.White;
                txt.ForeColor = Color.Black;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtJugado.KeyPress += SoloNumeros; //eventos
            txtApostado.KeyPress += SoloNumeros;
        }

        private void SoloNumeros(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back; //verificar que son digitos
        }

        private void btnNuevaJugada_Click(object sender, EventArgs e)
        {
            ResetearColores();

            txtApostado.Text = string.Empty;
            txtJugado.Text = string.Empty;
            txtPrimera.Text = string.Empty;
            txtSegunda.Text = string.Empty;
            txtTercera.Text = string.Empty;
            txtObtenido.Text = string.Empty;

        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            ResetearColores();

            Random rnd = new Random();

            int numPrimera = rnd.Next(0, 100);
            int numSegunda = rnd.Next(0, 100);
            int numTercera = rnd.Next(0, 100);

            if (txtJugado.Text != string.Empty && txtApostado.Text != string.Empty)
            {

                txtPrimera.Text = numPrimera.ToString();
                txtSegunda.Text = numSegunda.ToString();
                txtTercera.Text = numTercera.ToString();

                txtObtenido.Text = string.Empty;

                int numeroJugado = Convert.ToInt32(txtJugado.Text);
                int numeroApostado = Convert.ToInt32(txtApostado.Text);
                int premio = 0;

                if (numeroJugado == numPrimera)
                {
                    premio = numeroApostado * 1000;
                    txtPrimera.BackColor = Color.Green;
                    txtPrimera.ForeColor = Color.White;
                }
                else if (numeroJugado == numSegunda)
                {
                    premio = numeroApostado * 100;
                    txtSegunda.BackColor = Color.Orange;
                    txtSegunda.ForeColor = Color.White;

                }
                else if (numeroJugado == numTercera)
                {
                    premio = numeroApostado * 10;
                    txtTercera.BackColor = Color.Yellow;
                    txtTercera.ForeColor = Color.Black;

                }

                if (premio != 0)
                {
                    txtObtenido.Text = premio.ToString();
                }


            }
        }


    }
}
