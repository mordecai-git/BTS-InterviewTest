namespace InterviewTest
{
    public class Person : IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime DateOfBirth { get; set; }

        private List<Person> _persons = new List<Person>();

        public Person Insert(Person model)
        {
            model.Id = _persons.Count + 1;
            _persons.Add(model);

            return model;
        }

        public List<Person> ListPersons()
        {
            return _persons;
        }

        public Person GetById(int id)
        {
            var person = _persons.FirstOrDefault(p => p.Id == id);

            return person;
        }
    }
}
