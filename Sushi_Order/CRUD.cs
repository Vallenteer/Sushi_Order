using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql;
using MySql.Data;
using MySql.Web;
using MySql.Data.MySqlClient;

namespace Sushi_Order
{
   public class CRUD
    {
        public MySqlConnection connString = new MySqlConnection("Server=ap-cdbr-azure-east-c.cloudapp.net;" +
           "Port=3306;" +
           "Database=order_sushi;" +
           "User ID=bad630f558855e;" +
           "Password=ff040b65;" +
           "Pooling=true;Connection Lifetime=0");
        public CRUD()
        {

        }


        public void TestConnection()
        {
            try
            {
                connString.Open();
            }
            catch (Exception e)
            {
               // Console.WriteLine(e.Message);
            }
            if (connString.State.ToString() != "Open")
            {
                //Console.WriteLine("Koneksi ke database Gagal!", "Warning!");
                //Console.ReadLine();
                //Environment.Exit(0);               
                 
            }
            else
            {
                //Console.WriteLine("Koneksi ke database Berhasil!");
                //Console.WriteLine("Tekan enter untuk melanjutkan.....");
                //Console.ReadLine();
                connString.Close();
            }
        }

        public void tambahOrder(string nama,string pesanan,int jumlah, string tempat, string notlp)
        {
            int totalharga=1000;
            try
            {
                connString.Open();
            }
            catch (Exception e)
            {
                // Console.WriteLine(e.Message);
            }
            MySqlCommand sqlcomm;
            sqlcomm = connString.CreateCommand();
            sqlcomm.CommandText ="INSERT INTO `Order_sushi`.`order` (`nama_pemesan`, `pesanan`, `jumlah`,`totalharga`,`tempat`, `notlp`) VALUES(@nama_pemesan,@pesanan,@jumlah,@totalharga,@tempat,@notlp)";
            sqlcomm.Parameters.AddWithValue("@nama_pemesan", nama.Trim());
            sqlcomm.Parameters.AddWithValue("@pesanan", pesanan.Trim());
            sqlcomm.Parameters.AddWithValue("@jumlah", jumlah);
            sqlcomm.Parameters.AddWithValue("@totalharga", totalharga);
            sqlcomm.Parameters.AddWithValue("@tempat", tempat);
            sqlcomm.Parameters.AddWithValue("@notlp", notlp);
            try
            {
                sqlcomm.ExecuteNonQuery();
               
            }
            catch (Exception e)
            {
                //Console.WriteLine(e);
            }
            connString.Close();
            //Console.WriteLine("Tekan sembarang untuk kembali ke menu...");
            //Console.ReadKey();
            
        }
    }
}
