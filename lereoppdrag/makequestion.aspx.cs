using System;
using System.Collections.Generic;
using System.Threading;
using System.Web.UI.WebControls;
using DataAccessLayer;

namespace lereoppdrag
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        private DBLayer _dbLayer = new DBLayer();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            ResetLabels();                     

            List<Label> wrongLabels = GetWrongLabels();
            if (wrongLabels.Count > 1)
            {
                foreach (var label in wrongLabels)
                {
                    label.Visible = true;
                }
                return;
            }

            List<Answer> answers = new List<Answer>()
            {
                new Answer { AnswerText = TextBox2.Text, IsRight = DropDownList1.SelectedValue == TextBox2.Text},
                new Answer { AnswerText = TextBox3.Text, IsRight = DropDownList1.SelectedValue == TextBox3.Text},
                new Answer { AnswerText = TextBox4.Text, IsRight = DropDownList1.SelectedValue == TextBox4.Text},
                new Answer { AnswerText = TextBox5.Text, IsRight = DropDownList1.SelectedValue == TextBox5.Text}
            };
            Question question = new Question()
            {
                Answers = answers,
                QuestionText = TextBox1.Text
            };

            _dbLayer.InsertQuestion(question);

            GridView1.DataSource = _dbLayer.GetAllQuestions();
            GridView1.DataBind();
            ResetBoxes();
        }
        private void ResetBoxes()
        {
            for (int i = 1; i <= 5; i++)
            {
                TextBox textbox = (TextBox)FindControl($"TextBox{i}");
                textbox.Text = "";
            }
        }

        private void ResetLabels()
        {
            LabelWrong1.Visible = false;
            LabelWrong2.Visible = false;
            LabelWrong3.Visible = false;
            LabelWrong4.Visible = false;
            LabelWrong5.Visible = false;
        }

        private List<Label> GetWrongLabels()
        {
            List<Label> wrongLabels = new List<Label>();

            for (int i = 1; i <= 5; i++)
            {
                TextBox textbox = (TextBox)FindControl($"TextBox{i}");
                if (string.IsNullOrEmpty(textbox.Text))
                {
                    var label = (Label)FindControl($"LabelWrong{i}");
                    wrongLabels.Add(label);
                }
            }
            return wrongLabels;
        }

        protected void Button1_Click(object sender, EventArgs e)        {

            GridView1.DataSource = _dbLayer.GetAllQuestions();
            GridView1.DataBind();
        }
    }
}