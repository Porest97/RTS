﻿using System;
using System.Collections.Generic;

namespace RTS.Models.ImportedModels
{
    public partial class GameReceipt
    {
        public int Id { get; set; }
        public int? GameId { get; set; }
        public int? PersonId { get; set; }
        public int? PersonId1 { get; set; }
        public int? PersonId2 { get; set; }
        public int? PersonId3 { get; set; }
        public int Hd1fee { get; set; }
        public int Hd1travelKost { get; set; }
        public int Hd1alowens { get; set; }
        public int Hd1lateGameKost { get; set; }
        public int Hd1totalFee { get; set; }
        public int Hd2fee { get; set; }
        public int Hd2travelKost { get; set; }
        public int Hd2alowens { get; set; }
        public int Hd2lateGameKost { get; set; }
        public int Hd2totalFee { get; set; }
        public int Ld1fee { get; set; }
        public int Ld1travelKost { get; set; }
        public int Ld1alowens { get; set; }
        public int Ld1lateGameKost { get; set; }
        public int Ld1totalFee { get; set; }
        public int Ld2fee { get; set; }
        public int Ld2travelKost { get; set; }
        public int Ld2alowens { get; set; }
        public int Ld2lateGameKost { get; set; }
        public int Ld2totalFee { get; set; }
        public int GameTotalKost { get; set; }
        public int AmountPaidHd1 { get; set; }
        public int AmountPaidHd2 { get; set; }
        public int AmountPaidLd1 { get; set; }
        public int AmountPaidLd2 { get; set; }
        public int? ReceiptStatusId { get; set; }
        public int TotalAmountPaid { get; set; }
        public int TotalAmountToPay { get; set; }
        public int Hd1other { get; set; }
        public int Hd2other { get; set; }
        public int Ld1other { get; set; }
        public int Ld2other { get; set; }

        public virtual Game Game { get; set; }
        public virtual Person Person { get; set; }
        public virtual Person PersonId1Navigation { get; set; }
        public virtual Person PersonId2Navigation { get; set; }
        public virtual Person PersonId3Navigation { get; set; }
        public virtual ReceiptStatus ReceiptStatus { get; set; }
    }
}
