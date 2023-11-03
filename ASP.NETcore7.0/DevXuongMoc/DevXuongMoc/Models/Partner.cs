using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DevXuongMoc.Models;

public partial class Partner
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string? Title { get; set; }

    [Required]
    public string? Logo { get; set; }

    [Required]
    public string? Url { get; set; }

    [Required]
    public byte? Orders { get; set; }

    [Required]
    public DateTime? CreatedDate { get; set; }

    [Required]
    public DateTime? UpdatedDate { get; set; }

    [Required]
    public string? AdminCreated { get; set; }

    [Required]
    public string? AdminUpdated { get; set; }

    [Required]
    public string? Content { get; set; }

    [Required]
    public byte? Status { get; set; }

    [Required]
    public bool? Isdelete { get; set; }
}
