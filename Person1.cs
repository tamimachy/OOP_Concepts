using System;

namespace Program
{
    public class Person1
    {
        private DateTime _birthdate;
        public void SetBirthdate(DateTime birthdate)
        {
            _birthdate = birthdate;
        }
        public DateTime GetBirtdate()
        {
            return _birthdate;
        }
    }
}
