// File:    PaymentWithCash.cs
// Author:  126052
// Created: wtorek, 5 listopada 2019 11:10:45
// Purpose: Definition of Class PaymentWithCash

using System;

public class PaymentWithCash : BasePayment
{
   public PaymentWithCash(string name, string surname, string address, string city, string zipCode) : basePayment(name, surname, address, city, zipCode)
   {
      throw new NotImplementedException();
   }
   
   public override bool CompletePayment()
   {
      throw new NotImplementedException();
   }

}