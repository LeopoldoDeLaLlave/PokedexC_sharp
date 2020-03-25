using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokedexC_sharp
{
    public partial class Buscador : Form
    {
        public Buscador()
        {
            InitializeComponent();
        }

        private void BuscaId_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(textBoxID.Text) < 1 || int.Parse(textBoxID.Text) > 151)
                {//Si el número es mayor que 151 o mnor que 1 hago fallar al programa para que salte al catch
                    int prueba = int.Parse("gre");//Esto da fallo siempre
                }
                VentanaInfo v = new VentanaInfo();
                v.idActual = int.Parse(textBoxID.Text);
                v.infoPokemos();
                v.Show();
            }
            catch (Exception ex)
            {
                DialogResult res = MessageBox.Show("ID no encontrado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxID.Text = "";
            }

        }

        private void buscaNombre_Click(object sender, EventArgs e)
        {
           

            try
            {
                Conexion c = new Conexion();
                VentanaInfo v = new VentanaInfo();
                v.idActual = int.Parse(c.getPokemonPorNombre(textBoxNombre.Text.ToLower()));
                v.infoPokemos();
                v.Show();
            }
            catch (Exception ex)
            {
                DialogResult res = MessageBox.Show("Nombre no encontrado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxNombre.Text = "";
            }


        }
    }
}
