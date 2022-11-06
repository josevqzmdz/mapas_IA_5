using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mapas_IA_5
{
    public partial class Form1 : Form
    {
        logica logic = new logica();

        // inicializacion de los nodos
        public static nodo aquila = new nodo("aquila");
        public static nodo maruata = new nodo("maruata");
        public static nodo tepalcatepec = new nodo("tepalcatepec");
        public static nodo apatzingan = new nodo("apatzingan");
        public static nodo nueva_italia = new nodo("nueva italia");
        public static nodo lazaro_cardenas = new nodo("lazaro cardenas");
        public static nodo los_reyes = new nodo("los reyes");
        public static nodo uruapan = new nodo("uruapan");
        public static nodo sahuayo = new nodo("sahuayo");
        public static nodo zamora = new nodo("zamora");
        public static nodo zacapu = new nodo("zacapu");
        public static nodo patzcuaro = new nodo("patzcuaro");
        public static nodo morelia = new nodo("morelia");
        public static nodo cd_hidalgo = new nodo("ciudad hidalgo");

        // lista de adyacencia
        public static List<nodo> listaAdyacencia = new List<nodo> {
            aquila, maruata, tepalcatepec, apatzingan, nueva_italia,
            lazaro_cardenas, los_reyes, uruapan, sahuayo, zamora,
            zacapu, patzcuaro, morelia, cd_hidalgo
        };

        public static List<vertice> listaVertices;
        public Form1()
        {
            InitializeComponent();
            nodo.SetVecinos(aquila, maruata, 2); //
            nodo.SetVecinos(aquila, tepalcatepec, 3); //
            nodo.SetVecinos(maruata, lazaro_cardenas, 3);//
            nodo.SetVecinos(lazaro_cardenas, nueva_italia, 5); //
            nodo.SetVecinos(nueva_italia, apatzingan, 5); //
            nodo.SetVecinos(nueva_italia, patzcuaro, 3); //
            nodo.SetVecinos(apatzingan, tepalcatepec, 3); //
            nodo.SetVecinos(apatzingan, uruapan, 3); //
            nodo.SetVecinos(tepalcatepec, los_reyes, 3); //
            nodo.SetVecinos(los_reyes, sahuayo, 2); //
            nodo.SetVecinos(los_reyes, uruapan, 3); //
            nodo.SetVecinos(uruapan, zamora, 2); //
            nodo.SetVecinos(sahuayo, zamora, 3); //
            nodo.SetVecinos(zamora, zacapu, 4); //
            nodo.SetVecinos(zacapu, patzcuaro, 2); //
            nodo.SetVecinos(zacapu, morelia, 2); //
            nodo.SetVecinos(patzcuaro, morelia, 2); //
            nodo.SetVecinos(morelia, cd_hidalgo, 3); //

        }
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var n in aquila.busquedaProfundidad())
            {
                Console.WriteLine($"De {n.Item1.nombre} hasta {n.Item2.nombre} : {n.Item3}");
            }
        }
    }
}
