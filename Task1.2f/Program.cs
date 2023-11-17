namespace Task1._2f
{
    internal class Program
    {
        static void Main()
        {
            var outputData = new StudentList()
        {
            new Student("Вернадский Петр Филимонович", 14, "Vern2012@mail.ru", 3.2f, 4.3f, 3.7f),

        };

            Console.WriteLine(outputData.ToString());
            IEnumerable<string> average = outputData.Select(x => $"{x.fullName}\t{Math.Round(x.AverageScore, 2)}");
            foreach (string studentOutput in average)
            {
                Console.WriteLine(studentOutput);
                Console.ReadKey();
            }
        }
    }

}
internal class StudentList : List<Student>
{
    public override string ToString() =>
        string.Join("\n", this.Select(x => x.ToString()));
}
internal record Student(string fullName, int age, string email, float progScore, float mathScore, float physScore)
{
    public override string ToString() =>
        string.Join("\t", fullName, age, email, progScore, mathScore, physScore);

    public float AverageScore =>
        (progScore + mathScore + physScore) / 3;
}

   