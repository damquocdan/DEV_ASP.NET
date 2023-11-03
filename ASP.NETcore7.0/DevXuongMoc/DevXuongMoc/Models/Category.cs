using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DevXuongMoc.Models;

public partial class Category
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string? Title { get; set; }

    [Required]  
    public string? Icon { get; set; }

    [Required]
    public string? MateTitle { get; set; }

    [Required]
    public string? MetaKeyword { get; set; }

    [Required]
    public string? MetaDescription { get; set; }

    [Required]
    public string? Slug { get; set; }

    [Required]
    public int? Orders { get; set; }

    [Required]
    public int? Parentid { get; set; }

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
    public byte? Status { get; set; }

    [Required]
    public bool? Isdelete { get; set; }
}
