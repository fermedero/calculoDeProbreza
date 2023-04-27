using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sueldo_UI
{
    public partial class Form1 : Form
    {
        WebBrowser navegador = new WebBrowser();
        Boolean val = false; //para mover el formulario
        public Form1()
        {
            Application.EnableVisualStyles();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            obtenerDatos();
            System.Timers.Timer timer = new System.Timers.Timer(100000);
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
            navegador.ScriptErrorsSuppressed = true;
            navegador.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(this.cargarDatos);
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 2000;
            progressBar1.Value = 0; // Initially set to 0
            groupBox2.Visible = false;
        }

        // Event handler for the timer's Elapsed event
        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            obtenerDatos();
        }
        private void cargarDatos(object senders, EventArgs e)
        {
            int primero = 0;

            foreach (HtmlElement etiqueta in navegador.Document.All)
            {
                if (etiqueta.GetAttribute("classname").Contains("value") && primero == 0 && IsNumeric(etiqueta.InnerText))
                {
                    txDolarCompra.Text = etiqueta.InnerText;
                    primero = 1;
                }
                if (etiqueta.GetAttribute("classname").Contains("value") && IsNumeric(etiqueta.InnerText))
                {
                    txDolarVenta.Text = etiqueta.InnerText;
                }
                if (etiqueta.GetAttribute("classname").Contains("tile is-child") && etiqueta.InnerText.Contains("Actualizado el "))
                {
                    lbActualizado.Text = etiqueta.InnerText;
                }
            }
            Cursor.Current = Cursors.Default;
        }

        public static bool IsNumeric(string input)
        {
            double result;
            return double.TryParse(input.Substring(1), out result);
        }

        private void obtenerDatos()
        {
            navegador.Navigate("https://dolarhoy.com/cotizaciondolarblue");
        }

        private void btCalcularProbreza_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            ModifyProgressBarColor.SetState(progressBar1, 1);

            if (txDolarVenta.Text.Length > 0 && txSueldo.Text.Length > 0)
            {
                double sueldo = 0;
                int result1 = txSueldo.Text.Substring(0).IndexOf('.');
                if (result1 > 0)
                {
                    sueldo = double.Parse(txSueldo.Text.Substring(0, result1));
                }
                else
                {
                    sueldo = double.Parse(txSueldo.Text);
                }

                int result = txDolarVenta.Text.Substring(1).IndexOf('.');
                double valorDolar = double.Parse(txDolarVenta.Text.Substring(1, result));
                double lechuga = Math.Round(sueldo / valorDolar, 2);
                lbEnLechuga.Text = "USD: " + lechuga;

                //actualizo el pobrerometro
                actualizoPobrerometro(Math.Round(lechuga, 0));

            }
            else
            {
                MessageBox.Show("Ni siquiera te puedo calcular tu probreza, que miseria...", "NO CHE");
            }
        }

        private void actualizoPobrerometro(double progres)
        {
            progressBar1.Value = 0;

            if (progres > 2000)
            {
                progres = 2000;
            }

            progressBar1.Value = Convert.ToInt32(progres);
            //parámetro en SetState, 1 = normal(verde); 2 = error(rojo); 3 = advertencia(amarillo).


            if (progres > 750 && progres < 1200)
            {
                ModifyProgressBarColor.SetState(progressBar1, 3);
            }
            else if (progres < 750)
            {
                ModifyProgressBarColor.SetState(progressBar1, 2);
                MessageBox.Show("Te recomiendo aprovechar todas las ofertas que anden dando vueltas.", "SE TE ESTA COMPLICANDO");
            }
            else if (progres < 2000 && progres > 1200)
            {
                ModifyProgressBarColor.SetState(progressBar1, 1);
            }
            else if (progres >= 2000)
            {
                ModifyProgressBarColor.SetState(progressBar1, 1);
                //progressBar1.BackColor = Color.DarkSeaGreen;
                MessageBox.Show("A vos no te va tan mal gordito...", "APA!!!");
            }

            //progressBar1.ForeColor = Color.Red;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            val = true;
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
              val = false;
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            if (val)
            {
                this.Location = Cursor.Position;
            }
         
        }

        private void btnProbrecito_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible=true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox1.Visible = true;
        }
    }

    public static class ModifyProgressBarColor
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);
        public static void SetState(this ProgressBar pBar, int state)
        {
            SendMessage(pBar.Handle, 1040, (IntPtr)state, IntPtr.Zero);
        }
    }
}
