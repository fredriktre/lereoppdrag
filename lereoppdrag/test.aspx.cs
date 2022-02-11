using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;

namespace lereoppdrag
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        DBLayer dbLayer = new DBLayer();
        List<GetQuestion> _shuffledQuestions = new List<GetQuestion>();
        static int _currentQuestion;
        protected void Page_Load(object sender, EventArgs e)
        {
            var questions = dbLayer.GetAllQuestions();
            _shuffledQuestions = Shuffle(questions);
        }

        /*private void RandomQuestion(int RandQuest)
        {
            Random rand = new Random();
            List<int> questions = dbLayer.GetAllQIDs();
            int chosenQid = rand.Next(questions.Count);

            List<int> shuffledItems = Shuffle<int>(questions);
        }*/

        private List<T> Shuffle<T>(List<T> items)
        {
            Random ran = new Random();
            List<T> output = new List<T>();

            while (items.Count > 0)
            {
                int ranNum = ran.Next(0, items.Count);
                output.Add(items[ranNum]);
                items.RemoveAt(ranNum);
            }

            return output;
        }

        private void StartTest()
        {
            string question1 = _shuffledQuestions[0].Question;
            string answerA = _shuffledQuestions[0].AnswerA;
            string answerB = _shuffledQuestions[0].AnswerB;
            string answerC = _shuffledQuestions[0].AnswerC;
            string answerD = _shuffledQuestions[0].AnswerD;

            QuestionTextDiv.Visible = true;
            TestTable.Visible = true;
            AnswerList.Visible = true;
            wrapper_ButtonStartTest.Visible = false;

            QuestionText.Text = question1;
            Ans1.Text = answerA;
            Ans2.Text = answerB;
            Ans3.Text = answerC;
            Ans4.Text = answerD;

            _currentQuestion = 1;
        }

        protected void Button_StartTest_Click(object sender, EventArgs e)
        {
            StartTest();
        }

        public void ButtonFortsett_Click(object sender, EventArgs e)
        {
            string questionNow = _shuffledQuestions[_currentQuestion].Question;
            string answerA = _shuffledQuestions[_currentQuestion].AnswerA;
            string answerB = _shuffledQuestions[_currentQuestion].AnswerB;
            string answerC = _shuffledQuestions[_currentQuestion].AnswerC;
            string answerD = _shuffledQuestions[_currentQuestion].AnswerD;

            string userName=User.Identity.Name;
            //string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            string answervalue = DropDownList1.SelectedValue;
            dbLayer.InsertAnswer(answervalue, userName, questionNow);

            if (_currentQuestion > _shuffledQuestions.Count - 1)
            {
                QuestionTextDiv.Visible = false;
                TestTable.Visible = false;
                AnswerList.Visible = false;
                wrapper_ButtonStartTest.Visible = true;
                Label_Finished.Visible = true;

                return;
            }           

            

            QuestionText.Text = questionNow;
            Ans1.Text = answerA;
            Ans2.Text = answerB;
            Ans3.Text = answerC;
            Ans4.Text = answerD;

            

            _currentQuestion++; 
        }
    }
}