using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salvataggio_e_accesso_con_user_e_pwd
{
    public class GestioneFile
    {
        public void scrivi_fileDiTesto(string testo, string dirName, string fileName, string estensioneFile)
        {
            StreamWriter sw = null;
            string pathfile = dirName + @"\" + fileName + "." + estensioneFile;
            try
            {
                sw = File.CreateText(pathfile);
                sw.WriteLine(testo);
                sw.Close();
            }
            catch (System.IO.DirectoryNotFoundException)  //Eccezione specializzata perchè intercetto precisamente l'errore e spiego all'utente come rimediare. (è necessario comunicare all'utente quali azioni compiere per utilizzare il programma o per comunicare l'errore in modo comprensibile)
            {
                MessageBox.Show("Directory non trovata", "ERRORE");

            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("Il file non può essere scritto perchè è utilizzato da un altro processo", "ATTENZIONE");
            }
            catch (Exception ex)  // Gestione di eccezione generica dove nell'avviso appare un messaggio generico di errore creato dal compilatore stesso
            {
                MessageBox.Show(ex.Message, "ATTENZIONE");
            }
        }
        public string leggi_fileDiTesto(string fileName, string estenzioneFile, string dirName)
        {
            string pathfile = Directory.GetCurrentDirectory() + @"\" + fileName + "." + estenzioneFile;
            StreamReader sr = new StreamReader(pathfile);
            return sr.ReadToEnd();
        }
    }
}
