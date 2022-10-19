namespace Övningar
{
    internal class Class1
    {
        public void Go()
        {
         List<Student> students = new List<Student>();

            while (true)
            {
            Console.WriteLine("1. beräkna antal kursdagar, 2. Sätt betyg, 3. Hämta betyg, 4. KursInfo, 5. Lägg till kurs, 6. Lägg till student");
            string s = Console.ReadLine();
            switch(s)
                {
                case "1":
                    Console.WriteLine("Enter student name");
                    Student student4 = GetStudent(Console.ReadLine(), students);
                    Console.WriteLine("Enter CourseName");
                    Course kurs4 = student4.GetCourse(Console.ReadLine());
                    Console.WriteLine($"Kursen har {kurs4.CountDays()} kursdagar i sig");
                    break;

                case "2":
                    Console.WriteLine("Enter student name");
                    Student student2 = GetStudent(Console.ReadLine(), students);
                    Console.WriteLine("Enter CourseName that will get graded");
                    Course kurs = student2.GetCourse(Console.ReadLine());
                    Console.WriteLine("Enter grade to the course");
                    bool g = Betyg.TryParse(Console.ReadLine(), out Betyg h);
                    student2.SetGrades(kurs, h);

                    break;

                case "3":
                    foreach (Student student3 in students)
                    {
                        Console.WriteLine($"Namn: {student3.Name}");
                    }
                    Console.WriteLine("Enter student namn that you want to get grades from");
                    string name2 = Console.ReadLine();
                    foreach(Student stud in students)
                    {
                        if(stud.Name == name2)
                            stud.ShowGrades();
                    }
                    break;

                case "4":
                    foreach (Student p in students)
                    {
                        Console.WriteLine($"{p.Name}");
                        p.ShowGrades();
                    }
                    break;

                case "5":
                    Console.WriteLine("Enter lastname of student that will be assigned to the course");
                    Student st = GetStudent(Console.ReadLine(), students);
                    Console.WriteLine("Skriv in kursnamn");
                    string name = Console.ReadLine();
                    Console.WriteLine("Skriv in startDatum i åååå-mm-dd");
                    DateTime start = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Skriv in slutDatum i formatet åååå-mm-dd");
                    DateTime end = DateTime.Parse(Console.ReadLine());
                    st.ReturnGrades(new Course(3, name, start, end));  
                    break;

                case "6":
                    Student student = AddStudent();
                    students.Add(student);
                    foreach(Student p in students)
                    {
                        Console.WriteLine($"{p.Name}");
                            p.ShowGrades();
                    } 
                    break;
                }
            }
        }
        public Student AddStudent()
        {          
            Console.WriteLine("Enter firstName");
            string s = Console.ReadLine();
            Console.WriteLine("Ente lastName");
            string ls = Console.ReadLine();
            Console.WriteLine("Enter email");
            string mail = Console.ReadLine();
            Console.WriteLine("Enter tel"); 
            int tel = int.Parse(Console.ReadLine());
            Student student = new Student(s, mail, tel, ls);
            return student;
        }

        public Student GetStudent(string name, List<Student> list)
        {
            Student s = new Student("","",2,"");

            foreach(Student student in list)
                if (student.Name == name)
                    s = student;

            return s;
        }
    }
    public enum Betyg
    {
        Ig,
        G,
        Vg
    }
    public class Course
    {
        private string name;
        private int points;
        private DateTime start;
        private DateTime end;
        private Betyg grade;
        
        public string Name { get { return name; } set { name = value; } }
        public int Points { get { return points; } }
        public DateTime Start { get { return start; } set { start = value; } }
        public DateTime End { get { return end; } set { end = value; } }
        public Betyg Grade { get { return grade; } set { grade = value; } }

        public Course(int points, string name, DateTime start, DateTime end)
        {
            this.name = name;
            this.points = points;
            this.end = end;
            this.start = start;
        }

        public int CountDays()
        {
            var startDate = start;
            var workDays = 0;
            while(startDate <= end)
            {
                if (startDate.DayOfWeek != DayOfWeek.Sunday && startDate.DayOfWeek != DayOfWeek.Saturday)
                    workDays++;
                
                startDate = startDate.AddDays(1);
            }
            return workDays;
        }
    }
    public class Student 
    {
        private string name;
        private string lastName;
        private string email;
        private int tel;
        public Student(string name, string email, int tel, string lastName) 
        {
            this.name = name;
            this.email = email;
            this.tel = tel;
            this.lastName = lastName;
        }
        public string Name { get { return lastName; } }
        public List<Course> Courses = new List<Course>();   
        public void ReturnGrades(Course c)
        {
            Courses.Add(c); 
        }
        public void ShowGrades()
        {
            foreach (var c in Courses)
            {
                Console.WriteLine($"Kursnamn: {c.Name} Betyg: {c.Grade}");
            }
        }
        public Course GetCourse(string name)
        {
            Course course = new Course(3, "", DateTime.Now, DateTime.Now);

            foreach (Course c in Courses)
                if (name == c.Name)
                    course = c;
            
            return course;
        }
        public void SetGrades(Course c, Betyg b)
        {
            c.Grade = b;
        }

    }
   
}
