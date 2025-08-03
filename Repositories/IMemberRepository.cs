using SimpleLibraryManagement_LayeredArchitectureAndRepository.Models;

namespace SimpleLibraryManagement_LayeredArchitectureAndRepository.Repositories
{
    internal interface IMemberRepository
    {
        void AddMember(Member member);
        void DeleteMember(int id);
        List<Member> GetAllMembers();
        Member GetMember(int id);
        void UpdateMember(Member member);
    }
}