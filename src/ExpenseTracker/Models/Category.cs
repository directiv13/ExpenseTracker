using System.ComponentModel.DataAnnotations;

namespace ExpenseTracker.Models;

public class Category
{
    [Key]
    public int CategoryId { get; set; }

    [MaxLength(50)]
    public string Title { get; set; }

    [MaxLength(5)]
    public string Icon { get; set; } = string.Empty;

    [MaxLength(10)]
    public string Type { get; set; } = "Expense";
}