using MinimalAPIJwt.Models;

namespace MinimalAPIJwt.Repositories
{
    public class MovieRepository
    {
        public static List<Movie> Movies = new()
        {
            new () { Id = 1, Title = "Watchmen", Description = "In an alternate 1985 America, costumed superheroes are part of everyday life. When one of his former comrades is murdered, masked vigilante Rorschach (Jackie Earle Haley) uncovers a plot to kill and discredit all past and present superheroes.", Rating = 10 },
            new () { Id = 2, Title = "Matrix", Description = "It depicts a dystopian future in which humanity is unknowingly trapped inside a simulated reality, the Matrix, which intelligent machines have created to distract humans while using their bodies as an energy source.", Rating = 10 },
            new () { Id = 3, Title = "The Lord of the Rings: The Fellowship of the Ring", Description = "Sauron, the Dark Lord, has awakened and threatens to conquer Middle-earth. To stop this ancient evil once and for all, Frodo Baggins must destroy the One Ring in the fires of Mount Doom. Men, Hobbits, a wizard, an Elf, and a Dwarf form a fellowship to help him on his quest.", Rating = 10 },
            new () { Id = 4, Title = "Predestination", Description = "Robertson (Noah Taylor), continues to find her of interest. Around this time, though, Jane meets a mysterious man and falls in love but is crushed when he vanishes, leaving her pregnant and alone. While delivering her child, another unanticipated discovery is made that will change her life forever, among other things.", Rating = 10 },
            new () { Id = 5, Title = "Django Unchained", Description = "“Django Unchained” is a rip-roaring revenge actioner set in the American South just two years before the Civil War. It follows Django, a slave freed and trained as a bounty hunter by sophisticated German-born Dr. King Schultz, who is appalled by the racist ways of the antebellum South.", Rating = 10 },
        };
    }
}
