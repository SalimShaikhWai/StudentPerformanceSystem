using StudentPerformanceSystem.DBClass;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPerformanceSystem.Student
{
    public  class StudentService
    {

        public SqlDataReader GetAllStudent()
        {
            DbConnection.getConnection();
            DbConnection.GetStoreProcedure("student.GetAllStudentInf");
            return DbConnection.ExcecuteReader();
        }

        public SqlDataReader GetStudentByRollno(int? rollNo)
        {
            DbConnection.getConnection();
            DbConnection.GetStoreProcedure("student.getStudentByRollno");
            DbConnection.AddInputParameter("rollNo", rollNo);
            return DbConnection.ExcecuteReader();
        }
        public string AddStudent(Student stud)
        {
            DbConnection.getConnection();
            DbConnection.GetStoreProcedure("student.insertIntoStudent");
            DbConnection.AddInputParameter("student_name", stud.StudentName);
            DbConnection.AddInputParameter("student_email", stud.StudentEmail);
            DbConnection.AddInputParameter("student_address", stud.StudentAddress);
            DbConnection.AddInputParameter("course_code", stud.CourseCode);
            return DbConnection.ExcecuteNonQuery();

        }
        public string EditStudent(Student stud)
        {
            DbConnection.getConnection();
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
            DbConnection.getConnection();
            DbConnection.GetStoreProcedure("student.UpdatedStausOfStudent");
            DbConnection.AddInputParameter("rollNo", studentId);
            DbConnection.ExcecuteNonQuery();

        }

    }
}
