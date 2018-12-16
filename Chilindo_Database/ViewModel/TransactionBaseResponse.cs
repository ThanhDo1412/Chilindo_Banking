﻿namespace Chilindo_Database.ViewModel
{
    public class TransactionBaseResponse
    {
        public int AccountNumber { get; set; }
        public bool Successful { get; set; }
        public decimal Balance { get; set; }
        public string Currency { get; set; }
        public string Message { get; set; }
    }
}
