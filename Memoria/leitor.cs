using System.IO;
namespace Memoria
{
    public class leitor
    {
        public static int Count(){
            string path = @"/home/denis/Documentos/C#/Memoria/numbers";
            string[] lines = File.ReadAllLines(path);
            int count = 0;
            foreach (string line in lines){
                count++;
            }
            return count;
        }
        public static string[] itens(){
            string path = @"/home/denis/Documentos/C#/Memoria/numbers";
            string[] lines = File.ReadAllLines(path);
            return lines;
        }

        public static void write(string f){
            string path = @"/home/denis/Documentos/C#/Memoria/numbers";
            using (FileStream fr = new FileStream(path, FileMode.Append))
            {
                using (StreamWriter sw = new StreamWriter(fr))
                {
                    sw.WriteLine(f);
                }
                
            }
            
        }


    }
}