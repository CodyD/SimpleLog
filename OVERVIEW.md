- ### TODO

##### ILogger

- Must be scalable
- Provide function to log
- Provide function to provide stack trace

##### LoggingFlags

- Level: Info, Warning, Debug, Error, Critical
- Detail: StackTrace, Simple
- UserInfo
- SystemSpecs

##### Concrete

- Singleton?
  - I think singletons can be abused more often than now, **no singletons for this demo**
- Faceted builder
  - We can provide a way to attach the stream writer, which will make testing easer
- Write to file (use a memory mapped file for now)

### Unit Tests



