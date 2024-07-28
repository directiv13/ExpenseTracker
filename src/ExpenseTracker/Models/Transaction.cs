using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseTracker.Models;

public class Transaction
{
    [Key]
    public int TransactionId { get; set; }
    public int CategoryId { get; set; }
    public int Amount { get; set; }
    [MaxLength(75)]
    public string? Note { get; set; }
    public DateTimeOffset Date { get; set; } = DateTimeOffset.Now;

    public Category Category { get; set; }
}