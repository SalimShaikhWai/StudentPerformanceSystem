using StudentPerformanceSystem.DBClass;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPerformanceSystem.Marks
{
    public  class MarkManagement
    {
        public string AddMarks(Mark mark)
        {
            DbConnection.GetConnection();
            DbConnection.GetStoreProcedure("marks.insertIntoMarks");
            DbConnection.AddInputParameter("student_rollNo", mark.StudentRollNo);
            DbConnection.AddInputParameter("subject_code", mark.SubjectCode);
            DbConnection.AddInputParameter("marks", mark.Marks);

            return DbConnection.ExcecuteNonQuery();

        }


        public SqlDataReader GetmMarksByRollno(int?rollNo)
        {
            DbConnection.GetConnection();
            DbConnection.GetStoreProcedure("marks.getMarksByRollno");
            DbConnection.AddInputParameter("rollNo",rollNo);
            return DbConnection.ExcecuteReader();
        }

    }
}
