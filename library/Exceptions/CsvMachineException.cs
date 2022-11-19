﻿namespace FluentCsvMachine.Exceptions
{
    /// <summary>
    /// Internal exception: State machines cannot handle CSV file
    /// </summary>
    public class CsvMachineException : Exception
    {
        public CsvMachineException(string message) : base(
            $"State machines cannot handle CSV file, please support a bug ticket! Reason: {message}")
        {
        }
    }
}