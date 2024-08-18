namespace SingletonPattern;

class Program
{
    static void Main(string[] args)
    {
        Singletone singletoneFromTeacher = Singletone.GetInstance();
        singletoneFromTeacher.PrintDetails("From Teacher");

        Singletone singletoneFromStudent = Singletone.GetInstance();
        singletoneFromStudent.PrintDetails("From Student");
    }
}
