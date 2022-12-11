using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Eargasm.Models;

public class Playlist
{
    public int Id { get; set; }


    [Required(ErrorMessage = "Please fill out title")]
    [MinLength(3, ErrorMessage = "Minimum 3 characters")]
    public string? Title { get; set; }

    [Required]
    [MinLength(10)]
    public string? Url { get; set; }

    [DataType(DataType.Date)]
    public DateTime Created { get; set; }
    /*public string UserId { get; set; }
    public IdentityUser? User { get; set; }*/

}

