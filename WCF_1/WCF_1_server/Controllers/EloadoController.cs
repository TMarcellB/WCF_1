using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml.Linq;
using WCF_1_server.Models;

namespace WCF_1_server.Controllers
{
    public class EloadoController
    {
        public List<Eloado> EloadokLista()
        {
            List<Eloado> list = new List<Eloado>();
            Eloado eloadok = new Eloado();
            string[] sorok = File.ReadAllLines("C:\\Users\\Rendszergazda\\Documents\\BACKEND\\WCF_1\\WCF_1_server\\allomany.txt");

            for (int i = 1; i < sorok.Length; i++)
            {
                string[] bontas = sorok[i].Split(';');
                list.Add(new Eloado()
                {
                    EloadoAz = int.Parse(bontas[0]),
                    EloadoName = bontas[1]

                });
                

            }
            return list;
        }
        public string InsertEloado(Eloado ujEloado)
        {
            ujEloado.EloadoAz = GenerateId();
            StreamWriter sw = new StreamWriter("C:\\Users\\Rendszergazda\\Documents\\BACKEND\\WCF_1\\WCF_1_server\\allomany.txt",true);
            sw.WriteLine(ujEloado.ToString());
            sw.Close();
            
            return "Sikeres";
        }
        
        public string UpdateEloado(Eloado modositEloado)
        {
            //Beolvasok az állományból egy listába
            List<Eloado> list = EloadokLista();
            //Listában megkeresem a megfelelől azon-t//Módosítom az adatokat
            int index = 0;
            while (index < list.Count && list[index].EloadoAz != modositEloado.EloadoAz)
            {
                index++;
            }

            if (index < list.Count)
            {
                list[index].EloadoName = modositEloado.EloadoName;
                StreamWriter kiir = new StreamWriter(@"C:\Users\Rendszergazda\Documents\BACKEND\WCF_1\WCF_1_server\allomany.txt");
                kiir.WriteLine("Azon;EloadoName");
                foreach (var item in list)
                {

                    kiir.WriteLine(item.ToString());
                }
                kiir.Close();

                //Módositott listával ujragenerálom az állományt
                //ha nem megtalálom akkor nem változtatok csak  üzenem hogy nincs ilyen 

                return "Sikeres cuccos";
            }
            else
            {
                return "Sikertelen cuccos";
            }
        }
        public string DeleteEloado(int azon)
        {
            List<Eloado> list = EloadokLista();
            //Listában megkeresem a megfelelől azon-t//Módosítom az adatokat
            int index = 0;
            while (index < list.Count && list[index].EloadoAz != azon)
            {
                index++;
            }
            if (index < list.Count)
            {
                list.RemoveAt(index);
                StreamWriter kiir = new StreamWriter(@"C:\Users\Rendszergazda\Documents\BACKEND\WCF_1\WCF_1_server\allomany.txt");
                kiir.WriteLine("Azon;EloadoName");
                foreach (var item in list)
                {

                    kiir.WriteLine(item.ToString());
                }
                kiir.Close();

                

                return "Sikeres Törlés";
            }
            else
            {
                return "Sikertelen Törlés";
            }

        }
      
        int GenerateId()
        {
            return EloadokLista().Select(eloado => eloado.EloadoAz).ToList().Max()+1;
        }
    }
}