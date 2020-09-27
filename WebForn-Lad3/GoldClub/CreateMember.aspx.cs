using GoldClub.DAL;
using GoldClub.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GoldClub
{
    public partial class CreateMember : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSumbit_Click(object sender, EventArgs e)
        {
            ClubMemberDbManager objclubMemberDbManager = new ClubMemberDbManager();
            Member memberModel = new Member();
            memberModel.Name = txtName.Text;
            memberModel.Gender = drpGender.SelectedItem.Text;
            memberModel.MemberFree = Convert.ToDouble(txtfees.Text);
            memberModel = objclubMemberDbManager.CreateMember(memberModel);
            IblMessage.Text = "Member created Successfully";

        }
    }
}