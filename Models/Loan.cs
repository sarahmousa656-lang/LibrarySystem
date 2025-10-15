using System;
using LibrarySystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace LibrarySystem.Models;
public class Loan
{
    public int Id { get; set; }
    public string BorrowerName { get; set; }
    public int BookId { get; set; }
    public Book Book { get; set; }
    public DateTime LoanDate { get; set; }
    public DateTime? ReturnDate { get; set; }
}