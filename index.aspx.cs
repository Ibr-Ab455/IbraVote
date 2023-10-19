using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IbraVote
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //en label per parti
            LabelHoyre.Text = GetVotesHoyre().ToString();
            LabelArbeider.Text = GetVotesAp().ToString();
            LabelVenestre.Text = GetVotesVenstre().ToString();
            LabelPp.Text = GetVotesPp().ToString();

            //seksjon prosent
            int totaltStemmer = GetTotalVotes();
            int stemmerHoyre = GetVotesHoyre();
            double prosenthloyre = ((double)stemmerHoyre / totaltStemmer) * 100;
            LabelHyre.Text = prosenthloyre.ToString();

            int totalStemmer = GetTotalVotes();
            int stemmerArp = GetVotesAp();
            double prosentArp = ((double)stemmerArp / totalStemmer) * 100;
            LabelArb.Text = prosentArp.ToString();

            int totaStemmer = GetTotalVotes();
            int stemmerVen = GetVotesVenstre();
            double prosentVene = ((double)stemmerVen / totaStemmer) * 100;
            LabelVen.Text = prosentVene.ToString();

            int totStemmer = GetTotalVotes();
            int stemmerpp = GetVotesPp();
            double prosentpp = ((double)stemmerpp / totStemmer) * 100;
            Labelp.Text = prosentpp.ToString();
        }

        private void InsertVote()
        {
            //insert stemme til db
            DataTable dt = new DataTable();
            SqlParameter param;
            var connectionString = ConfigurationManager.ConnectionStrings["Valg"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO Stemme (Pid, Kid) VALUES (@partiId, 1)", conn);
                cmd.CommandType = CommandType.Text;

                param = new SqlParameter("@partiId", SqlDbType.Int);
                param.Value = DropDownListParti.SelectedItem.Value;
                cmd.Parameters.Add(param);


                cmd.ExecuteNonQuery();

                conn.Close();
            }
        }

        protected void ButtonVote_Click(object sender, EventArgs e)
        {
            InsertVote();
        }

        private void InsetVote()
        {
            //insert stemme til db
            DataTable dt = new DataTable();
            SqlParameter param;
            var connectionString = ConfigurationManager.ConnectionStrings["Valg"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO Stemme (Pid, Kid) VALUES (@partiId, 2)", conn);
                cmd.CommandType = CommandType.Text;

                param = new SqlParameter("@partiId", SqlDbType.Int);
                param.Value = DropDownListParti.SelectedItem.Value;
                cmd.Parameters.Add(param);


                cmd.ExecuteNonQuery();

                conn.Close();
            }
        }

        protected void ButtonVo_Click(object sender, EventArgs e)
        {
            InsetVote();
        }

        //hente ut antallstemmer for hæyre 
        private int GetVotesHoyre()
        {
            int stemmer = 0;
            DataTable dt = new DataTable();
            SqlParameter param;
            var connectionString = ConfigurationManager.ConnectionStrings["Valg"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("select count(sid) as antallstemmer from stemme where pid=1", conn);
                cmd.CommandType = CommandType.Text;

                SqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);

                conn.Close();
            }
            foreach (DataRow row in dt.Rows)
            {
                stemmer = (int)row["antallStemmer"];//hente ut verdier

            }
            return stemmer;
        }

        //hente ut antallstemmer for Ap
        private int GetVotesAp()
        {
            int stemmer = 0;
            DataTable dt = new DataTable();
            SqlParameter param;
            var connectionString = ConfigurationManager.ConnectionStrings["Valg"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("select count(sid) as antallstemmer from stemme where pid=2", conn);
                cmd.CommandType = CommandType.Text;

                SqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);

                conn.Close();
            }
            foreach (DataRow row in dt.Rows)
            {
                stemmer = (int)row["antallStemmer"];//hente ut verdier

            }
            return stemmer;
        }

        //hente ut antallstemmer for Venestre
        private int GetVotesVenstre()
        {
            int stemmer = 0;
            DataTable dt = new DataTable();
            SqlParameter param;
            var connectionString = ConfigurationManager.ConnectionStrings["Valg"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("select count(sid) as antallstemmer from stemme where pid=3", conn);
                cmd.CommandType = CommandType.Text;

                SqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);

                conn.Close();
            }
            foreach (DataRow row in dt.Rows)
            {
                stemmer = (int)row["antallStemmer"];//hente ut verdier

            }
            return stemmer;
        }

        //hente ut antallstemmer for Pp
        private int GetVotesPp()
        {
            int stemmer = 0;
            DataTable dt = new DataTable();
            SqlParameter param;
            var connectionString = ConfigurationManager.ConnectionStrings["Valg"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("select count(sid) as antallstemmer from stemme where pid=4", conn);
                cmd.CommandType = CommandType.Text;

                SqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);

                conn.Close();
            }
            foreach (DataRow row in dt.Rows)
            {
                stemmer = (int)row["antallStemmer"];//hente ut verdier

            }
            return stemmer;
        }

        private int GetTotalVotes()
        {
            int stemmer = 0;
            DataTable dt = new DataTable();
            SqlParameter param;
            var connectionString = ConfigurationManager.ConnectionStrings["Valg"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("select count(*) as antallstemmer from stemme", conn);
                cmd.CommandType = CommandType.Text;

                SqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);

                conn.Close();
            }
            foreach (DataRow row in dt.Rows)
            {
                stemmer = (int)row["antallStemmer"];//hente ut verdier

            }
            return stemmer;
        }
    }
}