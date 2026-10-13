// Student Personal Profile
// Name, Gender, ID, Student Contact Number

using System;
using System.Linq;

class StudentProfile
{
    private string? _firstName;
    private string? _middleName;
    private string? _lastName;

    private string? _gender;

    private string? _contactNumber;

    private string? _fullname;

    public StudentProfile(string firstName, string middlieName, string lastName, string gender, string contactNumber)
    {
        FirstName = firstName;
    }

    // PROPERTIES START
    private string FirstName
    {
        get { return _firstName; }
        set
        {
            // 
        }
    }

    // METHODS START

    public void CombineName()
    {
        _fullname = _firstName + _middleName + _lastName;
    }
}