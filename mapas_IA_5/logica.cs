using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mapas_IA_5
{
    internal class logica
    {
        public logica()
        {
            // aquila
            nodo aquila = new nodo("aquila");
            nodo maruata = new nodo("maruata");
            nodo tepalcatepec = new nodo("tepalcatepec");
            nodo apatzingan = new nodo("apatzingan");
            nodo nueva_italia = new nodo("nueva italia");
            nodo lazaro_cardenas = new nodo("lazaro cardenas");
            nodo los_reyes = new nodo("los reyes");
            nodo uruapan = new nodo("uruapan");
            nodo sahuayo = new nodo("sahuayo");
            nodo zamora = new nodo("zamora");
            nodo zacapu = new nodo("zacapu");
            nodo patzcuaro = new nodo("patzcuaro");
            nodo morelia = new nodo("morelia");
            nodo cd_hidalgo = new nodo("ciudad hidalgo");

            // vertices de aquila
            aquila.vecinos.Add(maruata);
            aquila.vecinos.Add(tepalcatepec);
            // aquila - maruata
            aquila.vertices.Add(new vertice(aquila, maruata, 2));
            // aquila - tepalcatepec
            aquila.vertices.Add(new vertice(aquila, tepalcatepec, 3));

            // vertices de maruata
            maruata.vecinos.Add(aquila);
            maruata.vecinos.Add(lazaro_cardenas);
            // marata - aquila
            maruata.vertices.Add(new vertice(maruata, aquila, 2));
            // maruata - lazaro cardenas
            maruata.vertices.Add(new vertice(maruata, lazaro_cardenas, 3));

            // vertices de lazaro cardenas
            lazaro_cardenas.vecinos.Add(maruata);
            lazaro_cardenas.vecinos.Add(nueva_italia);
            // lazaro - maruata
            lazaro_cardenas.vertices.Add(new vertice(lazaro_cardenas, maruata, 3));
            // lazaro - nueva italia
            lazaro_cardenas.vertices.Add(new vertice(lazaro_cardenas, nueva_italia, 5));

            // vertices de nueva italia
            nueva_italia.vecinos.Add(apatzingan);
            nueva_italia.vecinos.Add(lazaro_cardenas);
            nueva_italia.vecinos.Add(patzcuaro);
            // italia - lazaro
            nueva_italia.vertices.Add(new vertice(nueva_italia, lazaro_cardenas, 5));
            // italia - apatzingan
            nueva_italia.vertices.Add(new vertice(nueva_italia, apatzingan, 3));
            // italia - patzcuaro
            nueva_italia.vertices.Add(new vertice(nueva_italia, patzcuaro, 3));

            // vertices de apatzingan
            apatzingan.vecinos.Add(nueva_italia);
            apatzingan.vecinos.Add(tepalcatepec);
            apatzingan.vecinos.Add(uruapan);
            // apatzingan - nueva italia
            apatzingan.vertices.Add(new vertice(apatzingan, nueva_italia, 3));
            // apatzingan - tepalcatepec
            apatzingan.vertices.Add(new vertice(apatzingan, tepalcatepec, 3));
            // apatzingan - uruapan
            apatzingan.vertices.Add(new vertice(apatzingan, uruapan, 3));

            // vertices de tepalcatepec
            tepalcatepec.vecinos.Add(los_reyes);
            tepalcatepec.vecinos.Add(aquila);
            tepalcatepec.vecinos.Add(apatzingan);
            // tepa - aquila
            tepalcatepec.vertices.Add(new vertice(tepalcatepec, aquila, 3));
            // tepa - los reyes
            tepalcatepec.vertices.Add(new vertice(tepalcatepec, los_reyes, 4));
            // tepa - apatzingan
            tepalcatepec.vertices.Add(new vertice(tepalcatepec, apatzingan, 3));

            // vertices de los reyes
            los_reyes.vecinos.Add(tepalcatepec);
            los_reyes.vecinos.Add(sahuayo);
            los_reyes.vecinos.Add(uruapan);
            // los reyes - tepa
            los_reyes.vertices.Add(new vertice(los_reyes, tepalcatepec, 3));
            // reyes - uruapan
            los_reyes.vertices.Add(new vertice(los_reyes, uruapan, 2));
            // reyes - sahuayo
            los_reyes.vertices.Add(new vertice(los_reyes, sahuayo, 3));

            // vertices de uruapan
            uruapan.vecinos.Add(los_reyes);
            uruapan.vecinos.Add(zamora);
            uruapan.vecinos.Add(apatzingan);
            // uruapan - apatzingan
            uruapan.vertices.Add(new vertice(uruapan, apatzingan, 3));
            // uruapan - los reyes
            uruapan.vertices.Add(new vertice(uruapan, los_reyes, 2));
            // uruapan - zamora
            uruapan.vertices.Add(new vertice(uruapan, zamora, 3));

            // vertices sahuayo
            sahuayo.vecinos.Add(los_reyes);
            sahuayo.vecinos.Add(zamora);
            // sahuayo - los reyes
            sahuayo.vertices.Add(new vertice(sahuayo, los_reyes, 3));
            // sahuayo - zamora
            sahuayo.vertices.Add(new vertice(sahuayo, zamora, 3));

            // vertices de zamora
            zamora.vecinos.Add(sahuayo);
            zamora.vecinos.Add(uruapan);
            zamora.vecinos.Add(zacapu);
        }
        
    }
}
