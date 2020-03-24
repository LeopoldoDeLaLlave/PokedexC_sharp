using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokedexC_sharp
{
    public partial class VentanaPrincipal : Form
    {

        Conexion miConexion = new Conexion();

        DataTable misPokemons = new DataTable();
        int idActual = 1;//El pokemon que estamos viendo

        public VentanaPrincipal()
        {
            InitializeComponent();
        }


        private Image convierteBlob(byte[] img)
        {
            MemoryStream ms = new System.IO.MemoryStream(img);
            return (Image.FromStream(ms));

        }

        private void bIzquierdo_Click(object sender, EventArgs e)
        {
            idActual--;
            if (idActual <= 0) { idActual = 1; }
            misPokemons = miConexion.getPokemonPorId(idActual);
            nombre.Text = misPokemons.Rows[0]["nombre"].ToString();
            pictureBox2.Image = convierteBlob((byte[])misPokemons.Rows[0]["imagen"]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            idActual++;
            if (idActual >= 152) { idActual = 151; }
            misPokemons = miConexion.getPokemonPorId(idActual);
            nombre.Text = misPokemons.Rows[0]["nombre"].ToString();
            pictureBox2.Image = convierteBlob((byte[])misPokemons.Rows[0]["imagen"]);
        }
    }
}
