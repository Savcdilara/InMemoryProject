using InMemoryProject.Entity;
using InMemoryProject.Persistence;
using System;
using System.Linq;

using (var context = new PersonMasterDbContext())
{
    // Toplu ekleme işlemi
    var newPeople = new[]
    {
                new Person { Name = "Kişi 1", Age = 25 },
                new Person { Name = "Kişi 2", Age = 30 }
            };
    context.People.AddRange(newPeople);
    context.SaveChanges();

    // Güncelleme işlemi
    var personToUpdate = context.People.FirstOrDefault(p => p.Name == "Kişi 1");
    if (personToUpdate != null)
    {
        personToUpdate.Age = 26;
        context.SaveChanges();
    }

    // Silme işlemi
    var personToDelete = context.People.FirstOrDefault(p => p.Name == "Kişi 2");
    if (personToDelete != null)
    {
        context.People.Remove(personToDelete);
        context.SaveChanges();
    }
}
