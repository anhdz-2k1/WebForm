using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GoldClub.Model;


namespace GoldClub.DAL
{
    public class ClubMemberDbManager
    {
        public Member CreateMember(Member memberModel)
        {
            using (var dbEnties = new GolfClubContext())
            {
                var MemberObj = new Member()
                {
                    Name = memberModel.Name,
                    Gender = memberModel.Gender,
                    MemberFree = memberModel.MemberFree
                };
                dbEnties.Members.Add(MemberObj);
                dbEnties.SaveChanges();
            }
                return memberModel;
        }
    }
}