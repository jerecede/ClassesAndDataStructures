using System.Collections;

namespace ClassesAndDataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("pippo", "de pippis", "male", 2000);
            Student student2 = new Student("paperoga", "de paperoni", 2000);
            Student student3 = new("paperino", "de paperoni", 2000);
            Student student4 = new("topolino", "mouse", 2000);

            Teacher teacher1 = new Teacher { Name = "pico", Surname = "de pippis", Subject = "math" };
            Teacher teacher2 = new Teacher { Name = "archimede", Surname = "pitagorico" };
            Teacher teacher3 = new Teacher { Name = "zapotec" }; //name è required, il resto diventa null

            Student[] students = new Student[3]; //statico
            students[0] = student1;
            //Student[] newArray = (Student[])students.Append(student2); //c'è un errore che non capisco
            students[2] = student3;
            Student[] newArray2 = AppendToStudentsArray(students, student4);

            ArrayList studentArrayList = new ArrayList(); //come in js, e puoi pushare qualsiasi type, casino
            studentArrayList.Add(student1);
            studentArrayList.Add(student2);
            studentArrayList.Add(student3);
            studentArrayList.Add(student4);
            studentArrayList.Add(teacher1); //teacher e student

            List<Student> studentList = new List<Student>();
            studentList.Add(student1);
            studentList.Add(student2);
            studentList.Add(student3);
            studentList.Add(student4);
            //studentList.Add(teacher1); da errore

            Hashtable studentHashtable = new Hashtable(); //map, le key e le value possono essere qualisasi type
            studentHashtable.Add("pippo", student1);
            studentHashtable.Add("pico", teacher1);
            studentHashtable.Add(5, teacher3);

            Dictionary<string, Student> studentDictionary = new Dictionary<string, Student>(); //map, qua no
            studentDictionary.Add("pippo", student1);
            //studentDictionary.Add(5, teacher1); da errore

            SuperList<Student> superList = new SuperList<Student>();
            superList.Push(student1);
            superList.Push(student2);
            superList.Push(student3);
            superList.Push(student4);
            //superList.Push(teacher1); da errore

            for (int i = 0; i < superList.Length; i++)
            {
                Console.WriteLine(superList.Get(i).Name);
            }

            Console.WriteLine("");

            superList.Shift();
            superList.Pop();

            for (int i = 0; i < superList.Length; i++)
            {
                Console.WriteLine(superList.Get(i).Name);
            }
        }

        static Student[] AppendToStudentsArray(Student[] originalArray, Student newStudent)
        {
            var originalLegth = originalArray.Length;
            var newArray = new Student[originalLegth + 1];
            for (int i = 0; i < originalLegth; i++)
            {
                newArray[i] = originalArray[i];
            }
            newArray[originalLegth] = newStudent;

            return newArray;
        }
    }
}
