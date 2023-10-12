using Lab1;

var listaMaterii = new List<Materie>();
listaMaterii.Add(new Materie("Asp.Net","1-Semester",5,true));
listaMaterii.Add(new Materie("SGBD", "1-Semester", 6, true));
listaMaterii.Add(new Materie("AF", "1-Semester", 5, true));
listaMaterii.Add(new Materie("Engleza", "2-Years", 2, false));
listaMaterii.Add(new Materie("Algebra", "1-Year", 6, false));

var listaStudenti = new List<Student>();
listaStudenti.Add(new Student());
listaStudenti.Last().Name = "Alex";
listaStudenti.Last().Surname = "Georgescu";
listaStudenti.Last().Year = 3;
listaStudenti.Last().StudyLevel = "Licenta";
listaStudenti.Last().Materii.Add(listaMaterii[0]);
listaStudenti.Last().Materii.Add(listaMaterii[1]);
listaStudenti.Last().Materii.Add(listaMaterii[2]);
listaStudenti.Last().Materii.Add(listaMaterii[4]);

listaStudenti.Add(new Student());
listaStudenti.Last().Name = "Andrei";
listaStudenti.Last().Surname = "Alexandru";
listaStudenti.Last().Year = 2;
listaStudenti.Last().StudyLevel = "Masterat";
listaStudenti.Last().Materii.Add(listaMaterii[0]);
listaStudenti.Last().Materii.Add(listaMaterii[1]);
listaStudenti.Last().Materii.Add(listaMaterii[2]);


listaStudenti.Add(new Student());
listaStudenti.Last().Name = "Maria";
listaStudenti.Last().Surname = "Ionescu";
listaStudenti.Last().Year = 1;
listaStudenti.Last().StudyLevel = "Doctorat";
listaStudenti.Last().Materii.Add(listaMaterii[4]);
listaStudenti.Last().Materii.Add(listaMaterii[3]);

foreach (Materie m in listaMaterii)
{ 
    m.Afisare();
}
Console.WriteLine();
foreach (Student s in listaStudenti)
{
    s.Afisare();
    Console.WriteLine();
}




