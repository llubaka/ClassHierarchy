using ClassHierarchy.Models;

namespace ClassHierarchy.Contracts
{
    public interface IChild
    {
        bool HasRelationship { get; set; }

        void PlayWithSomeone(Human human);
    }
}
