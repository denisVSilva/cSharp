using MySql.Data.MySqlClient;
using System;
namespace popQuiz.Entities
{
    public class quiz
    {
        public string[] getQuiz(){
            string[] quiz = new string[2];
            Random num = new Random();
            var connstr = "CHANGED FOR REASONS";
            var conn = new MySqlConnection(connstr);
            var comm = conn.CreateCommand();
            conn.Open();
            var db = "SELECT * FROM quiz";
            var coma = new MySqlCommand(db,conn);
            MySqlDataReader rdr = coma.ExecuteReader();
            int ids = 0;
            while(rdr.Read()){
                 if(rdr.GetInt32("id") > ids){
                    ids = Convert.ToInt16(rdr.GetInt32("id"));
                }
                int numb = num.Next(1, ids + 1);
                if(rdr.GetInt32("id") == numb){
                    quiz[0] = rdr.GetString("ans");
                    quiz[1] =  rdr.GetString("question");
                }
            }
            conn.Close();
            return quiz;
        }
        public void createQuiz(){
            System.Console.WriteLine("give the answear for the question");
            string ans = Console.ReadLine();
            System.Console.WriteLine("give the question for the answear");
            string quest = Console.ReadLine();
            var connstr = "CHANGED FOR REASONS";
            var conn = new MySqlConnection(connstr);
            var comm = conn.CreateCommand();
            conn.Open();
            var db = "SELECT * FROM quiz";
            var coma = new MySqlCommand(db,conn);
            comm.CommandText = "INSERT INTO quiz(id,ans,question) VALUES('0','"+ans+"','"+quest+"')";
            comm.ExecuteNonQuery();
            conn.Close();
        }
        public void changeQuestion(){
            string ans = "";
            System.Console.WriteLine("give the answear for the one you want changed");
            string valor = Console.ReadLine();
            System.Console.WriteLine("Edit or delete");
            string op = Console.ReadLine().ToUpper();
            if (op == "EDIT") {
            System.Console.WriteLine("Do you want to change Answear or Question");
            ans = Console.ReadLine().ToUpper();
            }     
            var connstr = "CHANGED FOR REASONS";
            var conn = new MySqlConnection(connstr);
            var comm = conn.CreateCommand();
            conn.Open();
            var db = "SELECT * FROM quiz";
            var coma = new MySqlCommand(db,conn);
                
            if (op == "EDIT"){
                if (ans == "ANSWEAR"){
                    System.Console.WriteLine("new answear");
                    string nans = Console.ReadLine();
                    comm.CommandText = "UPDATE quiz SET ans = '"+nans+"' WHERE ans = '" + valor + "'";
                    comm.ExecuteNonQuery();
                } else if (ans == "QUESTION"){
                    System.Console.WriteLine("new question");
                    string nans = Console.ReadLine();
                    comm.CommandText = "UPDATE quiz SET question = '"+nans+"' WHERE ans = '" + valor + "'";
                    comm.ExecuteNonQuery();
                }
            } else if (op == "DELETE"){
                comm.CommandText = "DELETE FROM quiz WHERE ans = '" + valor + "'";
                comm.ExecuteNonQuery();
            }
            conn.Close();

        }
    }
}