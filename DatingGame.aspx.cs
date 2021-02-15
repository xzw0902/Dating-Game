using DatingGame.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DatingGame
{
    public partial class DatingGame : System.Web.UI.Page
    {


        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                
            }
        }
        
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (DataListAnswer.lstAnswer == null)
            {
                DataListAnswer.lstAnswer = new List<DatingAnswers>();
            }
            DataListAnswer.lstAnswer.Add(new DatingAnswers()
            {
                answerTime = DateTime.Now,
                formDisplay = this.name.Text + " : " + this.questionR.Text,
                Name=this.name.Text,
                Question=this.questionR.Text
            });

            ListBox1.Items.Clear();
            ListBox1.DataSource = DataListAnswer.lstAnswer.Where(x=>x.Name==this.name.Text).ToList();
            ListBox1.DataTextField = "formDisplay";
            ListBox1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ListBox1.Items.Clear();
            ListBox1.Items.Clear();
            ListBox1.DataSource = DataListAnswer.lstAnswer;
            ListBox1.DataTextField = "formDisplay";
            ListBox1.DataBind();

        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // String  s = (String)ListBox1.SelectedItem;
            
            
            
           
            //ListBox1.Items.Clear();
           // ListBox1.Items.Add(temp);
            String s = ListBox1.Items[2].ToString();
            if (ListBox1.Items.Count.Equals(10))
                ListBox1.Items.RemoveAt(1);
            
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}