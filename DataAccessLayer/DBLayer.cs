using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DataAccessLayer
{
    public class DBLayer
    {

        public void RegisterUser(string username, string password, string email)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["ConKurs"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlParameter param;
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO User (UserName, Password, Email) " + "VALUES (@UserName,@Password,@Email)", conn);
                cmd.CommandType = CommandType.Text;

                param = new SqlParameter("@UserName", SqlDbType.NVarChar);
                param.Value = username;
                cmd.Parameters.Add(param);

                param = new SqlParameter("@Password", SqlDbType.NVarChar);
                param.Value = password;
                cmd.Parameters.Add(param);

                param = new SqlParameter("@Email", SqlDbType.NVarChar);
                param.Value = email;
                cmd.Parameters.Add(param);

                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
        public void InsertAnswer(string AnswerValue, string Username, string question)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["ConKurs"].ConnectionString;

            int userId = GetIdByUsername(username: Username);
            int qId = GetIdByQuestion(question_Database: question);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlParameter param;
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO CAN (UID,QID,Answer) " + "VALUES (@UID,@QID,@Answer)", conn);
                cmd.CommandType = CommandType.Text;

                param = new SqlParameter("@UID", SqlDbType.NVarChar);
                param.Value = userId;
                cmd.Parameters.Add(param);

                param = new SqlParameter("@QID", SqlDbType.NVarChar);
                param.Value = qId;
                cmd.Parameters.Add(param);

                param = new SqlParameter("@Answer", SqlDbType.NVarChar);
                param.Value = AnswerValue;
                cmd.Parameters.Add(param);

                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
        public void InsertQuestion(Question question)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["ConKurs"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlParameter param;
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO question (question, A1, A2, A3, A4, CA) " + "VALUES (@Question,@A1,@A2,@A3,@A4,@CA)", conn);
                cmd.CommandType = CommandType.Text;

                Answer correctAnswer = question.Answers.FirstOrDefault(answer => answer.IsRight);
                if (correctAnswer == null)
                    correctAnswer = question.Answers[0];

                param = new SqlParameter("@Question", SqlDbType.NVarChar);
                param.Value = question.QuestionText;//henter rett fra textboxen din
                cmd.Parameters.Add(param);

                param = new SqlParameter("@A1", SqlDbType.NVarChar);
                param.Value = question.Answers[0].AnswerText;//henter rett fra textboxen din
                cmd.Parameters.Add(param);

                param = new SqlParameter("@A2", SqlDbType.NVarChar);
                param.Value = question.Answers[1].AnswerText;//henter rett fra textboxen din
                cmd.Parameters.Add(param);

                param = new SqlParameter("@A3", SqlDbType.NVarChar);
                param.Value = question.Answers[2].AnswerText;//henter rett fra textboxen din
                cmd.Parameters.Add(param);

                param = new SqlParameter("@A4", SqlDbType.NVarChar);
                param.Value = question.Answers[3].AnswerText;//henter rett fra textboxen din
                cmd.Parameters.Add(param);

                param = new SqlParameter("@CA", SqlDbType.NVarChar);
                param.Value = correctAnswer.AnswerText;//henter rett fra textboxen din
                cmd.Parameters.Add(param);

                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public List<GetQuestion> GetAllQuestions()
        {
            GetQuestion getQuestion = new GetQuestion();

            List<GetQuestion> GridInfo = new List<GetQuestion>();
            var connectionString = ConfigurationManager.ConnectionStrings["ConKurs"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM question", conn);
            cmd.CommandType = CommandType.Text;

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                GetQuestion temp = new GetQuestion();
                temp.QID = (int)reader["QID"];
                temp.Question = (string)reader["Question"];
                temp.AnswerA = (string)reader["A1"];
                temp.AnswerB = (string)reader["A2"];
                temp.AnswerC = (string)reader["A3"];
                temp.AnswerD = (string)reader["A4"];
                temp.CorrectAnswer = (string)reader["CA"];

                GridInfo.Add(temp);
            }
            reader.Close();
            return GridInfo;
        }

        public int GetIdByUsername(string username)
        {
            int id = 0;

            SqlParameter param;
            var connectionString = ConfigurationManager.ConnectionStrings["ConKurs"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT uid FROM [user] WHERE username=@username", conn);
            cmd.CommandType = CommandType.Text;

            param = new SqlParameter("@username", SqlDbType.NVarChar);
            param.Value = username;//henter rett fra textboxen din
            cmd.Parameters.Add(param);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                id = (int)reader["uid"];
            }
            reader.Close();
            return id;
        }

        public int GetIdByQuestion(string question_Database)
        {
            int id = 0;

            SqlParameter param;
            var connectionString = ConfigurationManager.ConnectionStrings["ConKurs"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT qid FROM question WHERE question=@question", conn);
            cmd.CommandType = CommandType.Text;

            param = new SqlParameter("@question", SqlDbType.NVarChar);
            param.Value = question_Database;//henter rett fra textboxen din
            cmd.Parameters.Add(param);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                id = (int)reader["qid"];
            }
            reader.Close();
            return id;
        }

        public void InsertHelp(string EmailHelp, string HelpText)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["ConKurs"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlParameter param;
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO HelpText (Email, Helptext) " + "VALUES (@Email, @HelpText)", conn);
                cmd.CommandType = CommandType.Text;


                param = new SqlParameter("@Email", SqlDbType.NVarChar);
                param.Value = EmailHelp;//henter rett fra textboxen din
                cmd.Parameters.Add(param);

                param = new SqlParameter("@HelpText", SqlDbType.NVarChar);
                param.Value = HelpText;//henter rett fra textboxen din
                cmd.Parameters.Add(param);

                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public int GetUserAndPassword(string userName, string passWord)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["ConKurs"].ConnectionString;
            SqlParameter param;
            int count = 0;//either 0 or 1. 1 if user exists
            string sqlCmd = "";

            sqlCmd = "SELECT COUNT(uid)AS num FROM [user] WHERE username=@un and password=@pw";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlCmd, conn);
                cmd.CommandType = CommandType.Text;

                param = new SqlParameter("@un", SqlDbType.NVarChar);
                param.Value = userName;
                cmd.Parameters.Add(param);

                param = new SqlParameter("@pw", SqlDbType.NVarChar);
                param.Value = passWord;
                cmd.Parameters.Add(param);

                count = (int)cmd.ExecuteScalar();
                conn.Close();
                return count;
            }
        }
        public void UserRegister(string userName, string passWord, string email)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["ConKurs"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlParameter param;
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO user (UserName, Password, Email) " + "VALUES (@UN, @PW, @Email)", conn);
                cmd.CommandType = CommandType.Text;

                param = new SqlParameter("@UN", SqlDbType.NVarChar);
                param.Value = userName;//henter rett fra textboxen din
                cmd.Parameters.Add(param);

                param = new SqlParameter("@PW", SqlDbType.NVarChar);
                param.Value = passWord;//henter rett fra textboxen din
                cmd.Parameters.Add(param);

                param = new SqlParameter("@Email", SqlDbType.NVarChar);
                param.Value = email;//henter rett fra textboxen din
                cmd.Parameters.Add(param);


                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}