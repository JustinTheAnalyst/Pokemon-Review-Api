namespace PokemonReviewApp.Models
{
    public class Owner
    {
        internal string? FirstName;
        internal string? LastName;

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Gym { get; set; }
        public Country? Country { get; set; }
        public ICollection<PokemonOwner>? PokemonOwners { get; set; }
    }
}
