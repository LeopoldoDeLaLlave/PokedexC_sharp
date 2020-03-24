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
    public partial class VentanaInfo : Form
    {

        Conexion miConexion = new Conexion();

        DataTable misPokemons = new DataTable();
        int idActual = 1;//El pokemon que estamos viendo

        public VentanaInfo()
        {
            InitializeComponent();
        }


        private Image convierteBlob(byte[] img)
        {
            MemoryStream ms = new System.IO.MemoryStream(img);
            return (Image.FromStream(ms));

        }

        //Retrocede uno en la lista de Pokemons
        private void bIzquierdo_Click(object sender, EventArgs e)
        {
            idActual--;
            if (idActual <= 0) { idActual = 1; }
            infoPokemos();
        }

        //Se adelanta uno en la lista de Pokemons
        private void button2_Click(object sender, EventArgs e)
        {
            idActual++;
            if (idActual >= 152) { idActual = 151; }
            infoPokemos();
        }

        //Obtiene la información de los pokemos que hay en la base de datos según el ID
        private void infoPokemos()
        {
            misPokemons = miConexion.getPokemonPorId(idActual);
            labelNombre.Text = misPokemons.Rows[0]["nombre"].ToString();//Ponemos el nombre
            pictureBox2.Image = convierteBlob((byte[])misPokemons.Rows[0]["imagen"]);//Ponemos la imagen
            //Ponemos el ID
            if (idActual < 10)
            {
                labelID.Text = "Nº: 00" + idActual;

            }
            else if (idActual < 100)
            {
                labelID.Text = "Nº: 0" + idActual;
            }
            else
            {
                labelID.Text = "Nº: " + idActual;
            }
            lTipo1.Text = misPokemons.Rows[0]["tipo1"].ToString();//Ponemos el tipo1
            lTipo2.Text = misPokemons.Rows[0]["tipo2"].ToString();//Ponemos el tipo2
            lAltura.Text = misPokemons.Rows[0]["altura"].ToString() + " m";//Ponemos la altura
            lPeso.Text = misPokemons.Rows[0]["peso"].ToString() + " kg";//Ponemos el peso
            lHabilidad.Text = misPokemons.Rows[0]["habilidad"].ToString();//Ponemos la habilidad
            lEspecie.Text = misPokemons.Rows[0]["especie"].ToString();//Ponemosla especie
            lHabitat.Text = misPokemons.Rows[0]["habitat"].ToString();//Ponemos el habitat

            //Ponemos los movimientos
            lMov1.Text = misPokemons.Rows[0]["movimiento1"].ToString();
            lMov2.Text = misPokemons.Rows[0]["movimiento2"].ToString();
            lMov3.Text = misPokemons.Rows[0]["movimiento3"].ToString();
            lMov4.Text = misPokemons.Rows[0]["movimiento4"].ToString();

            richTextBox1.Text= misPokemons.Rows[0]["descripcion"].ToString();
        }


    }
}
