﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceApp.Core.Exceptions;

public class DateTimeException(string message, Exception innerException) : Exception(message, innerException)
{
}
