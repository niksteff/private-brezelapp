﻿// <copyright file="Price.cs" company="Dominik Steffen">
// Copyright (c) Dominik Steffen. All rights reserved.
// </copyright>

namespace Brezelapp.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Price
    {
        public Price(string currency, string amount)
        {
            this.Currency = currency;
            this.Amount = amount;
        }

        protected Price()
        {
        }

        [Key]
        public int Id { get; set; }

        // TODO: Refactor currency to a package with ISO values
        public string Currency { get; set; }

        public string Amount { get; set; }
    }
}