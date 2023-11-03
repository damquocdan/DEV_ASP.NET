using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DevXuongMoc.Models;

public partial class Banner
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string? Image { get; set; }

    [Required]
    public string? Title { get; set; }

    [Required]
    public string? SubTitle { get; set; }

    [Required]
    public string? Urls { get; set; }

    [Required]
    public int Orders { get; set; }

    [Required]
    public string? Type { get; set; }

    [Required]
    public DateTime? CreatedDate { get; set; }

    [Required]
    public DateTime? UpdatedDate { get; set; }

    [Required]
    public string? AdminCreated { get; set; }

    [Required]
    public string? AdminUpdated { get; set; }

    [Required]
    public string? Notes { get; set; }

    [Required]
    public byte Status { get; set; }

    [Required]
    public bool Isdelete { get; set; }
}
