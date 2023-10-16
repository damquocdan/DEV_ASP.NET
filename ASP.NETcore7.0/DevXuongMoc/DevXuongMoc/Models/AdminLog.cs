using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DevXuongMoc.Models;

public partial class AdminLog
{
    [Key]
    public int LogId { get; set; }

    [Display(Name ="Status")]
    [Required(ErrorMessage ="Status không được để trống")]
    public int? Status { get; set; }

    [Display(Name = "SessionId")]
    [Required(ErrorMessage = "SessionId không được để trống")]

    public string? SessionId { get; set; }

    [Display(Name = "AppCode")]
    [Required(ErrorMessage = "AppCode không được để trống")]
    public string? AppCode { get; set; }

    [Display(Name = "ThreadId")]
    [Required(ErrorMessage = "ThreadId không được để trống")]
    public string? ThreadId { get; set; }

    [Display(Name = "StartTime")]
    [Required(ErrorMessage = "StartTime không được để trống")]
    public DateTime? StartTime { get; set; }

    [Display(Name = "EndTime")]
    [Required(ErrorMessage = "EndTime không được để trống")]
    public DateTime? EndTime { get; set; }

    [Display(Name = "AdminUserId")]
    [Required(ErrorMessage = "AdminUserId không được để trống")]
    public int? AdminUserId { get; set; }

    [Display(Name = "UserLogin")]
    [Required(ErrorMessage = "UserLogin không được để trống")]
    public string? UserLogin { get; set; }

    [Display(Name = "UserName")]
    [Required(ErrorMessage = "UserName không được để trống")]
    public string? UserName { get; set; }

    [Display(Name = "IpAddress")]
    [Required(ErrorMessage = "IpAddress không được để trống")]
    public string? IpAddress { get; set; }

    [Display(Name = "ActionCode")]
    [Required(ErrorMessage = "ActionCode không được để trống")]
    public string? ActionCode { get; set; }

    [Display(Name = "ActionName")]
    [Required(ErrorMessage = "ActionName không được để trống")]
    public string? ActionName { get; set; }

    [Display(Name = "MenuCode")]
    [Required(ErrorMessage = "MenuCode không được để trống")]
    public string? MenuCode { get; set; }

    [Display(Name = "MenuName")]
    [Required(ErrorMessage = "MenuName không được để trống")]
    public string? MenuName { get; set; }

    [Display(Name = "WebpagesActionId")]
    [Required(ErrorMessage = "WebpagesActionId không được để trống")]
    public int? WebpagesActionId { get; set; }

    [Display(Name = "ActionType")]
    [Required(ErrorMessage = "ActionType không được để trống")]
    public int? ActionType { get; set; }

    [Display(Name = "ObjectId")]
    [Required(ErrorMessage = "ObjectId không được để trống")]
    public int? ObjectId { get; set; }

    [Display(Name = "Content")]
    [Required(ErrorMessage = "Content không được để trống")]
    public string? Content { get; set; }

    [Display(Name = "Description")]
    [Required(ErrorMessage = "Description không được để trống")]
    public string? Description { get; set; }

    [Display(Name = "LogLevel")]
    [Required(ErrorMessage = "Loglevel không được để trống")]
    public int? LogLevel { get; set; }

    [Display(Name = "ErrorCode")]
    [Required(ErrorMessage = "ErrorCode không được để trống")]
    public string? ErrorCode { get; set; }
}
