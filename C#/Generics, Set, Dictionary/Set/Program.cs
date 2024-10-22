System.Console.Write("How many students for course A?");
int studentsA = int.Parse(Console.ReadLine());

HashSet<int> hashStudents= new HashSet<int>();

for(int i = 0; i < studentsA; i++){
    int idStudent = int.Parse(Console.ReadLine());
    hashStudents.Add(idStudent);
}

System.Console.Write("How many students for course B?");
int studentsB = int.Parse(Console.ReadLine());

for(int i = 0; i < studentsB; i++){
    int idStudent = int.Parse(Console.ReadLine());
    hashStudents.Add(idStudent);
}

System.Console.Write("How many students for course C?");
int studentsC = int.Parse(Console.ReadLine());

for(int i = 0; i < studentsA; i++){
    int idStudent = int.Parse(Console.ReadLine());
    hashStudents.Add(idStudent);
}

System.Console.WriteLine($"Total students: {hashStudents.Count}");
