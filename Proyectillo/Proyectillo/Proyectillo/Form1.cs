using Microsoft.Win32;
using PdfiumViewer;
using Proyectillo.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyectillo
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // Activar el modo de dibujo personalizado
            tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl1.DrawItem += new DrawItemEventHandler(tabControl1_DrawItem);
            tabControl1.Paint += new PaintEventHandler(tabControl1_Paint);
            admin1.Visible = false;
            prof1.Visible = false;
            prof2.Visible = false;
            prof3.Visible = false;
            prof4.Visible = false;
            prof5.Visible = false;
            prof6.Visible = false;
            linkLabel3.Links.Add(0, linkLabel1.Text.Length, "https://maps.app.goo.gl/fkCarFj8Kh6igiVi7");
            linkLabel4.Links.Add(0, linkLabel1.Text.Length, "https://maps.app.goo.gl/kNBRVWVVhuBTeA8u6");
            linkLabel5.Links.Add(0, linkLabel1.Text.Length, "https://maps.app.goo.gl/SGUYoqkvLnsVecPB9");
            groupBox4.Visible = false;
            et0.Visible = false;
            et1.Visible = false;
            et2.Visible = false;
            et3.Visible = false;
            et4.Visible = false;
            et5.Visible = false;
            et6.Visible = false;
            et7.Visible = false;
            et8.Visible = false;
            et9.Visible = false;
            et10.Visible = false;
            et11.Visible = false;
            et12.Visible = false;
            et13.Visible = false;
            et14.Visible = false;
            et15.Visible = false;
            et16.Visible = false;
            et17.Visible = false;

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            linkLabel1.Text = "Pulsa aqui";
            linkLabel1.Links.Add(0, linkLabel1.Text.Length, "https://cescristorey.com/");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = e.Link.LinkData?.ToString(); // Verifica si hay datos antes de abrir el enlace
            if (!string.IsNullOrEmpty(url))
            {
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabPage tabPage = tabControl1.TabPages[e.Index];
            Rectangle tabRect = e.Bounds;

            // Establecer color de fondo para todas las pestañas
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(8, 68, 105)), tabRect);

            // Solo dibujar el icono en una pestaña específica (ejemplo: índice 1)
            if (e.Index == 0) // Cambia el índice según la pestaña donde quieres el icono
            {
                // Acceder a la imagen desde los recursos
                Image icono = Properties.Resources.logitoMejor; // Cambia 'NombreDeTuImagen' por el nombre real

                // Posición del icono centrado en la pestaña
                int imgX = tabRect.X + (tabRect.Width - icono.Width) / 2;
                int imgY = tabRect.Y + (tabRect.Height - icono.Height) / 2;
                e.Graphics.DrawImage(icono, new Point(imgX, imgY));
            }
            else
            {
                // Dibujar texto normal en las demás pestañas
                TextRenderer.DrawText(e.Graphics, tabPage.Text, tabPage.Font, tabRect, Color.White, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            }
        }

        private void tabControl1_Paint(object sender, PaintEventArgs e)
        {
            // Cambiar el fondo del TabControl al color de la pestaña seleccionada
            Color colorFondo = Color.FromArgb(8, 68, 105);
            e.Graphics.Clear(colorFondo);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string urlPdf = "C:\\Users\\maria\\OneDrive\\Desktop\\InterfaceProyecto\\Proyectillo\\Proyectillo\\Proyectillo\\Resources\\Normas.pdf"; // URL del PDF
            string rutaDestino = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Normas.pdf"); // Ruta donde guardar el PDF
            using (WebClient client = new WebClient())
            {
                try
                {
                    client.DownloadFile(urlPdf, rutaDestino); // Descarga el PDF
                    MessageBox.Show("PDF descargado correctamente en el escritorio."); // Mensaje de éxito
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al descargar el PDF: " + ex.Message); // Mensaje de error
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Inicio_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            String usuario = user.Text;
            String password = pass.Text;

            if ( (usuario == "admin") && (password == "admin") ) {
                iniciaSesion1.Visible = false;
                admin1.Visible = true;
                prof1.Visible = true;
                prof2.Visible = true;
                prof3.Visible = true;
                prof4.Visible = true;
                prof5.Visible = true;
                prof6.Visible = true;

            }
            else
            {
                credenciales.Text = "Credenciales incorrectas";
            }

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void cambiosProf_Click(object sender, EventArgs e)
        {
            String cargo, name;
            cargo = Cargo.Text;
            name = nombreprof.Text;

            if (!(string.IsNullOrEmpty(numProf.Text)))
            {

                int id = int.Parse(numProf.Text);

                if (id == 1)
                {
                    if (string.IsNullOrEmpty(cargo) && !(string.IsNullOrEmpty(name)))
                    {
                        Name1.Text = name;
                    }
                    else if (string.IsNullOrEmpty(name) && !(string.IsNullOrEmpty(cargo)))
                    {
                        Cargo1.Text = cargo;
                    }
                    else if (!(string.IsNullOrEmpty(name)) && !(string.IsNullOrEmpty(cargo)))
                    {
                        Name1.Text = name;
                        Cargo1.Text = cargo;
                    }
                }
                else if (id == 2)
                {
                    if (string.IsNullOrEmpty(cargo) && !(string.IsNullOrEmpty(name)))
                    {
                        Name2.Text = name;
                    }
                    else if (string.IsNullOrEmpty(name) && !(string.IsNullOrEmpty(cargo)))
                    {
                        Cargo2.Text = cargo;
                    }
                    else if (!(string.IsNullOrEmpty(name)) && !(string.IsNullOrEmpty(cargo)))
                    {
                        Name2.Text = name;
                        Cargo2.Text = cargo;
                    }
                }
                else if (id == 3)
                {
                    if (string.IsNullOrEmpty(cargo) && !(string.IsNullOrEmpty(name)))
                    {
                        Name3.Text = name;
                    }
                    else if (string.IsNullOrEmpty(name) && !(string.IsNullOrEmpty(cargo)))
                    {
                        Cargo3.Text = cargo;
                    }
                    else if (!(string.IsNullOrEmpty(name)) && !(string.IsNullOrEmpty(cargo)))
                    {
                        Name3.Text = name;
                        Cargo3.Text = cargo;
                    }
                }
                else if (id == 4)
                {
                    if (string.IsNullOrEmpty(cargo) && !(string.IsNullOrEmpty(name)))
                    {
                        Name4.Text = name;
                    }
                    else if (string.IsNullOrEmpty(name) && !(string.IsNullOrEmpty(cargo)))
                    {
                        Cargo4.Text = cargo;
                    }
                    else if (!(string.IsNullOrEmpty(name)) && !(string.IsNullOrEmpty(cargo)))
                    {
                        Name4.Text = name;
                        Cargo4.Text = cargo;
                    }
                }
                else if (id == 5)
                {
                    if (string.IsNullOrEmpty(cargo) && !(string.IsNullOrEmpty(name)))
                    {
                        Name5.Text = name;
                    }
                    else if (string.IsNullOrEmpty(name) && !(string.IsNullOrEmpty(cargo)))
                    {
                        Cargo5.Text = cargo;
                    }
                    else if (!(string.IsNullOrEmpty(name)) && !(string.IsNullOrEmpty(cargo)))
                    {
                        Name5.Text = name;
                        Cargo5.Text = cargo;
                    }
                }
                else if (id == 6)
                {
                    if (string.IsNullOrEmpty(cargo) && !(string.IsNullOrEmpty(name)))
                    {
                        Name6.Text = name;
                    }
                    else if (string.IsNullOrEmpty(name) && !(string.IsNullOrEmpty(cargo)))
                    {
                        Cargo6.Text = cargo;
                    }
                    else if (!(string.IsNullOrEmpty(name)) && !(string.IsNullOrEmpty(cargo)))
                    {
                        Name6.Text = name;
                        Cargo6.Text = cargo;
                    }
                }
            }
        }

        private void label11_Click_1(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void botonVerCole_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
        }

        private void botonVerPuntoInteres_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(4);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("¡¡Hemos recibido correctamente su propuesta!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String usuario = textBox4.Text;
            String password = textBox5.Text;

            if ((usuario == "admin") && (password == "admin"))
            {
                groupBox3.Visible = false;
                groupBox4.Visible = true;
                et0.Visible = true;
                et1.Visible = true;
                et2.Visible = true;
                et3.Visible = true;
                et4.Visible = true;
                et5.Visible = true;
                et6.Visible = true;
                et7.Visible = true;
                et8.Visible = true;
                et9.Visible = true;
                et10.Visible = true;
                et11.Visible = true;
                et12.Visible = true;
                et13.Visible = true;
                et14.Visible = true;
                et15.Visible = true;
                et16.Visible = true;
                et17.Visible = true;

            }
            else
            {
                credenciales2.Text = "Credenciales incorrectas";
            }
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = e.Link.LinkData.ToString(); // Obtiene la URL asignada
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true // Necesario para abrir en navegadores modernos
            });
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = e.Link.LinkData.ToString(); // Obtiene la URL asignada
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true // Necesario para abrir en navegadores modernos
            });
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = e.Link.LinkData.ToString(); // Obtiene la URL asignada
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true // Necesario para abrir en navegadores modernos
            });
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            String aulaName;
            aulaName = ClaseNew.Text;

            if (!(string.IsNullOrEmpty(numAula.Text)))
            {

                int id = int.Parse(numAula.Text);

                if (id == 1)
                {
                    if (!(string.IsNullOrEmpty(aulaName)))
                    {
                        aula1.Text = aulaName;
                    }

                }
                else if (id == 2)
                {
                    if (!(string.IsNullOrEmpty(aulaName)))
                    {
                        aula2.Text = aulaName;
                    }

                }
                else if (id == 3)
                {
                    if (!(string.IsNullOrEmpty(aulaName)))
                    {
                        aula3.Text = aulaName;
                    }

                }
                else if (id == 4)
                {
                    if (!(string.IsNullOrEmpty(aulaName)))
                    {
                        aula4.Text = aulaName;
                    }

                }
                else if (id == 5)
                {
                    if (!(string.IsNullOrEmpty(aulaName)))
                    {
                        aula5.Text = aulaName;
                    }

                }
                else if (id == 6)
                {
                    if (!(string.IsNullOrEmpty(aulaName)))
                    {
                        aula6.Text = aulaName;
                    }

                }
                else if (id == 7)
                {
                    if (!(string.IsNullOrEmpty(aulaName)))
                    {
                        aula7.Text = aulaName;
                    }

                }
                else if (id == 8)
                {
                    if (!(string.IsNullOrEmpty(aulaName)))
                    {
                        aula8.Text = aulaName;
                    }

                }
                else if (id == 9)
                {
                    if (!(string.IsNullOrEmpty(aulaName)))
                    {
                        aula9.Text = aulaName;
                    }

                }
                else if (id == 10)
                {
                    if (!(string.IsNullOrEmpty(aulaName)))
                    {
                        aula10.Text = aulaName;
                    }

                }
                else if (id == 11)
                {
                    if (!(string.IsNullOrEmpty(aulaName)))
                    {
                        aula11.Text = aulaName;
                    }

                }
                else if (id == 12)
                {
                    if (!(string.IsNullOrEmpty(aulaName)))
                    {
                        aula12.Text = aulaName;
                    }

                }
                else if (id == 13)
                {
                    if (!(string.IsNullOrEmpty(aulaName)))
                    {
                        aula13.Text = aulaName;
                    }

                }
                else if (id == 14)
                {
                    if (!(string.IsNullOrEmpty(aulaName)))
                    {
                        aula14.Text = aulaName;
                    }

                }
                else if (id == 15)
                {
                    if (!(string.IsNullOrEmpty(aulaName)))
                    {
                        aula15.Text = aulaName;
                    }

                }
                else if (id == 16)
                {
                    if (!(string.IsNullOrEmpty(aulaName)))
                    {
                        aula16.Text = aulaName;
                    }

                }
                else if (id == 17)
                {
                    if (!(string.IsNullOrEmpty(aulaName)))
                    {
                        aula17.Text = aulaName;
                    }

                }
            }
        }

        private void aula1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string urlPdf = "C:\\Users\\maria\\OneDrive\\Desktop\\InterfaceProyecto\\Proyectillo\\Proyectillo\\Proyectillo\\Resources\\CristoInfo_ Manual de administrador.pdf"; // URL del PDF
            string rutaDestino = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "ManualAdmin.pdf"); // Ruta donde guardar el PDF
            using (WebClient client = new WebClient())
            {
                try
                {
                    client.DownloadFile(urlPdf, rutaDestino); // Descarga el PDF
                    MessageBox.Show("PDF descargado correctamente en el escritorio."); // Mensaje de éxito
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al descargar el PDF: " + ex.Message); // Mensaje de error
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string urlPdf = "C:\\Users\\maria\\OneDrive\\Desktop\\InterfaceProyecto\\Proyectillo\\Proyectillo\\Proyectillo\\Resources\\CristoInfo_ Manual de administrador.pdf"; // URL del PDF
            string rutaDestino = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "ManualAdmin.pdf"); // Ruta donde guardar el PDF
            using (WebClient client = new WebClient())
            {
                try
                {
                    client.DownloadFile(urlPdf, rutaDestino); // Descarga el PDF
                    MessageBox.Show("PDF descargado correctamente en el escritorio."); // Mensaje de éxito
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al descargar el PDF: " + ex.Message); // Mensaje de error
                }
            }
        }
    }
        
}
