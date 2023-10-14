﻿using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class Category
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Icon { get; set; }

    public string? MateTitle { get; set; }

    public string? MetaKeyword { get; set; }

    public string? MetaDescription { get; set; }

    public string? Slug { get; set; }

    public int? Orders { get; set; }

    public int? Parentid { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? AdminCreated { get; set; }

    public string? AdminUpdated { get; set; }

    public string? Notes { get; set; }

    public byte? Status { get; set; }

    public bool? Isdelete { get; set; }
}
