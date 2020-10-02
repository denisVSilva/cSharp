using System.IO;
using System;
namespace jogoDaForca.Entities
{
    public class Words
    {
        public string getWord(){
            string path = @"/home/denis/Documentos/C#/jogoDaForca/Save/Words";
            string[] lines = File.ReadAllLines(path);
            Random rand = new Random();
            int word = rand.Next(0, lines.Length);
            return lines[word]; 
        }

        public int save(){
            string path = @"/home/denis/Documentos/C#/jogoDaForca/Save/Wins";
            int num = 0;
            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines){
                if (int.Parse(line) > 0)
                {
                    num = int.Parse(line);
                }
            }
            using (FileStream ft = new FileStream(path, FileMode.Open))
            {
                using (StreamWriter sw = new StreamWriter(ft))
                {
                    sw.Write(num + 1);
                }
            }
            return num + 1;
        }
    }
}