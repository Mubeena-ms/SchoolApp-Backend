using HandsOnWeek2Assessment.Model;
using static System.Reflection.Metadata.BlobBuilder;
using System.Net;

namespace HandsOnWeek2Assessment.Repository
{
    public class StudentRepository : IStudentRepository
    {
        public List<Student> students=new List<Student>();
        public void AddStudent(Student student)
        {
            try
            {
                students.Add(student);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeleteStudent(int studentId)
        {
            try
            {
                foreach (var item in students)
                {
                    if (item.studentId == studentId)
                    {
                        students.Remove(item);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Student GetStudentById(int studentId)
        {
            try
            {
                foreach (var item in students)
                {
                    if (item.studentId == studentId)
                        return item;
                }
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Student> GetStudentBySkill(string skill)
        {
            try
            {
                List<Student> list = new List<Student>();   
                foreach (var item in students)
                {
                    if (item.skill == skill)
                        list.Add(item);
                }
                return list;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Student> GetStudntByQualification(string qualification)
        {
            try
            {
                List<Student> list = new List<Student>();
                foreach (var item in students)
                {
                    if (item.qualification == qualification)
                        list.Add(item);
                }
                return list;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void UpdateStudent(Student student)
        {
            try
            {
                foreach (var item in students)
                {
                    if (item.studentId==student.studentId)
                    {
                        item.skill=student.skill;
                        item.qualification=student.qualification;
                        break;
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}






