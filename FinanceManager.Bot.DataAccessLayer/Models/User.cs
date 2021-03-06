﻿namespace FinanceManager.Bot.DataAccessLayer.Models
{
    public class User : BaseModel
    {
        public long ChatId { get; set; }
        
        public Context Context { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}