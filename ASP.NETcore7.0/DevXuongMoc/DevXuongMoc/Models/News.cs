using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DevXuongMoc.Models;

public partial class News
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string? Code { get; set; }

    [Required]
    public string? Title { get; set; }

    [Required]
    public string? Description { get; set; }

    [Required]
    public string? Content { get; set; }

    [Required]
    public string? Image { get; set; }

    [Required]
    public string? MetaTitle { get; set; }

    [Required]
    public string? MainKeyword { get; set; }

    [Required]
    public string? MetaKeyword { get; set; }

        
    public string? MetaDescription { get; set; }

    [Required]
    public string? Slug { get; set; }

    [Required]
    public int? Views { get; set; }

    [Required]
    public int? Likes { get; set; }

    [Required]
    public double? Star { get; set; }

    [Required]
    public DateTime? CreatedDate { get; set; }

    [Required]
    public DateTime? UpdatedDate { get; set; }

    [Required]
    public string? AdminCreated { get; set; }

    [Required]
    public string? AdminUpdated { get; set; }

    [Required]
    public byte? Status { get; set; }

    [Required]
    public bool? Isdelete { get; set; }
}
