var contacts = new List<Contact>
{
  new() { Name = "Lars", Email = "lars.gunnar@jobloop.no", Location = "Vestfold" },
  new() { Name = "John", Email = "john@jobloop.no", Location = "Oslo" },
  new() { Name = "Jørgen", Email = "jørgen@jobloop.no", Location = "Bergen" },
  new() { Name = "Joel", Email = "joel@jobloop.no", Location = "Vestfold" },
};

// Hente ut mail address for veileder i Vestfold
var newList = contacts
                .Where(contact => contact.Location == "Vestfold")
                .Select(contact => new { Email = contact.Email, Name = contact.Name });

foreach (var details in newList)
{
  Console.WriteLine($"Sending email to: {details.Name} with address: {details.Email}");
}

class Contact
{
  public required string Name { get; set; }
  public required string Email { get; set; }
  public required string Location { get; set; }
}