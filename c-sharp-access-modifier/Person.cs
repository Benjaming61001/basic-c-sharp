public class Person
{
  private string _firstName = string.Empty;
  private string _lastName = string.Empty;
  private DateTime _dateOfBirth = default;

  public void setFirstName(string firstName)
  {
    this._firstName = firstName;
  }

  public string getFirstName()
  {
    return this._firstName;
  }

  public void setLastName(string lastName)
  {
    this._lastName = lastName;
  }

  public string getLastName()
  {
    return this._lastName;
  }

  public void setDateOfBirth(DateTime dateOfBirth)
  {
    this._dateOfBirth = dateOfBirth;
  }

  public DateTime getDateOfBirth()
  {
    return this._dateOfBirth;
  }
}