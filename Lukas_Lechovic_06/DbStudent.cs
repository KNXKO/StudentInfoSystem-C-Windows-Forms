using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lukas_Lechovic_06
{
    internal class DbStudent
    {
        public static MySqlConnection GetConnection()
        {
            string sql = "datasource=localhost;port=3306;username=root;password=;database=student";
            MySqlConnection con = new MySqlConnection(sql);
            try
            {
                con.Open();
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("MySQL connection! \n" + ex.Message,  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return con;
        }
        public static void AddStudent(Student std)
        {
            string sql = "INSERT INTO student_info VALUES (NULL, @StudentMeno, @StudentPriezvisko,@StudentNarodenie,@StudentEmail,@StudentTelefon,@StudentBydlisko,@StudentPsc)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@StudentMeno", MySqlDbType.VarChar).Value = std.Meno;
            cmd.Parameters.Add("@StudentPriezvisko", MySqlDbType.VarChar).Value = std.Priezvisko;
            cmd.Parameters.Add("@StudentNarodenie", MySqlDbType.Date).Value = std.Datum_narodenia;
            cmd.Parameters.Add("@StudentEmail", MySqlDbType.VarChar).Value = std.Email;
            cmd.Parameters.Add("@StudentTelefon", MySqlDbType.VarChar).Value = std.Telefon;
            cmd.Parameters.Add("@StudentBydlisko", MySqlDbType.VarChar).Value = std.Bydlisko;
            cmd.Parameters.Add("@StudentPsc", MySqlDbType.VarChar).Value = std.PSC;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Študent je úspešne pridaný.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Študenta sa nepodarilo pridať.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        public static void UpdateStudent(Student std, string id)
        {
            string sql = "UPDATE student_info SET Meno = @StudentMeno, Priezvisko = @StudentPriezvisko, Datum_narodenia = @StudentNarodenie, Email = @StudentEmail, Telefon = @StudentTelefon, Bydlisko = @StudentBydlisko, PSC = @StudentPsc WHERE ID = @StudentID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@StudentID", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@StudentMeno", MySqlDbType.VarChar).Value = std.Meno;
            cmd.Parameters.Add("@StudentPriezvisko", MySqlDbType.VarChar).Value = std.Priezvisko;
            cmd.Parameters.Add("@StudentNarodenie", MySqlDbType.Date).Value = std.Datum_narodenia;
            cmd.Parameters.Add("@StudentEmail", MySqlDbType.VarChar).Value = std.Email;
            cmd.Parameters.Add("@StudentTelefon", MySqlDbType.VarChar).Value = std.Telefon;
            cmd.Parameters.Add("@StudentBydlisko", MySqlDbType.VarChar).Value = std.Bydlisko;
            cmd.Parameters.Add("@StudentPsc", MySqlDbType.VarChar).Value = std.PSC;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Údaje sa úspešne aktualizovali.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Údaje sa neaktualizovali.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void DeleteStudent(string id)
        {
            string sql = "DELETE FROM student_info WHERE ID = @StudentID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@StudentID", MySqlDbType.VarChar).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Študent je úspešne vymazaní.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Študenta sa nepodarilo vymazať.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        public static void DisplayAndSearch(string query, DataGridView dgv)
        {
            string sql = query;
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adapter.Fill(tbl);
            dgv.DataSource = tbl;
            con.Close();

        }
    }
}
