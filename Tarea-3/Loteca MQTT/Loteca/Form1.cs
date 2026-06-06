using System.Diagnostics;
using MQTTnet;
using System.Text;
using System.Text.Json;

namespace Loteca
{
    public partial class Form1 : Form
    {
        private IMqttClient mqttClient = new MqttClientFactory().CreateMqttClient();

        public int numPrimera;
        public int numSegunda;
        public int numTercera;

        public string numJugado;
        public string montoJugado;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txtJugado.KeyPress += SoloNumeros; //eventos
            txtApostado.KeyPress += SoloNumeros;
        }

        private void ResetearColores()
        {
            foreach (TextBox txt in new TextBox[] { txtPrimera, txtSegunda, txtTercera })
            {
                txt.BackColor = Color.White;
                txt.ForeColor = Color.Black;
            }
        }

        private async Task ResetearGanadorMqqtt()
        {
            if (mqttClient != null && mqttClient.IsConnected)
            {
                string jsonMensaje = string.Empty;

            var mensaje = new MqttApplicationMessageBuilder()
                .WithTopic("Loteria/Jugadas/Ganador")
                .WithPayload(jsonMensaje)
                .Build();

            await mqttClient.PublishAsync(mensaje);
            }
        }

        private void CambiarColor(TextBox txtBackColor, Color fondo, Color letra)
        {
            txtBackColor.BackColor = fondo;
            txtBackColor.ForeColor = letra;
        }

        private async Task MensajeGanador( string mensaje, int monto)
        {

            if (mqttClient != null && mqttClient.IsConnected)
            {
                string stringMensaje =
                "¡HAS GANADO!\n"
                + mensaje + ": $" + monto.ToString("N0");

                var newMensaje = new MqttApplicationMessageBuilder()
                    .WithTopic("Loteria/Jugadas/Ganador")
                    .WithPayload(stringMensaje)
                    .Build();

                await mqttClient.PublishAsync(newMensaje);
            }
        }

        private void SoloNumeros(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back; //verificar que son digitos
        }

        private async Task ResetearTombolaMqtt()
        {
            if (mqttClient != null && mqttClient.IsConnected)
            {
                Jugadas numJugadas = new Jugadas
                {
                    Primera = string.Empty,
                    Segunda = string.Empty,
                    Tercera = string.Empty
                };

                string jsonMensaje = JsonSerializer.Serialize<Jugadas>(numJugadas);

                var mensaje = new MqttApplicationMessageBuilder()
                    .WithTopic("Loteria/Tombola")
                    .WithPayload(jsonMensaje)
                    .Build();

                await mqttClient.PublishAsync(mensaje);

            }
        }

        private async Task NuevaJugada()
        {
            ResetearColores();

            txtApostado.Text = string.Empty;
            txtJugado.Text = string.Empty;
            txtPrimera.Text = string.Empty;
            txtSegunda.Text = string.Empty;
            txtTercera.Text = string.Empty;
            txtObtenido.Text = string.Empty;


            ResetearTombolaMqtt();
            ResetearGanadorMqqtt();
        }

        private async void btnNuevaJugada_Click(object sender, EventArgs e)
        {
            NuevaJugada();
        }

        private async void btnJugar_Click(object sender, EventArgs e)
        {
            ResetearColores();

            Random rnd = new Random();

             numPrimera = rnd.Next(0, 100);
             numSegunda = rnd.Next(0, 100);
             numTercera = rnd.Next(0, 100);

            if (txtJugado.Text != string.Empty && txtApostado.Text != string.Empty)
            {

                //Condicional de conectividad

                if (mqttClient != null && mqttClient.IsConnected)
                {
                    Jugadas numJugadas = new Jugadas
                    {
                        Primera = numPrimera.ToString(),
                        Segunda = numSegunda.ToString(),
                        Tercera = numTercera.ToString()
                    };

                    string jsonMensaje = JsonSerializer.Serialize<Jugadas>(numJugadas);

                    var mensaje = new MqttApplicationMessageBuilder()
                        .WithTopic("Loteria/Tombola")
                        .WithPayload(jsonMensaje)
                        .Build();

                    await mqttClient.PublishAsync(mensaje);

                }
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
                    CambiarColor(txtPrimera, Color.Green, Color.White);

                        MensajeGanador("Primera", premio);
                    
                }
                else if (numeroJugado == numSegunda)
                {
                    premio = numeroApostado * 100;
                    CambiarColor(txtSegunda, Color.Orange, Color.White);

                        MensajeGanador("Segunda", premio);

                }
                else if (numeroJugado == numTercera)
                {
                    premio = numeroApostado * 10;
                    CambiarColor(txtTercera, Color.Yellow, Color.Black);

                        MensajeGanador("Tercera", premio);

                }

                if (premio != 0)
                {
                    txtObtenido.Text = "$" + premio.ToString("N0");
                }
            }
        }

        private async void btnConectar_Click(object sender, EventArgs e)
        {
            btnConectar.Text = "CONECTADO";
            btnConectar.BackColor = Color.Green;

            if (mqttClient == null || !mqttClient.IsConnected)
            {
                var options = new MqttClientOptionsBuilder()
                    .WithTcpServer("bd75534bca5b4795bd7eb15fafbdb796.s1.eu.hivemq.cloud", 8883)
                    .WithCredentials("Admin", "Pacoenmanuel@01")
                    .WithTlsOptions(o => o.WithCertificateValidationHandler(_ => true))
                    .Build();

                await mqttClient.ConnectAsync(options);

                NuevaJugada();

                //Suscribirse al topico
                await mqttClient.SubscribeAsync("Loteria/Jugadas/JugadaCliente");

                //Oir Broker
                mqttClient.ApplicationMessageReceivedAsync += async args =>
                {
                    string mensaje = Encoding.UTF8.GetString(args.ApplicationMessage.Payload);

                    Invoke(() =>
                    {

                        if (mensaje == "JUGAR")
                        {
                            ResetearGanadorMqqtt();
                            btnJugar_Click(null, null);
                        }
                        else
                        {

                            montoJugado = string.Empty;
                            numJugado = string.Empty;

                        string[] numero_monto = mensaje.Split('-');

                            if (numero_monto.Length == 2 
                            && numero_monto[0].Length > 0 
                            && numero_monto[0].Length > 0 
                            && numero_monto[1].Length > 0 
                            && numero_monto[0].All(char.IsDigit) 
                            && numero_monto[1].All(char.IsDigit))
                            {
                                montoJugado = numero_monto[0];
                                numJugado = numero_monto[1];
                            }


                        JugadaCliente jugada = new JugadaCliente
                        {
                            NumeroJugado = numJugado,
                            Monto = montoJugado
                        };
                            
                            int.TryParse(jugada.NumeroJugado, out int numero);
                            
                            if (numero >= 0 && numero < 100)
                            {
                                txtJugado.Text = jugada.NumeroJugado;
                                txtApostado.Text = jugada.Monto;
                            }
                            else 
                            {
                                txtJugado.Text = string.Empty;
                                txtApostado.Text = string.Empty;
                            }

                        }
                    });
                };

            }
            else
            {
                btnConectar.Text = "DESCONECTADO";
                btnConectar.BackColor = Color.Red;
                NuevaJugada();
                mqttClient.DisconnectAsync();

            }

        }




    }
}
