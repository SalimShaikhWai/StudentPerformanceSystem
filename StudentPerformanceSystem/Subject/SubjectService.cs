using StudentPerformanceSystem.DBClass;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPerformanceSystem.Subject
{
    public class SubjectService
    {
        public SqlDataReader GetAllSubjects()
        {
            DbConnection.GetConnection();
            DbConnection.GetStoreProcedure("SCcourse.GetAllSubjects");
            return DbConnection.ExcecuteReader();
        }


        public string AddSubject(Subject sub)
        {
            DbConnection.GetConnection();
            DbConnection.GetStoreProcedure("SCcourse.insertIntoSubjects");
            DbConnection.AddInputParameter("subject_code", sub.SubjectCode);
            DbConnection.AddInputParameter("subject_title", sub.SubjectTitle);
            DbConnection.AddInputParameter("subject_desc", sub.SubjectDescription);
            DbConnection.AddInputParameter("course_code",sub.CourseCode);
            return DbConnection.ExcecuteNonQuery();
           
        }
        public string EditSubject(Subject sub)
        {
            DbConnection.GetConnection();
            DbConnection.GetStoreProcedure("SCcourse.updatedSubject");
            DbConnection.AddInputParameter("subject_id",sub.SubjectId);
            DbConnection.AddInputParameter("subject_code", sub.SubjectCode);
            DbConnection.AddInputParameter("subject_title", sub.SubjectTitle);
            DbConnection.AddInputParameter("subject_desc", sub.SubjectDescription);
            DbConnection.AddInputParameter("course_code", sub.CourseCode);
            return DbConnection.ExcecuteNonQuery();
        }
        public void Delete(int subjectId)
        {
            DbConnection.GetConnection();
            DbConnection.GetStoreProcedure("SCcourse.UpdatedStausSubject");
            DbConnection.AddInputParameter("subjectId", subjectId);
            DbConnection.ExcecuteNonQuery();

        }
        public SqlDataReader GetSubjectBySubjectCode(string? subjectCode)
        {
            DbConnection.GetConnection();
            DbConnection.GetStoreProcedure("SCcourse.getSubjectBySubjectCode");
            DbConnection.AddInputParameter("subject_code", subjectCode);
            return DbConnection.ExcecuteReader();
        }
    }
}
