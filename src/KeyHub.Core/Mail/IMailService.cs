﻿using System;
using System.Collections.Generic;
using KeyHub.Model;

namespace KeyHub.Core.Mail
{
    public interface IMailService
    {
        void SendTransactionMail(string purchaserName, string purchaserEmail, Guid transactionId);
        void SendIssueMail(ApplicationIssueSeverity severity, string message, string details, IEnumerable<User> users);
    }
}
