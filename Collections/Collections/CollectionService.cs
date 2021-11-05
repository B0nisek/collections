using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

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
            return this.people.Count;
        }

        public IEnumerable<string> GetAllNames()
        {
            return this.people.Select(x => x.Name);
        }

        public IEnumerable<string> GetAllNamesNoDuplicates()
        {
            return this.GetAllNames().Distinct();
        }

        public IEnumerable<Person> GetPeopleEligibleToDrive()
        {
            return this.people.Where(x => x.Age >= 18);
        }

        public IEnumerable<Person> GetPeopleOrderedByAge()
        {
            return this.people.OrderBy(x => x.Age);
        }

        public IEnumerable<Person> GetPeopleWithInvalidEmails()
        {
            return this.people.Where(x => !Regex.IsMatch(x.Email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase));
        }

        public IEnumerable<Person> GetPeopleWithFuckYouEmailProvider()
        {
            return this.people.Where(x => x.Email.EndsWith("fuck.you"));
        }

        public IEnumerable<Person> GetAllSluts()
        {
            return this.people.Where(x => x.Name.ToLower().Contains("slut"));
        }

        public IEnumerable<string> GetSlutsPhoneNumbers()
        {
            return this.GetAllSluts().Select(x => x.Phone);
        }

        public IEnumerable<Person> GetAllSlutsFromMenchester()
        {
            return this.GetAllSluts().Where(x => x.City == "Menchester");
        }
    }
}