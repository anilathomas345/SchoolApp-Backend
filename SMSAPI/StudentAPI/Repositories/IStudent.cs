using StudentAPI.Model;

namespace StudentAPI.Repositories
{
    public interface IStudent
    {
        void AddStudent(Student student);
        void UpdateStudent(Student student);    
        void DeleteStudent(int id);
        Student GetStudent(int id);
        List<Student> GetAllStudents(string std);
        List<Student> GetAllStudents(string std,string section);
        List<Student> GetAll();
    }
}
