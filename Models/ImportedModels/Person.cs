using System;
using System.Collections.Generic;

namespace RTS.Models.ImportedModels
{
    public partial class Person
    {
        public Person()
        {
            AccountsToPerson = new HashSet<AccountsToPerson>();
            GamePerson = new HashSet<Game>();
            GamePersonId1Navigation = new HashSet<Game>();
            GamePersonId2Navigation = new HashSet<Game>();
            GamePersonId3Navigation = new HashSet<Game>();
            GameReceiptPerson = new HashSet<GameReceipt>();
            GameReceiptPersonId1Navigation = new HashSet<GameReceipt>();
            GameReceiptPersonId2Navigation = new HashSet<GameReceipt>();
            GameReceiptPersonId3Navigation = new HashSet<GameReceipt>();
            MatchPerson = new HashSet<Match>();
            MatchPersonId1Navigation = new HashSet<Match>();
            MatchPersonId2Navigation = new HashSet<Match>();
            MatchPersonId3Navigation = new HashSet<Match>();
            ReceiptPerson = new HashSet<Receipt>();
            ReceiptPersonId1Navigation = new HashSet<Receipt>();
            ReceiptPersonId2Navigation = new HashSet<Receipt>();
            ReceiptPersonId3Navigation = new HashSet<Receipt>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetAddress { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Ssn { get; set; }
        public string PhoneNumber1 { get; set; }
        public string PhoneNumber2 { get; set; }
        public string Email { get; set; }
        public int? PersonTypeId { get; set; }
        public int? CompanyId { get; set; }
        public int? ClubId { get; set; }
        public int? TeamId { get; set; }
        public int? ActivityId { get; set; }
        public int? CampId { get; set; }
        public string BankAccount { get; set; }
        public string BankName { get; set; }
        public string SwishNumber { get; set; }

        public virtual Activity Activity { get; set; }
        public virtual Camp Camp { get; set; }
        public virtual Club Club { get; set; }
        public virtual Company Company { get; set; }
        public virtual PersonType PersonType { get; set; }
        public virtual Team Team { get; set; }
        public virtual ICollection<AccountsToPerson> AccountsToPerson { get; set; }
        public virtual ICollection<Game> GamePerson { get; set; }
        public virtual ICollection<Game> GamePersonId1Navigation { get; set; }
        public virtual ICollection<Game> GamePersonId2Navigation { get; set; }
        public virtual ICollection<Game> GamePersonId3Navigation { get; set; }
        public virtual ICollection<GameReceipt> GameReceiptPerson { get; set; }
        public virtual ICollection<GameReceipt> GameReceiptPersonId1Navigation { get; set; }
        public virtual ICollection<GameReceipt> GameReceiptPersonId2Navigation { get; set; }
        public virtual ICollection<GameReceipt> GameReceiptPersonId3Navigation { get; set; }
        public virtual ICollection<Match> MatchPerson { get; set; }
        public virtual ICollection<Match> MatchPersonId1Navigation { get; set; }
        public virtual ICollection<Match> MatchPersonId2Navigation { get; set; }
        public virtual ICollection<Match> MatchPersonId3Navigation { get; set; }
        public virtual ICollection<Receipt> ReceiptPerson { get; set; }
        public virtual ICollection<Receipt> ReceiptPersonId1Navigation { get; set; }
        public virtual ICollection<Receipt> ReceiptPersonId2Navigation { get; set; }
        public virtual ICollection<Receipt> ReceiptPersonId3Navigation { get; set; }
    }
}
