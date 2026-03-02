using System.ComponentModel.DataAnnotations;

namespace Auction.AssetRadar.Users.Dto;

public class ChangeUserLanguageDto
{
    [Required]
    public string LanguageName { get; set; }
}