var people = new Person[3];

for (int i = 0; i < 3; i++)
{
    Console.Write("Nomro doxil kuned: ");
    string name = Console.ReadLine();
    people[i] = new Person(name);
}

Teacher teacher = new Teacher(people[0].Name);
Student student1 = new Student(people[1].Name);
Student student2 = new Student(people[2].Name);

teacher.Explain();
student1.Study();
student2.Study();



