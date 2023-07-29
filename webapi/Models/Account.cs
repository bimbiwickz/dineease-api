﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace webapi.Models;

[Table("Account", Schema = "userMGT")]
public partial class Account
{
    [Key]
    [Column("user_id")]
    [StringLength(10)]
    [Unicode(false)]
    public string UserId { get; set; }

    [Required]
    [Column("password")]
    [Unicode(false)]
    public string Password { get; set; }

    [Column("role")]
    [StringLength(10)]
    [Unicode(false)]
    public string Role { get; set; }

    [Column("created_date", TypeName = "datetime")]
    public DateTime CreatedDate { get; set; }

    [Column("last_updated")]
    public byte[] LastUpdated { get; set; }

    [ForeignKey("Role")]
    [InverseProperty("Account")]
    public virtual Role RoleNavigation { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("Account")]
    public virtual User User { get; set; }
}