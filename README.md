# NCache OSS Wrapper for StackExchange.Redis

A compatibility layer that enables .NET applications to use [NCache](https://www.alachisoft.com/ncache/) as a drop-in replacement for Redis with the familiar StackExchange.Redis API.

## Package Versions

| Package | Version |
|---------|---------|
| NCache.StackExchange.Redis | 5.3.6.2 |
| Alachisoft.NCache.SDK | >= 5.3.6.2 |
| Supported StackExchange.Redis | >= 2.12.14 |

## Overview

NCache is an extremely fast and scalable distributed cache for .NET applications. This wrapper allows you to migrate from Redis to NCache with minimal code changes by providing implementations of the StackExchange.Redis interfaces.

**Key Benefits:**
- Migrate from Redis to NCache without rewriting your application
- Use familiar StackExchange.Redis API patterns
- Leverage NCache's enterprise features (clustering, replication, persistence)
- Maintain existing Redis-based code while gaining NCache performance

## Getting Started

### 1. Configure the cache name

The wrapper resolves which NCache cache to connect to from a single identifier, typically read from your app's configuration:

```xml
<appSettings>
  <add key="CacheId" value="democache" />
</appSettings>
```

### 2. Connect and get a database handle

```csharp
using Alachisoft.NCache.Client;
using NCache.OSS.StackExchange.Redis;
using System.Configuration;

string cacheName = ConfigurationManager.AppSettings["CacheId"];

ConnectionMultiplexer mux = ConnectionMultiplexer.Connect(cacheName);
INCacheDatabase db = mux.GetDatabase();
```

`mux` and `db` behave like a standard StackExchange.Redis `ConnectionMultiplexer`/`IDatabase` pair, so existing Redis call sites — string get/set, key expiration and TTL, bulk operations, pub/sub, locks, and so on — work against `db` unchanged.

### 3. (Optional) Reach NCache-specific features

```csharp
ICache cache = mux.GetNCacheInterface(cacheName);
```

`GetNCacheInterface` hands back the underlying NCache `ICache`, useful for operations outside the Redis surface for NCache-only capabilities.

### 4. (Optional) Wire up logging

```csharp
using Microsoft.Extensions.Logging;

ILoggerFactory loggerFactory = LoggerFactory.Create(builder =>
{
    builder
        .AddConsole()
        .SetMinimumLevel(LogLevel.Debug);
});
```

## License

Copyright © 2005-2026 Alachisoft. All rights reserved.

## Resources

- [NCache Documentation](https://www.alachisoft.com/resources/docs/)
- [NCache Open Source](https://github.com/Alachisoft/NCache)
- [Alachisoft Website](https://www.alachisoft.com/ncache/)
- 