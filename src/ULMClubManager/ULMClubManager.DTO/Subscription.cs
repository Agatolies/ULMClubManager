﻿using System;
using ULMClubManager.DTO.Abstractions;

namespace ULMClubManager.DTO
{
    public class Subscription : IDomainModel
    {
        public Subscription(int? id, DateTime? paymentDate, int timePeriod, int memberID)
        {
            ID = id;
            PaymentDate = paymentDate;
            TimePeriod = timePeriod;
            MemberID = memberID;
        }

        public Subscription(DateTime? paymentDate, int timePeriod, int memberID)
            : this(null, paymentDate, timePeriod, memberID)
        {
        }

        public int? ID { get; }
        public DateTime? PaymentDate { get; set; }
        public int TimePeriod { get; set; }
        public int MemberID { get; set; }

        public bool IsPaid => PaymentDate != null;
        public bool IsForCurrentYear => DateTime.Now.Year == TimePeriod;

        public string Description
        {
            get
            {
                string description;

                if (IsForCurrentYear)
                {
                    description = IsPaid
                        ? $"Le membre est en ordre de cotisation pour l'année courante."
                        : $"Le membre n'a pas encore payé pour cette année.";
                }
                else
                {
                    description = IsPaid
                        ? $"Le membre est en ordre de cotisation pour l'année {TimePeriod}."
                        : $"Le membre n'est pas en ordre de cotisation pour l'année {TimePeriod}.";
                }

                return description;
            }
        }
        
        public override string ToString()
        {
            return Description;
        }
    }
}
