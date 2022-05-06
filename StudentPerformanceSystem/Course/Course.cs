
// See https://aka.ms/new-console-template for more information

namespace StudentPerformanceSystem.Course { 

class Course
{
    private int course_id;
    private string course_code;
    private string course_title;
    private string course_description;
    public Course()
    {

    }
    public Course(string course_code,string course_title,string course_desc)
    {
        this.Course_code = course_code;
        this.Course_title=course_title;
        this.Course_description=course_desc;
    }

        public int Course_id { get => course_id; set => course_id = value; }
        public string Course_code { get => course_code; set => course_code = value; }
        public string Course_title { get => course_title; set => course_title = value; }
        public string Course_description { get => course_description; set => course_description = value; }
    }
    }



