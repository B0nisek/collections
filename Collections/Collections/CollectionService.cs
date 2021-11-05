using System;
using System.Collections.Generic;

namespace Collections
{
    public class CollectionService
    {
        private readonly List<Person> people;

        public CollectionService(List<Person> people)
        {
            this.people = people;
        }

        public int GetTotalPeopleCount()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetAllNames()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetAllNamesNoDuplicates()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Person> GetPeopleEligibleToDrive()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Person> GetPeopleOrderedByAge()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Person> GetPeopleWithInvalidEmails()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Person> GetPeopleWithFuckYouEmailProvider()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Person> GetAllSluts()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetSlutsPhoneNumbers()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Person> GetAllSlutsFromMenchester()
        {
            throw new NotImplementedException();
        }
    }
}