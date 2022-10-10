# SimpleLogger

## What is it?

SimpleLogger is a synchronous logging utility built in .NET Framework 4.5.2

It features an SDK for connecting to your own output origin.

### Classes

#### TW.SimpleLogger.Contracts

Namespace containing standardized logging utility interfaces.

###### Enums.Granularity

The verboseness of the logging statements, IE should you include the system information, or call stack.

###### Enums.Severity

The criticality of the log statement, IE error or debug mode.

###### ISimpleLogger

Provides the method Log(Severity, Granularity, string) for standardized implementation.

###### IWriteAdapter

Provides the method Write(string) for adapting to various output streams.

#### TW.SimpleLogger.Library

Namespace containing concrete implementation of logging utiltiy.

###### Adapters.ConsoleWriteAdapter

Writes log messages to the system console.

###### Adapters.MemoryFileWriteAdapter

Writes log messages to a memory mapped file.

###### LogBuilder

Provides a factory for attaching an IWriteAdapter to a simple concrete logger.

###### SimpleLogger

Simple concrete logging utility.
