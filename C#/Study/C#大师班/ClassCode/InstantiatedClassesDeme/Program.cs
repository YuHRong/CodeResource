
using InstantiatedClassesDeme;



//List<PersonModel> people = new List<PersonModel>();
//PersonModel person = new PersonModel();
//person.FirstName = "Tim";
//people.Add(person);
//person = new PersonModel();
//Console.WriteLine(person.LastName);
//Console.WriteLine(person.FirstName);

List<PersonModel> people = new List<PersonModel>();
foreach(var p in people)
{
 Console.WriteLine(p.FirstName);
}