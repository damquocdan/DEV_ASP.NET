﻿using System;
using System.Collections.Generic;

namespace Lesson09.Lap.Models;

public partial class InforCompany
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Logo { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? Address { get; set; }

    public string? Youtube { get; set; }

    public string? Instagram { get; set; }

    public string? Facebook { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? AdminCreated { get; set; }

    public string? AdminUpdated { get; set; }

    public string? MetaTitle { get; set; }

    public string? MetaKeyword { get; set; }

    public string? MetaDescription { get; set; }
}
