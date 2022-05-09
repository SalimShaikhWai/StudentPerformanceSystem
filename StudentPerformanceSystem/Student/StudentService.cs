using StudentPerformanceSystem.DBClass;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPerformanceSystem.Students
{
    public  class StudentService
    {

        public SqlDataReader GetAllStudent()
        {
            DbConnection.GetConnection();
            DbConnection.GetStoreProcedure("student.GetAllStudentInf");
            return DbConnection.ExcecuteReader();
        }

        public SqlDataReader GetStudentByRollno(int? rollNo)
        {
            DbConnection.GetConnection();
            DbConnection.GetStoreProcedure("student.getStudentByRollno");
            DbConnection.AddInputParameter("rollNo", rollNo);
            return DbConnection.ExcecuteReader();
        }
        public string AddStudent(Student stud)
        {
            DbConnection.GetConnection();
            DbConnection.GetStoreProcedure("student.insertIntoStudent");
            DbConnection.AddInputParameter("student_name", stud.StudentName);
            DbConnection.AddInputParameter("student_email", stud.StudentEmail);
            DbConnection.AddInputParameter("student_address", stud.StudentAddress);
            DbConnection.AddInputParameter("course_code", stud.CourseCode);
            return DbConnection.ExcecuteNonQuery();

        }
        public string EditStudent(Student stud)
        {
            DbConnection.GetConnection();
            DbConnection.GetStoreProcedure("student.UpdateIntoStudent");
            DbConnection.AddInputParameter("student_rollNo", stud.StudentRollNo);
            DbConnection.AddInputParameter("student_name", stud.StudentName);
            DbConnection.AddInputParameter("student_email", stud.StudentEmail);
            DbConnection.AddInputParameter("student_address", stud.StudentAddress);
            DbConnection.AddInputParameter("course_code", stud.CourseCode);
            return DbConnection.ExcecuteNonQuery();
        }

        public void Delete(int studentId)
        {
            DbConnection.GetConnection();
            DbConnection.GetStoreProcedure("student.UpdatedStausOfStudent");
            DbConnection.AddInputParameter("rollNo", studentId);
            DbConnection.ExcecuteNonQuery();

        }



      

    }
}
