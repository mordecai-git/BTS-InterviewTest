namespace InterviewTest
{
    public interface IPerson
    {
        Person GetById(int id);
        Person Insert(Person model);
        List<Person> ListPersons();
    }
}
