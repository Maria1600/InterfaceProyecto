using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
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
                TextRenderer.DrawText(e.Graphics, tabPage.Text, tabPage.Font, tabRect, tabPage.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
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
    }
        
}
