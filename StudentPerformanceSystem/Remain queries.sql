--insert into student.students values(
--		'vishal bhingardive','vishal@gmail.com','surat',2,1

--)
--insert into student.students values(
--		'vishal rajale','vishalraj@gmail.com','pune',2,1

--)
--insert into student.students values(
--		'adil shaikh','adilsh@gmail.com','Delhi',4,1

--)

--insert into student.students values(
--		'rahul pawar','rahul@gmail.com','ahmednagar',4,1

--)
--select *from marks.student_marks

--insert into marks.student_marks  values(
--	14,10,74
--)

--insert into marks.student_marks  values(
--	14,11,86
--)

--create procedure SubjectWiseMarks(
--@rollNo as int
--)
--as
--begin
--select ss.subject_title,sm.mark from marks.student_marks sm inner join SCcourse.subjects ss on sm.subject_id=ss.subject_id where sm.student_rollno=@rollNo
--end



--create procedure StudentReport
--as
--begin
--select s.student_rollNo, s.student_name,c.course_title,temp.TotalMarks from student.students s 
--inner join  SCcourse.course c on s.course_id=c.course_id 
--full join (select sum(mark) as TotalMarks,student_rollno from marks.student_marks group by student_rollno)temp on temp.student_rollno=s.student_rollNo order by s.student_rollNo
--end

--create procedure CourseWiseAvgSalary
--as
--begin
--select sc.course_title,avg(temp2.Totalmarks) Totalmarks from SCcourse.course sc inner join (
--select ss.course_id as CourseId,temp.Totalmarks from student.students ss inner join 
--		(select sum(sm.mark) as Totalmarks,sm.student_rollno from marks.student_marks sm group by sm.student_rollno)temp  on temp.student_rollno=ss.student_rollNo)temp2 
--		on temp2.CourseId=sc.course_id group by  sc.course_title
--end

--List course wise max marks

--create procedure CourseWiseAvgSalary
--as
--begin
--select sc.course_title,MAX(temp2.Totalmarks) MaxMarks from SCcourse.course sc inner join (
--select ss.course_id as CourseId,temp.Totalmarks from student.students ss inner join 
--		(select sum(sm.mark) as Totalmarks,sm.student_rollno from marks.student_marks sm group by sm.student_rollno)temp  on temp.student_rollno=ss.student_rollNo)temp2 
--		on temp2.CourseId=sc.course_id group by  sc.course_title
--end


--List course wise topper

--select sc.course_title,MAX(temp2.Totalmarks) MaxMarks from SCcourse.course sc inner join (
--select ss.course_id as CourseId,temp.Totalmarks from student.students ss inner join 
--		(select sum(sm.mark) as Totalmarks,sm.student_rollno from marks.student_marks sm group by sm.student_rollno)temp  on temp.student_rollno=ss.student_rollNo)temp2 
--		on temp2.CourseId=sc.course_id group by  sc.course_title

	

	
		select temp.Totalmarks,temp.student_rollno,ss.course_id from student.students ss 
					inner join
						(
							select sum(sm.mark) as Totalmarks,sm.student_rollno from marks.student_marks sm group by sm.student_rollno
						)temp 
			
		on temp.student_rollno=ss.student_rollNo 






		select temp.Totalmarks,temp.student_rollno,ss.course_id from student.students ss 
					inner join
						(
							select sum(sm.mark) as Totalmarks,sm.student_rollno from marks.student_marks sm group by sm.student_rollno
						)temp 
			
		on temp.student_rollno=ss.student_rollNo 


