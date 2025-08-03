using SimpleLibraryManagement_LayeredArchitectureAndRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLibraryManagement_LayeredArchitectureAndRepository.Repositories
{
    class MemberRepository
    {
        public void AddMember(Member member)
        {
            var members = GetAllMembers();
            members.Add(member);
            FileContext.SaveMember(members);
        }

        public Member GetMember(int id)
        {
            return GetAllMembers().FirstOrDefault(m => m.Id == id);
        }

        public List<Member> GetAllMembers()
        {
            return FileContext.LoadMember();
        }

        public void UpdateMember(Member member)
        {
            var members = GetAllMembers();
            var index = members.FindIndex(m => m.Id == member.Id);
            if (index != -1)
            {
                members[index] = member;
                FileContext.SaveMember(members);
            }
        }

        public void DeleteMember(int id)
        {
            var members = GetAllMembers();
            var memberToRemove = members.FirstOrDefault(m => m.Id == id);
            if (memberToRemove != null)
            {
                members.Remove(memberToRemove);
                FileContext.SaveMember(members);
            }
        }

        }
}
