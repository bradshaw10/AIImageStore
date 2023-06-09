﻿using System;
using System.Collections.Generic;

namespace AIImageStoreServer.Models;

public partial class User
{
    public int UserId { get; set; }

    public string Username { get; set; } = null!;

    public byte[] PasswordHash { get; set; } = null!;
    public byte[] PasswordSalt { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string ShippingAddress { get; set; } = null!;

    public string BillingAddress { get; set; } = null!;

    public virtual ICollection<Cart> Carts { get; } = new List<Cart>();

    public virtual ICollection<Order> Orders { get; } = new List<Order>();

    public virtual ICollection<PurchaseHistory> PurchaseHistories { get; } = new List<PurchaseHistory>();
}

public class CreateUser
{
    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;
    public string Username { get; set; } = null!;
}

public class UserLogin
{
    public string? Email { get; set; }
    public string Password { get; set; }
    public string? Username { get; set; }
}