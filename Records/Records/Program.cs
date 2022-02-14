// See https://aka.ms/new-console-template for more information
using Records;
using Records.Inheritance;
using Records.Init;
using Records.RecordClass;

//////////////////////////   equality
var person = new Person("Joe", "Bloggs");
var personTwo = new Person("Joe", "Bloggs");
var personThree = new Person("Jane", "Villi");

Console.WriteLine($"Person1 == Person2? {person == personTwo}");
Console.WriteLine($"Person1 == Person3? {personThree == personTwo}");


//////////////////////////   init

var personInitOne = new PersonInit { FirstName = "Joe", LastName = "Bloggs" };
//not compile
//personInitOne.FirstName = "Change";

/////////////////////////  Positional Records
var personRecordClass1 = new PersonRecordClass("Joe", "Bloggs");

//Not compile , while we have defined constructor with corresponding parameters
//var personRecordClass2 = new PersonRecordClass { FirstName = "Test", LastName = "A" };

//not compile
//personRecordClass1.FirstName = "Changed";

//////////////////////// Cloning Records
var personToClone = person with { FirstName = "ChangeName" };
Console.WriteLine(personToClone.FirstName);
;

//////////////////////////   Inheritance
var person1 = new EmployeeWithInheritance("Joe", 39, "Firefigher");
var person2 = new EmployeeWithInheritance("Joe", 61, "Teacher");

Console.WriteLine(person2);

///////////////////////// Record with defined parameters
///a constructor with all properties as arguments without having to write the constructor itself.
/////not compile
//var personWithParameters = new PersonWithParameters { FullName = "test", 15 };
var personWithParameters = new PersonWithParameters("A", 14);
//not compile
//personWithParameters.Age = 22;
