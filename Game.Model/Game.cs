using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Game.Model
{
    [Table("tab_games")]
    public record Game
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        [Required]
        public string Name { get; set; }
        [Column("creator")]
        [Required]
        public string Creator { get; set; }
        [Column("style")]
        [Required]
        public string Style { get; set; }
        [Column("date_of_release")]
        [Required]
        public string DateOfRelease { get; set; }
    }
}
