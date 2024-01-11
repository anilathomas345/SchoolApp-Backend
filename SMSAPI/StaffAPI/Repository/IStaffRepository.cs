using StaffAPI.Model;

namespace StaffAPI.Repository
{
    public interface IStaffRepository
    {
        void AddStaff(Staff staff);
        void UpdateStaff(Staff staff);
        void DeleteStaff(Staff staff);
        List<Staff> GetAll();
        List<Staff> GetStaffByStd(string std);
        List<Staff> GetStaffBySubject(string subject);
        Staff GetStaff(string staffId);
    }
}
