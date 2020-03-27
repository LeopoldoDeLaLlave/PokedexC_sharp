using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Autor: Javier de la Llave
 * 
 * Buscador de pokemons
 */
namespace PokedexC_sharp
{
    public partial class Buscador : Form
    {
        Conexion c = new Conexion();
        public Buscador()
        {
            InitializeComponent();
            dataGridView1.DataSource = c.getTodos();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

        }

        //Recibe el id y muestra el pokemon en otro form
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
                textBoxID.Text = "";//Dejamo el buscador de ID vacío
            }
            catch (Exception ex)
            {//Si el id no es valido salta un aviso
                MessageBox.Show("ID no encontrado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxID.Text = "";
            }

        }

        //Recibe un nombre y muestra el pokemon en otro form
        private void buscaNombre_Click(object sender, EventArgs e)
        {
           

            try
            {
                Conexion c = new Conexion();
                VentanaInfo v = new VentanaInfo();
                v.idActual = int.Parse(c.getPokemonPorNombre(textBoxNombre.Text.ToLower()));
                v.infoPokemos();
                v.Show();
                textBoxNombre.Text = "";//vacíamos la búsqueda
            }
            catch (Exception ex)
            {//Si el nombre no es valido salta un aviso
                MessageBox.Show("Nombre no encontrado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxNombre.Text = "";
            }


        }

        //Muestra en otro form un pokemon aleatorio
        private void bRandom_Click(object sender, EventArgs e)
        {
            VentanaInfo v = new VentanaInfo();
            Random rand = new Random();
            v.idActual = rand.Next(1,152);//Genero un número aleatorio entre 1 y 151 que son los valores entre los que están comprendidos lod id's
            v.infoPokemos();
            v.Show();
        }

        //Muestra en otro form el pokemon elegido en el datagridView1
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            VentanaInfo v = new VentanaInfo();
            v.idActual = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString());
            v.infoPokemos();
            v.Show();
        }
    }
}
