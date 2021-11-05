using Collections;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Tests
{
    public class CollectionServiceTests
    {
        private readonly CollectionService collectionService;

        public CollectionServiceTests()
        {
            this.collectionService = new CollectionService(this.GetTestData());
        }

        [Fact]
        public void ShouldReturnCorrectCount()
        {
            Assert.Equal(11, this.collectionService.GetTotalPeopleCount());
        }

        [Fact]
        public void ShouldReturnAllNames()
        {
            var result = this.collectionService.GetAllNames();

            Assert.NotEmpty(result);
            Assert.Equal(11, result.Count());
            Assert.Equal("Lil Slut", result.First());
            Assert.Equal("Wojak", result.Last());
        }

        [Fact]
        public void ShouldReturnAllNamesWithNoDuplicates()
        {
            var result = this.collectionService.GetAllNamesNoDuplicates();

            Assert.NotEmpty(result);
            Assert.Equal(10, result.Count());
            Assert.Equal("Lil Slut", result.First());
            Assert.Equal("Big Retard", result.Last());
        }

        [Fact]
        public void ShouldReturnPeopleEligibleToDrive()
        {
            var result = this.collectionService.GetPeopleEligibleToDrive();

            Assert.NotEmpty(result);
            Assert.Equal(6, result.Count());
            Assert.Equal("Slut", result.First().Name);
            Assert.Equal("Retard", result.Last().Name);
        }

        [Fact]
        public void ShouldReturnPeopleOrderedByAge()
        {
            var result = this.collectionService.GetPeopleOrderedByAge();

            Assert.NotEmpty(result);
            Assert.Equal(11, result.Count());
            Assert.Equal("Wojak", result.First().Name);
            Assert.Equal(11, result.First().Age);
            Assert.Equal("Dirty slut", result.Last().Name);
            Assert.Equal(69, result.Last().Age);
        }

        [Fact]
        public void ShouldReturnPeopleWithInvalidEmails()
        {
            var result = this.collectionService.GetPeopleWithInvalidEmails();

            Assert.NotEmpty(result);
            Assert.Equal(5, result.Count());
        }

        [Fact]
        public void ShouldReturnPeopleWithFuckYouEmailProvider()
        {
            var result = this.collectionService.GetPeopleWithFuckYouEmailProvider();

            Assert.NotEmpty(result);
            Assert.Equal(5, result.Count());
        }

        [Fact]
        public void ShouldReturnAllSluts()
        {
            var result = this.collectionService.GetAllSluts();

            Assert.NotEmpty(result);
            Assert.Equal(4, result.Count());

            foreach (var person in result)
            {
                Assert.Contains("slut", person.Name.ToLower());
            }
        }

        [Fact]
        public void ShouldReturnSlutsPhoneNumbers()
        {
            var result = this.collectionService.GetSlutsPhoneNumbers();

            Assert.NotEmpty(result);
            Assert.Equal(4, result.Count());
        }

        [Fact]
        public void ShouldReturnAllSlutsFromMenchester()
        {
            var result = this.collectionService.GetAllSlutsFromMenchester();

            Assert.NotEmpty(result);
            Assert.Equal(3, result.Count());

            foreach (var person in result)
            {
                Assert.Contains("slut", person.Name.ToLower());
                Assert.Contains("menchester", person.City.ToLower());
            }
        }

        private List<Person> GetTestData() => new()
        {
            new Person()
            {
                Id = 1,
                Name = "Lil Slut",
                Age = 16,
                City = "Menchester",
                Email = "little.slut@fuck.you",
                Phone = "786325673"
            },
            new Person()
            {
                Id = 2,
                Name = "Slut",
                Age = 19,
                City = "Menchester",
                Email = "fuck.you.fuck.you@you",
                Phone = "798541756"
            },
            new Person()
            {
                Id = 3,
                Name = "Giga Chad",
                Age = 16,
                City = "Your mom",
                Email = "giga.chad@fuck.you",
                Phone = "786325673"
            },
            new Person()
            {
                Id = 4,
                Name = "Wojak",
                Age = 41,
                City = "Niggeria",
                Email = "wojak@fuck.you",
                Phone = "786325673"
            },
            new Person()
            {
                Id = 5,
                Name = "BIG ASS SLUT",
                Age = 16,
                City = "Menchester",
                Email = "big.ass.slut@fuck",
                Phone = "548698523"
            },
            new Person()
            {
                Id = 6,
                Name = "Raazaa",
                Age = 32,
                City = "Niggeria",
                Email = "fuck.you.heal@fuck.no",
                Phone = "548698523"
            },
            new Person()
            {
                Id = 7,
                Name = "Dirty slut",
                Age = 69,
                City = "Niggeria",
                Email = "dirty.slut@fuck.you",
                Phone = "326547895"
            },
            new Person()
            {
                Id = 8,
                Name = "Idiot",
                Age = 48,
                City = "Niggeria",
                Email = "idiot@",
                Phone = "326547895"
            },
            new Person()
            {
                Id = 9,
                Name = "Retard",
                Age = 42,
                City = "Niggeria",
                Email = "idiot@fucking.",
                Phone = "326547895"
            },
            new Person()
            {
                Id = 10,
                Name = "Big Retard",
                Age = 12,
                City = "Niggeria",
                Email = "idiot.fucking.haha",
                Phone = "326547895"
            },
            new Person()
            {
                Id = 11,
                Name = "Wojak",
                Age = 11,
                City = "Niggeria",
                Email = "wojak@fuck.you",
                Phone = "786325673"
            }
        };
    }
}
