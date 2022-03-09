using SchoolProject.Models;

namespace SchoolProject.Repository
{
    public interface IRoomRepository
    {
        public List<Room> GetAllRooms();
        public void Create(Room rooms);
        public void Delete(int id);
    }
}
