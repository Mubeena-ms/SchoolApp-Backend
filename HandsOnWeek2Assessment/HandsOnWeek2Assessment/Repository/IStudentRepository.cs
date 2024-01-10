using HandsOnWeek2Assessment.Model;

namespace HandsOnWeek2Assessment.Repository
{
    public interface IStudentRepository
    {
        void AddStudent(Student student);
        List<Student> GetStudntByQualification(string qualification);
        List<Student> GetStudentBySkill(string skill);
        Student GetStudentById(int studentId);
        void UpdateStudent(Student student);
        void DeleteStudent(int studentId);

    }
}
