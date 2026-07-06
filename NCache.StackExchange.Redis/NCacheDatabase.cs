using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using Alachisoft.NCache.Client;
using Alachisoft.NCache.Runtime.Caching;
using Microsoft.Extensions.Logging;
using NCache.OSS.StackExchange.Redis;

namespace NCache.OSS.StackExchange.Redis
{
    public class NCacheDatabase : INCacheDatabase
    {
        ICache _cache;
        private ILogger _logger;


        public void Initialize(ICache cache)
        {
            _cache = cache;
        }

        public NCacheDatabase()
        {

        }

        public NCacheDatabase(ICache cache)
        {
            Initialize(cache);
        }

        public NCacheDatabase(ICache cache, ILogger logger)
        {
            Initialize(cache);
            SetLogger(logger);

        }

        public void SetLogger(ILogger logger)
        {
            _logger = logger;
        }

        public int Database => throw new NotSupportedException();

        public IConnectionMultiplexer Multiplexer => throw new NotSupportedException();

        public IBatch CreateBatch(object asyncState = null)
        {
            throw new NotSupportedException();
        }

        public ITransaction CreateTransaction(object asyncState = null)
        {
            throw new NotSupportedException();
        }

        public RedisValue DebugObject(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<RedisValue> DebugObjectAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public RedisResult Execute(string command, params object[] args)
        {
            throw new NotSupportedException();
        }

        public RedisResult Execute(string command, ICollection<object> args, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<RedisResult> ExecuteAsync(string command, params object[] args)
        {
            throw new NotSupportedException();
        }

        public Task<RedisResult> ExecuteAsync(string command, ICollection<object> args, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public bool GeoAdd(RedisKey key, double longitude, double latitude, RedisValue member, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public bool GeoAdd(RedisKey key, GeoEntry value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long GeoAdd(RedisKey key, GeoEntry[] values, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<bool> GeoAddAsync(RedisKey key, double longitude, double latitude, RedisValue member, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<bool> GeoAddAsync(RedisKey key, GeoEntry value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> GeoAddAsync(RedisKey key, GeoEntry[] values, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public double? GeoDistance(RedisKey key, RedisValue member1, RedisValue member2, GeoUnit unit = GeoUnit.Meters, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<double?> GeoDistanceAsync(RedisKey key, RedisValue member1, RedisValue member2, GeoUnit unit = GeoUnit.Meters, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public string[] GeoHash(RedisKey key, RedisValue[] members, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public string GeoHash(RedisKey key, RedisValue member, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<string[]> GeoHashAsync(RedisKey key, RedisValue[] members, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<string> GeoHashAsync(RedisKey key, RedisValue member, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public GeoPosition?[] GeoPosition(RedisKey key, RedisValue[] members, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public GeoPosition? GeoPosition(RedisKey key, RedisValue member, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<GeoPosition?[]> GeoPositionAsync(RedisKey key, RedisValue[] members, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<GeoPosition?> GeoPositionAsync(RedisKey key, RedisValue member, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public GeoRadiusResult[] GeoRadius(RedisKey key, RedisValue member, double radius, GeoUnit unit = GeoUnit.Meters, int count = -1, Order? order = null, GeoRadiusOptions options = GeoRadiusOptions.Default, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public GeoRadiusResult[] GeoRadius(RedisKey key, double longitude, double latitude, double radius, GeoUnit unit = GeoUnit.Meters, int count = -1, Order? order = null, GeoRadiusOptions options = GeoRadiusOptions.Default, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<GeoRadiusResult[]> GeoRadiusAsync(RedisKey key, RedisValue member, double radius, GeoUnit unit = GeoUnit.Meters, int count = -1, Order? order = null, GeoRadiusOptions options = GeoRadiusOptions.Default, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<GeoRadiusResult[]> GeoRadiusAsync(RedisKey key, double longitude, double latitude, double radius, GeoUnit unit = GeoUnit.Meters, int count = -1, Order? order = null, GeoRadiusOptions options = GeoRadiusOptions.Default, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public bool GeoRemove(RedisKey key, RedisValue member, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<bool> GeoRemoveAsync(RedisKey key, RedisValue member, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long HashDecrement(RedisKey key, RedisValue hashField, long value = 1, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public double HashDecrement(RedisKey key, RedisValue hashField, double value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> HashDecrementAsync(RedisKey key, RedisValue hashField, long value = 1, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<double> HashDecrementAsync(RedisKey key, RedisValue hashField, double value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public bool HashDelete(RedisKey key, RedisValue hashField, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long HashDelete(RedisKey key, RedisValue[] hashFields, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<bool> HashDeleteAsync(RedisKey key, RedisValue hashField, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> HashDeleteAsync(RedisKey key, RedisValue[] hashFields, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public bool HashExists(RedisKey key, RedisValue hashField, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<bool> HashExistsAsync(RedisKey key, RedisValue hashField, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public RedisValue HashGet(RedisKey key, RedisValue hashField, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public RedisValue[] HashGet(RedisKey key, RedisValue[] hashFields, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public HashEntry[] HashGetAll(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<HashEntry[]> HashGetAllAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<RedisValue> HashGetAsync(RedisKey key, RedisValue hashField, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<RedisValue[]> HashGetAsync(RedisKey key, RedisValue[] hashFields, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Lease<byte> HashGetLease(RedisKey key, RedisValue hashField, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<Lease<byte>> HashGetLeaseAsync(RedisKey key, RedisValue hashField, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long HashIncrement(RedisKey key, RedisValue hashField, long value = 1, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public double HashIncrement(RedisKey key, RedisValue hashField, double value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> HashIncrementAsync(RedisKey key, RedisValue hashField, long value = 1, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<double> HashIncrementAsync(RedisKey key, RedisValue hashField, double value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public RedisValue[] HashKeys(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<RedisValue[]> HashKeysAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long HashLength(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> HashLengthAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public IEnumerable<HashEntry> HashScan(RedisKey key, RedisValue pattern, int pageSize, CommandFlags flags)
        {
            throw new NotSupportedException();
        }

        public IEnumerable<HashEntry> HashScan(RedisKey key, RedisValue pattern = default, int pageSize = 250, long cursor = 0, int pageOffset = 0, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public IAsyncEnumerable<HashEntry> HashScanAsync(RedisKey key, RedisValue pattern = default, int pageSize = 250, long cursor = 0, int pageOffset = 0, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public void HashSet(RedisKey key, HashEntry[] hashFields, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public bool HashSet(RedisKey key, RedisValue hashField, RedisValue value, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task HashSetAsync(RedisKey key, HashEntry[] hashFields, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<bool> HashSetAsync(RedisKey key, RedisValue hashField, RedisValue value, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long HashStringLength(RedisKey key, RedisValue hashField, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> HashStringLengthAsync(RedisKey key, RedisValue hashField, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public RedisValue[] HashValues(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<RedisValue[]> HashValuesAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public bool HyperLogLogAdd(RedisKey key, RedisValue value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public bool HyperLogLogAdd(RedisKey key, RedisValue[] values, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<bool> HyperLogLogAddAsync(RedisKey key, RedisValue value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<bool> HyperLogLogAddAsync(RedisKey key, RedisValue[] values, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long HyperLogLogLength(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long HyperLogLogLength(RedisKey[] keys, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> HyperLogLogLengthAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> HyperLogLogLengthAsync(RedisKey[] keys, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public void HyperLogLogMerge(RedisKey destination, RedisKey first, RedisKey second, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public void HyperLogLogMerge(RedisKey destination, RedisKey[] sourceKeys, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task HyperLogLogMergeAsync(RedisKey destination, RedisKey first, RedisKey second, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task HyperLogLogMergeAsync(RedisKey destination, RedisKey[] sourceKeys, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public EndPoint IdentifyEndpoint(RedisKey key = default, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<EndPoint> IdentifyEndpointAsync(RedisKey key = default, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public bool IsConnected(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            return (_cache != null);

        }

        public bool KeyDelete(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            try
            {
                _cache.Remove(key, out object removedItem);
                if (removedItem == null)
                {
                    return false;
                }
                return true;
            }
            catch (Exception)
            {
                LogError("Exception occurred while deleting key. Key: {Key}", key);
                return false;
            }

        }

        public long KeyDelete(RedisKey[] keys, CommandFlags flags = CommandFlags.None)
        {
            try
            {
                List<string> nKeys = RedisKeysToStringList(keys);

                _cache.RemoveBulk(nKeys, out IDictionary<string, object> removedItems);

                return removedItems.Count();
            }
            catch (Exception)
            {
                LogError("Exception occurred while deleting keys. Keys: {Keys}", string.Join(", ", keys));
                return 0;
            }
        }

        private static List<string> RedisKeysToStringList(RedisKey[] keys)
        {
            List<string> nKeys = new List<string>();
            foreach (var key in keys)
            {
                nKeys.Add(key);
            }

            return nKeys;
        }

        public Task<bool> KeyDeleteAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            return Task.Run(() =>
            {
                return KeyDelete(key, flags);
            });
        }

        public Task<long> KeyDeleteAsync(RedisKey[] keys, CommandFlags flags = CommandFlags.None)
        {
            return Task.Run(() =>
            {
                return KeyDelete(keys, flags);
            });
        }

        public byte[] KeyDump(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<byte[]> KeyDumpAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            return Task.Run(() =>
            {
                return KeyDump(key, flags);
            });
        }

        public bool KeyExists(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            return _cache.Contains(key);
        }

        public long KeyExists(RedisKey[] keys, CommandFlags flags = CommandFlags.None)
        {
            var nkeys = _cache.ContainsBulk(RedisKeysToStringList(keys));
            return nkeys.Where(s => s.Value == true).Count();
        }

        public Task<bool> KeyExistsAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            return Task.Run(() =>
            {
                return KeyExists(key, flags);
            });
        }

        public Task<long> KeyExistsAsync(RedisKey[] keys, CommandFlags flags = CommandFlags.None)
        {
            return Task.Run(() =>
            {
                return KeyExists(keys, flags);
            });
        }

        public bool KeyExpire(RedisKey key, TimeSpan? expiry, CommandFlags flags = CommandFlags.None)
        {
            try
            {
                var cacheItem = _cache.GetCacheItem(key);
                cacheItem.Expiration = expiry != null ? new Alachisoft.NCache.Runtime.Caching.Expiration(Alachisoft.NCache.Runtime.Caching.ExpirationType.Sliding, expiry.Value) : null;
                _cache.Insert(key, cacheItem);
                return true;
            }
            catch (Exception)
            {
                LogError("Exception occurred while setting key expiration. Key: {Key}, Expiry: {Expiry}", key, expiry);
                return false;
            }
        }

        public bool KeyExpire(RedisKey key, DateTime? expiry, CommandFlags flags = CommandFlags.None)
        {
            try
            {
                var cacheItem = _cache.GetCacheItem(key);
                cacheItem.Expiration = expiry != null ? new Alachisoft.NCache.Runtime.Caching.Expiration(Alachisoft.NCache.Runtime.Caching.ExpirationType.Sliding, new TimeSpan(expiry.Value.Ticks - DateTime.Now.Ticks)) : null;
                _cache.Insert(key, cacheItem);
                return true;
            }
            catch (Exception)
            {
                LogError("Exception occurred while setting key expiration. Key: {Key}, Expiry: {Expiry}", key, expiry);
                return false;
            }
        }

        public Task<bool> KeyExpireAsync(RedisKey key, TimeSpan? expiry, CommandFlags flags = CommandFlags.None)
        {
            return Task.Run(() =>
            {
                return KeyExpire(key, expiry, flags);
            });
        }

        public Task<bool> KeyExpireAsync(RedisKey key, DateTime? expiry, CommandFlags flags = CommandFlags.None)
        {
            return Task.Run(() =>
            {
                return KeyExpire(key, expiry, flags);
            });
        }

        public TimeSpan? KeyIdleTime(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<TimeSpan?> KeyIdleTimeAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public void KeyMigrate(RedisKey key, EndPoint toServer, int toDatabase = 0, int timeoutMilliseconds = 0, MigrateOptions migrateOptions = MigrateOptions.None, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task KeyMigrateAsync(RedisKey key, EndPoint toServer, int toDatabase = 0, int timeoutMilliseconds = 0, MigrateOptions migrateOptions = MigrateOptions.None, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public bool KeyMove(RedisKey key, int database, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<bool> KeyMoveAsync(RedisKey key, int database, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public bool KeyPersist(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            try
            {
                var cacheItem = _cache.GetCacheItem(key);
                cacheItem.Expiration = null;
                _cache.Insert(key, cacheItem);
                return true;
            }
            catch (Exception)
            {
                LogError("Exception occurred while persisting key. Key: {Key}", key);
                return false;
            }
        }

        public Task<bool> KeyPersistAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            return Task.Run(() =>
            {
                return KeyPersist(key, flags);
            });
        }

        public RedisKey KeyRandom(CommandFlags flags = CommandFlags.None)
        {
            try
            {
                if (_cache.Count > 0)
                {
                    IDictionaryEnumerator cacheKeys = (IDictionaryEnumerator)_cache.GetEnumerator();
                    var cacheCount = _cache.Count;
                    Random r = new Random();
                    int randomNumber = r.Next(0, (int)(cacheCount - 1));
                    if (cacheKeys != null)
                    {
                        long index = 0;
                        while (cacheKeys.MoveNext())
                        {
                            if (randomNumber == index)
                                return new RedisKey(cacheKeys.Key.ToString());
                            index++;
                        }
                    }
                }

                return new RedisKey();
            }
            catch (Exception)
            {
                LogError("Exception occurred while getting random key.");
                return new RedisKey();
            }
        }

        public Task<RedisKey> KeyRandomAsync(CommandFlags flags = CommandFlags.None)
        {
            return Task.Run(() =>
            {
                return KeyRandom(flags);
            });
        }

        public bool KeyRename(RedisKey key, RedisKey newKey, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            try
            {
                var cacheItem = _cache.GetCacheItem(key);

                if (cacheItem == null)
                {
                    throw new RedisServerException("ERR no such key");
                }

                _cache.Remove(key);
                _cache.Insert(newKey, cacheItem);
            }
            catch (Exception ex)
            {
                if (ex.Message == "ERR no such key")
                {
                    throw;
                }
                LogError("Exception occurred while renaming key. Key: {Key}, NewKey: {NewKey}, Exception: {Exception}", key, newKey, ex.Message);
                return false;
            }

            return true;
        }

        public Task<bool> KeyRenameAsync(RedisKey key, RedisKey newKey, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            return Task.Run(() =>
            {
                return KeyRename(key, newKey, when, flags);
            });
        }

        public void KeyRestore(RedisKey key, byte[] value, TimeSpan? expiry = null, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task KeyRestoreAsync(RedisKey key, byte[] value, TimeSpan? expiry = null, CommandFlags flags = CommandFlags.None)
        {
            return Task.Run(() =>
            {
                KeyRestore(key, value, expiry, flags);
            });
        }

        public TimeSpan? KeyTimeToLive(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            try
            {
                if (key.IsEmpty)
                    return null;
                var cacheItem = _cache.GetCacheItem(key);
                if (cacheItem == null || cacheItem.Expiration == null || cacheItem.Expiration.ExpireAfter == TimeSpan.Zero)
                    return null;
                return cacheItem.Expiration.ExpireAfter;
            }
            catch (Exception)
            {
                LogError("Exception occurred while getting key time to live. Key: {Key}", key);
                return null;
            }
        }

        public Task<TimeSpan?> KeyTimeToLiveAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            return Task.Run(() =>
            {
                return KeyTimeToLive(key, flags);
            });
        }

        public bool KeyTouch(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            try
            {
                if (_cache.Contains(key))
                {
                    _cache.GetCacheItem(key);
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                LogError("Exception occurred while touching key. Key: {Key}", key);

                return false;
            }
            return true;
        }

        public long KeyTouch(RedisKey[] keys, CommandFlags flags = CommandFlags.None)
        {
            try
            {
                return _cache.GetBulk<Object>(RedisKeysToStringList(keys)).Where(s => s.Value != null).Count();
            }
            catch (Exception)
            {
                LogError("Exception occurred while touching keys. Keys: {Keys}", string.Join(", ", keys));
                return 0;
            }
        }

        public Task<bool> KeyTouchAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            return Task.Run(() =>
            {
                return KeyTouch(key, flags);
            });
        }

        public Task<long> KeyTouchAsync(RedisKey[] keys, CommandFlags flags = CommandFlags.None)
        {
            return Task.Run(() =>
            {
                return KeyTouch(keys, flags);
            });
        }

        public RedisType KeyType(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<RedisType> KeyTypeAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public RedisValue ListGetByIndex(RedisKey key, long index, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<RedisValue> ListGetByIndexAsync(RedisKey key, long index, CommandFlags flags = CommandFlags.None)
        {
            return Task.Run(() =>
            {
                return ListGetByIndex(key, index, flags);
            });
        }

        public long ListInsertAfter(RedisKey key, RedisValue pivot, RedisValue value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> ListInsertAfterAsync(RedisKey key, RedisValue pivot, RedisValue value, CommandFlags flags = CommandFlags.None)
        {
            return Task.Run(() =>
            {
                return ListInsertAfter(key, pivot, value, flags);
            });
        }

        public long ListInsertBefore(RedisKey key, RedisValue pivot, RedisValue value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> ListInsertBeforeAsync(RedisKey key, RedisValue pivot, RedisValue value, CommandFlags flags = CommandFlags.None)
        {
            return Task.Run(() =>
            {
                return ListInsertBefore(key, pivot, value, flags);
            });
        }

        public RedisValue ListLeftPop(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<RedisValue> ListLeftPopAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            return Task.Run(() =>
            {
                return ListLeftPop(key, flags);
            });
        }

        public long ListLeftPush(RedisKey key, RedisValue value, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long ListLeftPush(RedisKey key, RedisValue[] values, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> ListLeftPushAsync(RedisKey key, RedisValue value, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            return Task.Run(() =>
            {
                return ListLeftPush(key, value, when, flags);
            });
        }

        public Task<long> ListLeftPushAsync(RedisKey key, RedisValue[] values, CommandFlags flags = CommandFlags.None)
        {
            return Task.Run(() =>
            {
                return ListLeftPush(key, values, flags);
            });
        }

        public long ListLength(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> ListLengthAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            return Task.Run(() =>
            {
                return ListLength(key, flags);
            });
        }

        public RedisValue[] ListRange(RedisKey key, long start = 0, long stop = -1, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();

        }

        public Task<RedisValue[]> ListRangeAsync(RedisKey key, long start = 0, long stop = -1, CommandFlags flags = CommandFlags.None)
        {
            return Task.Run(() =>
            {
                return ListRange(key, start, stop, flags);
            });
        }

        public long ListRemove(RedisKey key, RedisValue value, long count = 0, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> ListRemoveAsync(RedisKey key, RedisValue value, long count = 0, CommandFlags flags = CommandFlags.None)
        {
            return Task.Run(() =>
            {
                return ListRemove(key, value, count, flags);
            });
        }

        public RedisValue ListRightPop(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<RedisValue> ListRightPopAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            return Task.Run(() =>
            {
                return ListRightPop(key, flags);
            });
        }

        public RedisValue ListRightPopLeftPush(RedisKey source, RedisKey destination, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<RedisValue> ListRightPopLeftPushAsync(RedisKey source, RedisKey destination, CommandFlags flags = CommandFlags.None)
        {
            return Task.Run(() =>
            {
                return ListRightPopLeftPush(source, destination, flags);
            });
        }

        public long ListRightPush(RedisKey key, RedisValue value, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long ListRightPush(RedisKey key, RedisValue[] values, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> ListRightPushAsync(RedisKey key, RedisValue value, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            return Task.Run(() =>
            {
                return ListRightPush(key, value, when, flags);
            });
        }

        public Task<long> ListRightPushAsync(RedisKey key, RedisValue[] values, CommandFlags flags = CommandFlags.None)
        {
            return Task.Run(() =>
            {
                return ListRightPush(key, values, flags);
            });
        }

        public void ListSetByIndex(RedisKey key, long index, RedisValue value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task ListSetByIndexAsync(RedisKey key, long index, RedisValue value, CommandFlags flags = CommandFlags.None)
        {
            return Task.Run(() =>
            {
                ListSetByIndex(key, index, value, flags);
            });
        }

        public void ListTrim(RedisKey key, long start, long stop, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task ListTrimAsync(RedisKey key, long start, long stop, CommandFlags flags = CommandFlags.None)
        {
            return Task.Run(() =>
            {
                ListTrim(key, start, stop, flags);
            });
        }

        public bool LockExtend(RedisKey key, RedisValue token, TimeSpan expiry, CommandFlags flags = CommandFlags.None)
        {

            var current = _cache.Get<string>(key);
            if (current == null || current != token.ToString())
                return false;

            var item = new CacheItem(token.ToString())
            {
                Expiration = new Expiration(ExpirationType.Absolute, expiry)
            };
            _cache.Insert(key, item);
            return true;
        }

        public Task<bool> LockExtendAsync(RedisKey key, RedisValue value, TimeSpan expiry, CommandFlags flags = CommandFlags.None)
        {
            return Task.Run(() =>
            {
                return LockExtend(key, value, expiry, flags);
            });
        }

        public RedisValue LockQuery(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<RedisValue> LockQueryAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public bool LockRelease(RedisKey key, RedisValue token, CommandFlags flags = CommandFlags.None)
        {
            if (_cache.Contains(key))
            {
                var item = _cache.Get<string>(key);
                if (item != null && item.Equals(token.ToString()))
                {
                    _cache.Remove(key);
                    return true;
                }
            }
            LogDebug("Cache does not contain the lock key or the lock token did not match. Key: {Key}, Token: {Token}", key, token);
            return false;
        }

        public Task<bool> LockReleaseAsync(RedisKey key, RedisValue value, CommandFlags flags = CommandFlags.None)
        {
            return Task.Run(() =>
            {
                return LockRelease(key, value);
            });
        }

        public bool LockTake(RedisKey key, RedisValue token, TimeSpan expiry, CommandFlags flags = CommandFlags.None)
        {
            try
            {
                if (_cache.Contains(key))
                {
                    return false;
                }

                CacheItem item = new CacheItem(token.ToString());
                item.Expiration = new Alachisoft.NCache.Runtime.Caching.Expiration(Alachisoft.NCache.Runtime.Caching.ExpirationType.Absolute, expiry);

                _cache.Insert(key, item);
                return true;
            }
            catch (Exception e)
            {
                LogError("Exception occurred while taking lock. Key: {Key}, Token: {Token}, Expiry: {Expiry}, Exception: {Exception}", key, token, expiry, e.Message);
                return false;
            }


        }

        public Task<bool> LockTakeAsync(RedisKey key, RedisValue value, TimeSpan expiry, CommandFlags flags = CommandFlags.None)
        {
            return Task.Run(() =>
            {
                return LockTake(key, value, expiry, flags);
            });
        }

        public TimeSpan Ping(CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<TimeSpan> PingAsync(CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public RedisResult ScriptEvaluate(string script, RedisKey[] keys = null, RedisValue[] values = null, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public RedisResult ScriptEvaluate(byte[] hash, RedisKey[] keys = null, RedisValue[] values = null, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public RedisResult ScriptEvaluate(LuaScript script, object parameters = null, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public RedisResult ScriptEvaluate(LoadedLuaScript script, object parameters = null, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<RedisResult> ScriptEvaluateAsync(string script, RedisKey[] keys = null, RedisValue[] values = null, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<RedisResult> ScriptEvaluateAsync(byte[] hash, RedisKey[] keys = null, RedisValue[] values = null, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<RedisResult> ScriptEvaluateAsync(LuaScript script, object parameters = null, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<RedisResult> ScriptEvaluateAsync(LoadedLuaScript script, object parameters = null, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public bool SetAdd(RedisKey key, RedisValue value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long SetAdd(RedisKey key, RedisValue[] values, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();

        }

        public Task<bool> SetAddAsync(RedisKey key, RedisValue value, CommandFlags flags = CommandFlags.None)
        {
            return Task.Run(() =>
            {
                return SetAdd(key, value, flags);
            });
        }

        public Task<long> SetAddAsync(RedisKey key, RedisValue[] values, CommandFlags flags = CommandFlags.None)
        {
            return Task.Run(() =>
            {
                return SetAdd(key, values, flags);
            });
        }

        public RedisValue[] SetCombine(SetOperation operation, RedisKey first, RedisKey second, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public RedisValue[] SetCombine(SetOperation operation, RedisKey[] keys, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long SetCombineAndStore(SetOperation operation, RedisKey destination, RedisKey first, RedisKey second, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long SetCombineAndStore(SetOperation operation, RedisKey destination, RedisKey[] keys, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> SetCombineAndStoreAsync(SetOperation operation, RedisKey destination, RedisKey first, RedisKey second, CommandFlags flags = CommandFlags.None)
        {
            return Task.Run(() =>
            {
                return SetCombineAndStore(operation, destination, first, second, flags);
            });
        }

        public Task<long> SetCombineAndStoreAsync(SetOperation operation, RedisKey destination, RedisKey[] keys, CommandFlags flags = CommandFlags.None)
        {
            return Task.Run(() =>
            {
                return SetCombineAndStore(operation, destination, keys, flags);
            });
        }

        public Task<RedisValue[]> SetCombineAsync(SetOperation operation, RedisKey first, RedisKey second, CommandFlags flags = CommandFlags.None)
        {
            return Task.Run(() =>
            {
                return SetCombine(operation, first, second, flags);
            });
        }

        public Task<RedisValue[]> SetCombineAsync(SetOperation operation, RedisKey[] keys, CommandFlags flags = CommandFlags.None)
        {
            return Task.Run(() =>
            {
                return SetCombine(operation, keys, flags);
            });
        }

        public bool SetContains(RedisKey key, RedisValue value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<bool> SetContainsAsync(RedisKey key, RedisValue value, CommandFlags flags = CommandFlags.None)
        {
            return Task.Run(() =>
            {
                return SetContains(key, value, flags);
            });
        }

        public long SetLength(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> SetLengthAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            return Task.Run(() =>
            {
                return SetLength(key, flags);
            });
        }

        public RedisValue[] SetMembers(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<RedisValue[]> SetMembersAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            return Task.Run(() =>
            {
                return SetMembers(key, flags);
            });
        }

        public bool SetMove(RedisKey source, RedisKey destination, RedisValue value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<bool> SetMoveAsync(RedisKey source, RedisKey destination, RedisValue value, CommandFlags flags = CommandFlags.None)
        {
            return Task.Run(() =>
            {
                return SetMove(source, destination, value, flags);
            });
        }

        public RedisValue SetPop(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public RedisValue[] SetPop(RedisKey key, long count, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<RedisValue> SetPopAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            return Task.Run(() =>
            {
                return SetPop(key, flags);
            });
        }

        public Task<RedisValue[]> SetPopAsync(RedisKey key, long count, CommandFlags flags = CommandFlags.None)
        {
            return Task.Run(() =>
            {
                return SetPop(key, count, flags);
            });
        }

        public RedisValue SetRandomMember(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<RedisValue> SetRandomMemberAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            return Task.Run(() =>
            {
                return SetRandomMember(key, flags);
            });
        }

        public RedisValue[] SetRandomMembers(RedisKey key, long count, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<RedisValue[]> SetRandomMembersAsync(RedisKey key, long count, CommandFlags flags = CommandFlags.None)
        {
            return Task.Run(() =>
            {
                return SetRandomMembers(key, count, flags);
            });
        }

        public bool SetRemove(RedisKey key, RedisValue value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long SetRemove(RedisKey key, RedisValue[] values, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<bool> SetRemoveAsync(RedisKey key, RedisValue value, CommandFlags flags = CommandFlags.None)
        {
            return Task.Run(() =>
            {
                return SetRemove(key, value, flags);
            });
        }

        public Task<long> SetRemoveAsync(RedisKey key, RedisValue[] values, CommandFlags flags = CommandFlags.None)
        {
            return Task.Run(() =>
            {
                return SetRemove(key, values, flags);
            });
        }

        public IEnumerable<RedisValue> SetScan(RedisKey key, RedisValue pattern, int pageSize, CommandFlags flags)
        {
            throw new NotSupportedException();
        }

        public IEnumerable<RedisValue> SetScan(RedisKey key, RedisValue pattern = default, int pageSize = 250, long cursor = 0, int pageOffset = 0, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public IAsyncEnumerable<RedisValue> SetScanAsync(RedisKey key, RedisValue pattern = default, int pageSize = 250, long cursor = 0, int pageOffset = 0, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public RedisValue[] Sort(RedisKey key, long skip = 0, long take = -1, Order order = Order.Ascending, SortType sortType = SortType.Numeric, RedisValue by = default, RedisValue[] get = null, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long SortAndStore(RedisKey destination, RedisKey key, long skip = 0, long take = -1, Order order = Order.Ascending, SortType sortType = SortType.Numeric, RedisValue by = default, RedisValue[] get = null, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> SortAndStoreAsync(RedisKey destination, RedisKey key, long skip = 0, long take = -1, Order order = Order.Ascending, SortType sortType = SortType.Numeric, RedisValue by = default, RedisValue[] get = null, CommandFlags flags = CommandFlags.None)
        {
            return Task.Run(() =>
            {
                return SortAndStore(destination, key);
            });
        }

        public Task<RedisValue[]> SortAsync(RedisKey key, long skip = 0, long take = -1, Order order = Order.Ascending, SortType sortType = SortType.Numeric, RedisValue by = default, RedisValue[] get = null, CommandFlags flags = CommandFlags.None)
        {
            return Task.Run(() =>
            {
                return Sort(key);
            });
        }

        public bool SortedSetAdd(RedisKey key, RedisValue member, double score, CommandFlags flags)
        {
            throw new NotSupportedException();
        }

        public bool SortedSetAdd(RedisKey key, RedisValue member, double score, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long SortedSetAdd(RedisKey key, SortedSetEntry[] values, CommandFlags flags)
        {
            throw new NotSupportedException();
        }

        public long SortedSetAdd(RedisKey key, SortedSetEntry[] values, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<bool> SortedSetAddAsync(RedisKey key, RedisValue member, double score, CommandFlags flags)
        {
            throw new NotSupportedException();
        }

        public Task<bool> SortedSetAddAsync(RedisKey key, RedisValue member, double score, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> SortedSetAddAsync(RedisKey key, SortedSetEntry[] values, CommandFlags flags)
        {
            throw new NotSupportedException();
        }

        public Task<long> SortedSetAddAsync(RedisKey key, SortedSetEntry[] values, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long SortedSetCombineAndStore(SetOperation operation, RedisKey destination, RedisKey first, RedisKey second, Aggregate aggregate = Aggregate.Sum, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long SortedSetCombineAndStore(SetOperation operation, RedisKey destination, RedisKey[] keys, double[] weights = null, Aggregate aggregate = Aggregate.Sum, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> SortedSetCombineAndStoreAsync(SetOperation operation, RedisKey destination, RedisKey first, RedisKey second, Aggregate aggregate = Aggregate.Sum, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> SortedSetCombineAndStoreAsync(SetOperation operation, RedisKey destination, RedisKey[] keys, double[] weights = null, Aggregate aggregate = Aggregate.Sum, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public double SortedSetDecrement(RedisKey key, RedisValue member, double value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<double> SortedSetDecrementAsync(RedisKey key, RedisValue member, double value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public double SortedSetIncrement(RedisKey key, RedisValue member, double value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<double> SortedSetIncrementAsync(RedisKey key, RedisValue member, double value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long SortedSetLength(RedisKey key, double min = double.NegativeInfinity, double max = double.PositiveInfinity, Exclude exclude = Exclude.None, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> SortedSetLengthAsync(RedisKey key, double min = double.NegativeInfinity, double max = double.PositiveInfinity, Exclude exclude = Exclude.None, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long SortedSetLengthByValue(RedisKey key, RedisValue min, RedisValue max, Exclude exclude = Exclude.None, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> SortedSetLengthByValueAsync(RedisKey key, RedisValue min, RedisValue max, Exclude exclude = Exclude.None, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public SortedSetEntry? SortedSetPop(RedisKey key, Order order = Order.Ascending, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public SortedSetEntry[] SortedSetPop(RedisKey key, long count, Order order = Order.Ascending, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<SortedSetEntry?> SortedSetPopAsync(RedisKey key, Order order = Order.Ascending, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<SortedSetEntry[]> SortedSetPopAsync(RedisKey key, long count, Order order = Order.Ascending, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public RedisValue[] SortedSetRangeByRank(RedisKey key, long start = 0, long stop = -1, Order order = Order.Ascending, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<RedisValue[]> SortedSetRangeByRankAsync(RedisKey key, long start = 0, long stop = -1, Order order = Order.Ascending, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public SortedSetEntry[] SortedSetRangeByRankWithScores(RedisKey key, long start = 0, long stop = -1, Order order = Order.Ascending, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<SortedSetEntry[]> SortedSetRangeByRankWithScoresAsync(RedisKey key, long start = 0, long stop = -1, Order order = Order.Ascending, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public RedisValue[] SortedSetRangeByScore(RedisKey key, double start = double.NegativeInfinity, double stop = double.PositiveInfinity, Exclude exclude = Exclude.None, Order order = Order.Ascending, long skip = 0, long take = -1, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<RedisValue[]> SortedSetRangeByScoreAsync(RedisKey key, double start = double.NegativeInfinity, double stop = double.PositiveInfinity, Exclude exclude = Exclude.None, Order order = Order.Ascending, long skip = 0, long take = -1, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public SortedSetEntry[] SortedSetRangeByScoreWithScores(RedisKey key, double start = double.NegativeInfinity, double stop = double.PositiveInfinity, Exclude exclude = Exclude.None, Order order = Order.Ascending, long skip = 0, long take = -1, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<SortedSetEntry[]> SortedSetRangeByScoreWithScoresAsync(RedisKey key, double start = double.NegativeInfinity, double stop = double.PositiveInfinity, Exclude exclude = Exclude.None, Order order = Order.Ascending, long skip = 0, long take = -1, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public RedisValue[] SortedSetRangeByValue(RedisKey key, RedisValue min, RedisValue max, Exclude exclude, long skip, long take = -1, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public RedisValue[] SortedSetRangeByValue(RedisKey key, RedisValue min = default, RedisValue max = default, Exclude exclude = Exclude.None, Order order = Order.Ascending, long skip = 0, long take = -1, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<RedisValue[]> SortedSetRangeByValueAsync(RedisKey key, RedisValue min, RedisValue max, Exclude exclude, long skip, long take = -1, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<RedisValue[]> SortedSetRangeByValueAsync(RedisKey key, RedisValue min = default, RedisValue max = default, Exclude exclude = Exclude.None, Order order = Order.Ascending, long skip = 0, long take = -1, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long? SortedSetRank(RedisKey key, RedisValue member, Order order = Order.Ascending, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long?> SortedSetRankAsync(RedisKey key, RedisValue member, Order order = Order.Ascending, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public bool SortedSetRemove(RedisKey key, RedisValue member, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long SortedSetRemove(RedisKey key, RedisValue[] members, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<bool> SortedSetRemoveAsync(RedisKey key, RedisValue member, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> SortedSetRemoveAsync(RedisKey key, RedisValue[] members, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long SortedSetRemoveRangeByRank(RedisKey key, long start, long stop, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> SortedSetRemoveRangeByRankAsync(RedisKey key, long start, long stop, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long SortedSetRemoveRangeByScore(RedisKey key, double start, double stop, Exclude exclude = Exclude.None, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> SortedSetRemoveRangeByScoreAsync(RedisKey key, double start, double stop, Exclude exclude = Exclude.None, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long SortedSetRemoveRangeByValue(RedisKey key, RedisValue min, RedisValue max, Exclude exclude = Exclude.None, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> SortedSetRemoveRangeByValueAsync(RedisKey key, RedisValue min, RedisValue max, Exclude exclude = Exclude.None, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public IEnumerable<SortedSetEntry> SortedSetScan(RedisKey key, RedisValue pattern, int pageSize, CommandFlags flags)
        {
            throw new NotSupportedException();
        }

        public IEnumerable<SortedSetEntry> SortedSetScan(RedisKey key, RedisValue pattern = default, int pageSize = 250, long cursor = 0, int pageOffset = 0, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public IAsyncEnumerable<SortedSetEntry> SortedSetScanAsync(RedisKey key, RedisValue pattern = default, int pageSize = 250, long cursor = 0, int pageOffset = 0, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public double? SortedSetScore(RedisKey key, RedisValue member, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<double?> SortedSetScoreAsync(RedisKey key, RedisValue member, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long StreamAcknowledge(RedisKey key, RedisValue groupName, RedisValue messageId, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long StreamAcknowledge(RedisKey key, RedisValue groupName, RedisValue[] messageIds, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> StreamAcknowledgeAsync(RedisKey key, RedisValue groupName, RedisValue messageId, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> StreamAcknowledgeAsync(RedisKey key, RedisValue groupName, RedisValue[] messageIds, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public RedisValue StreamAdd(RedisKey key, RedisValue streamField, RedisValue streamValue, RedisValue? messageId = null, int? maxLength = null, bool useApproximateMaxLength = false, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public RedisValue StreamAdd(RedisKey key, NameValueEntry[] streamPairs, RedisValue? messageId = null, int? maxLength = null, bool useApproximateMaxLength = false, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<RedisValue> StreamAddAsync(RedisKey key, RedisValue streamField, RedisValue streamValue, RedisValue? messageId = null, int? maxLength = null, bool useApproximateMaxLength = false, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<RedisValue> StreamAddAsync(RedisKey key, NameValueEntry[] streamPairs, RedisValue? messageId = null, int? maxLength = null, bool useApproximateMaxLength = false, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public StreamEntry[] StreamClaim(RedisKey key, RedisValue consumerGroup, RedisValue claimingConsumer, long minIdleTimeInMs, RedisValue[] messageIds, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<StreamEntry[]> StreamClaimAsync(RedisKey key, RedisValue consumerGroup, RedisValue claimingConsumer, long minIdleTimeInMs, RedisValue[] messageIds, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public RedisValue[] StreamClaimIdsOnly(RedisKey key, RedisValue consumerGroup, RedisValue claimingConsumer, long minIdleTimeInMs, RedisValue[] messageIds, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<RedisValue[]> StreamClaimIdsOnlyAsync(RedisKey key, RedisValue consumerGroup, RedisValue claimingConsumer, long minIdleTimeInMs, RedisValue[] messageIds, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public bool StreamConsumerGroupSetPosition(RedisKey key, RedisValue groupName, RedisValue position, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<bool> StreamConsumerGroupSetPositionAsync(RedisKey key, RedisValue groupName, RedisValue position, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public StreamConsumerInfo[] StreamConsumerInfo(RedisKey key, RedisValue groupName, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<StreamConsumerInfo[]> StreamConsumerInfoAsync(RedisKey key, RedisValue groupName, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public bool StreamCreateConsumerGroup(RedisKey key, RedisValue groupName, RedisValue? position, CommandFlags flags)
        {
            throw new NotSupportedException();
        }

        public bool StreamCreateConsumerGroup(RedisKey key, RedisValue groupName, RedisValue? position = null, bool createStream = true, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<bool> StreamCreateConsumerGroupAsync(RedisKey key, RedisValue groupName, RedisValue? position, CommandFlags flags)
        {
            throw new NotSupportedException();
        }

        public Task<bool> StreamCreateConsumerGroupAsync(RedisKey key, RedisValue groupName, RedisValue? position = null, bool createStream = true, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long StreamDelete(RedisKey key, RedisValue[] messageIds, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> StreamDeleteAsync(RedisKey key, RedisValue[] messageIds, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long StreamDeleteConsumer(RedisKey key, RedisValue groupName, RedisValue consumerName, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> StreamDeleteConsumerAsync(RedisKey key, RedisValue groupName, RedisValue consumerName, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public bool StreamDeleteConsumerGroup(RedisKey key, RedisValue groupName, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<bool> StreamDeleteConsumerGroupAsync(RedisKey key, RedisValue groupName, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public StreamGroupInfo[] StreamGroupInfo(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<StreamGroupInfo[]> StreamGroupInfoAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public StreamInfo StreamInfo(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<StreamInfo> StreamInfoAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long StreamLength(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> StreamLengthAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public StreamPendingInfo StreamPending(RedisKey key, RedisValue groupName, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<StreamPendingInfo> StreamPendingAsync(RedisKey key, RedisValue groupName, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public StreamPendingMessageInfo[] StreamPendingMessages(RedisKey key, RedisValue groupName, int count, RedisValue consumerName, RedisValue? minId = null, RedisValue? maxId = null, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<StreamPendingMessageInfo[]> StreamPendingMessagesAsync(RedisKey key, RedisValue groupName, int count, RedisValue consumerName, RedisValue? minId = null, RedisValue? maxId = null, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public StreamEntry[] StreamRange(RedisKey key, RedisValue? minId = null, RedisValue? maxId = null, int? count = null, Order messageOrder = Order.Ascending, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<StreamEntry[]> StreamRangeAsync(RedisKey key, RedisValue? minId = null, RedisValue? maxId = null, int? count = null, Order messageOrder = Order.Ascending, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public StreamEntry[] StreamRead(RedisKey key, RedisValue position, int? count = null, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public RedisStream[] StreamRead(StreamPosition[] streamPositions, int? countPerStream = null, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<StreamEntry[]> StreamReadAsync(RedisKey key, RedisValue position, int? count = null, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<RedisStream[]> StreamReadAsync(StreamPosition[] streamPositions, int? countPerStream = null, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public StreamEntry[] StreamReadGroup(RedisKey key, RedisValue groupName, RedisValue consumerName, RedisValue? position, int? count, CommandFlags flags)
        {
            throw new NotSupportedException();
        }

        public StreamEntry[] StreamReadGroup(RedisKey key, RedisValue groupName, RedisValue consumerName, RedisValue? position = null, int? count = null, bool noAck = false, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public RedisStream[] StreamReadGroup(StreamPosition[] streamPositions, RedisValue groupName, RedisValue consumerName, int? countPerStream, CommandFlags flags)
        {
            throw new NotSupportedException();
        }

        public RedisStream[] StreamReadGroup(StreamPosition[] streamPositions, RedisValue groupName, RedisValue consumerName, int? countPerStream = null, bool noAck = false, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<StreamEntry[]> StreamReadGroupAsync(RedisKey key, RedisValue groupName, RedisValue consumerName, RedisValue? position, int? count, CommandFlags flags)
        {
            throw new NotSupportedException();
        }

        public Task<StreamEntry[]> StreamReadGroupAsync(RedisKey key, RedisValue groupName, RedisValue consumerName, RedisValue? position = null, int? count = null, bool noAck = false, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<RedisStream[]> StreamReadGroupAsync(StreamPosition[] streamPositions, RedisValue groupName, RedisValue consumerName, int? countPerStream, CommandFlags flags)
        {
            throw new NotSupportedException();
        }

        public Task<RedisStream[]> StreamReadGroupAsync(StreamPosition[] streamPositions, RedisValue groupName, RedisValue consumerName, int? countPerStream = null, bool noAck = false, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long StreamTrim(RedisKey key, int maxLength, bool useApproximateMaxLength = false, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> StreamTrimAsync(RedisKey key, int maxLength, bool useApproximateMaxLength = false, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long StringAppend(RedisKey key, RedisValue value, CommandFlags flags = CommandFlags.None)
        {
            var str = _cache.Contains(key) ? _cache.Get<object>(key) : null;

            try
            {
                if (str == null)
                {
                    str = value;
                    _cache.Add(key, str);
                }
                else
                {
                    str += value;
                    _cache.Insert(key, str);
                }
            }
            catch (Exception e)
            {
                LogError("Exception occurred while appending string. Key: {Key}, Value: {Value}. Exception: {Exception}", key, value, e);

            }
            return str.ToString().Length;
        }

        public Task<long> StringAppendAsync(RedisKey key, RedisValue value, CommandFlags flags = CommandFlags.None)
        {
            return Task.Run(() =>
            {
                return StringAppend(key, value, flags);
            });
        }
        static int countSetBits(char n)
        {
            int count = 0;
            while (n > 0)
            {
                count += n & 1;
                n >>= 1;
            }
            return count;
        }
        public long StringBitCount(RedisKey key, long start = 0, long end = -1, CommandFlags flags = CommandFlags.None)
        {
            string str = RedisValue.Unbox(_cache.Get<object>(key));
            try
            {
                if(str != null)
                {
                    int bitSetCount = 0;
                    for (long i = start; i <( end < 0 ? str.Length : end); i++)
                    {
                        bitSetCount += countSetBits(str[(int)i]);
                    }
                    return bitSetCount;
                }
            }
            catch (Exception)
            {
            }
            return 0;
        }

        public Task<long> StringBitCountAsync(RedisKey key, long start = 0, long end = -1, CommandFlags flags = CommandFlags.None)
        {
            return Task.Run(() =>
            {
                return StringBitCount(key, start, end, flags);
            });
        }

        public long StringBitOperation(Bitwise operation, RedisKey destination, RedisKey first, RedisKey second = default, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long StringBitOperation(Bitwise operation, RedisKey destination, RedisKey[] keys, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> StringBitOperationAsync(Bitwise operation, RedisKey destination, RedisKey first, RedisKey second = default, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> StringBitOperationAsync(Bitwise operation, RedisKey destination, RedisKey[] keys, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long StringBitPosition(RedisKey key, bool bit, long start = 0, long end = -1, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> StringBitPositionAsync(RedisKey key, bool bit, long start = 0, long end = -1, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long StringIncrement(RedisKey key, long value = 1, CommandFlags flags = CommandFlags.None)
        {

            try
            {
                long n = value;
                if (_cache.Contains(key))
                {
                    n = int.Parse(RedisValue.Unbox(_cache.Get<object>(key)));
                    n += value;
                }

                _cache.Insert(key, n.ToString());
                return n;
            }
            catch (Exception)
            {
                LogError(
                    "Exception occurred while incrementing string. Key: {Key}, Value: {Value}",
                    key,
                    value);
                throw;
            }
        }

        public double StringIncrement(RedisKey key, double value, CommandFlags flags = CommandFlags.None)
        {
            try
            {
                double n = value;
                if (_cache.Contains(key))
                {
                    n = double.Parse(RedisValue.Unbox(_cache.Get<object>(key)));
                    n += value;
                }

                _cache.Insert(key, n.ToString());
                return n;
            }
            catch (Exception)
            {
                LogError(
                    "Exception occurred while incrementing string. Key: {Key}, Value: {Value}",
                    key,
                    value);
                throw;
            }
        }

        public Task<long> StringIncrementAsync(RedisKey key, long value = 1, CommandFlags flags = CommandFlags.None)
        {
            return Task.Run(() =>
            {
                return StringIncrement(key, value, flags);
            });
        }

        public Task<double> StringIncrementAsync(RedisKey key, double value, CommandFlags flags = CommandFlags.None)
        {
            return Task.Run(() =>
            {
                return StringIncrement(key, value, flags);
            });
        }

        public Task<long> StringDecrementAsync(RedisKey key, long value = 1, CommandFlags flags = CommandFlags.None)
        {
            return Task.Run((Func<long>)(() =>
            {
                return (long)this.StringDecrement(key, value, flags);
            }));
        }

        public Task<double> StringDecrementAsync(RedisKey key, double value, CommandFlags flags = CommandFlags.None)
        {
            return Task.Run((Func<double>)(() =>
            {
                return this.StringDecrement(key, value, flags);
            }));
        }

        public RedisValue StringGet(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            var obj = _cache.Get<Object>(key.ToString());
            return RedisValue.Unbox(obj);
        }

        public RedisValue[] StringGet(RedisKey[] keys, CommandFlags flags = CommandFlags.None)
        {
            try
            {
                var keysValues = _cache.GetBulk<object>(RedisKeysToStringList(keys));
                RedisValue[] redisValues = new RedisValue[keysValues.Count];
                for (int i = 0; i < keysValues.Count; i++)
                {
                    redisValues[i] = RedisValue.Unbox(keysValues[keys[i].ToString()]);
                }
                return redisValues;
            }
            catch (Exception)
            {
                LogError(
                    "Exception occurred while getting multiple string values. Keys: {Keys}",
                    string.Join(", ", keys));
                return null;
            };
        }

        public Task<RedisValue> StringGetAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            return Task.Run(() =>
            {
                return StringGet(key, flags);
            });
        }

        public Task<RedisValue[]> StringGetAsync(RedisKey[] keys, CommandFlags flags = CommandFlags.None)
        {
            return Task.Run(() =>
            {
                return StringGet(keys, flags);
            });
        }

        public bool StringGetBit(RedisKey key, long offset, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<bool> StringGetBitAsync(RedisKey key, long offset, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Lease<byte> StringGetLease(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<Lease<byte>> StringGetLeaseAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public RedisValue StringGetRange(RedisKey key, long start, long end, CommandFlags flags = CommandFlags.None)
        {
            RedisValue ret = new RedisValue();
            try
            {
                var value = _cache.Get<object>(key);
                if (value != null)
                {
                    var val = (string)RedisValue.Unbox(value);
                    if (start < 0 || start > val.Length)
                    {
                        return String.Empty;
                    }
                    ret = val.Substring((int)start, (int)(end < 0 ? end < -val.Length ? 1 : val.Length + end + 1 : end > val.Length ? val.Length : end + 1));
                }
            }
            catch (Exception)
            {

                LogError("An exception occurred while getting a range of string value. Key: " + key + ", Start: " + start + ", End: " + end);
            }

            return ret;
        }

        public Task<RedisValue> StringGetRangeAsync(RedisKey key, long start, long end, CommandFlags flags = CommandFlags.None)
        {
            return Task.Run(() =>
            {
                return StringGetRange(key, start, end, flags);
            });
        }

        public RedisValue StringGetSet(RedisKey key, RedisValue value, CommandFlags flags = CommandFlags.None)
        {
            var val = new RedisValue();
            try
            {
                val = RedisValue.Unbox(_cache.Get<object>(key));
                _cache.Insert(key, value.Box());
            }
            catch (Exception)
            {
                LogError("An exception occurred while getting and setting string value. Key: " + key + ", Value: " + value);
            }

            return val;
        }

        public Task<RedisValue> StringGetSetAsync(RedisKey key, RedisValue value, CommandFlags flags = CommandFlags.None)
        {
            return Task.Run(() =>
            {
                return StringGetSet(key, value, flags);
            });
        }

        public RedisValueWithExpiry StringGetWithExpiry(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            RedisValue redisValue = new RedisValue();

            try
            {
                CacheItem cacheItem = _cache.GetCacheItem(key);
                if (cacheItem != null)
                {
                    redisValue = RedisValue.Unbox(cacheItem.GetValue<object>());
                    TimeSpan? expiry = null;
                    if (cacheItem.Expiration != null)
                    {
                        expiry = cacheItem.Expiration.ExpireAfter;
                    }
                    return new RedisValueWithExpiry(redisValue, expiry);


                }
            }
            catch (Exception e)
            {
                LogError("Exception occurred while incrementing string. Key: {Key}, Value: {Value}", key, e.Message);
            }
            return new RedisValueWithExpiry();
        }

        public Task<RedisValueWithExpiry> StringGetWithExpiryAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            return Task.Run(() =>
            {
                return StringGetWithExpiry(key, flags);
            });
        }

        public bool StringSetWithExpiry(RedisKey key, RedisValue value, TimeSpan expiry, CommandFlags flags = CommandFlags.None)
        {
            return StringSet(key, value, expiry);
        }

        public Task<bool> StringSetWithExpiryAsync(RedisKey key, RedisValue value, TimeSpan expiry, CommandFlags flags = CommandFlags.None)
        {
            return Task.Run(() =>
            {
                return StringSetWithExpiry(key, value, expiry, flags);
            });
        }

        public long StringDecrement(RedisKey key, long value = 1, CommandFlags flags = CommandFlags.None)
        {
            return StringIncrement(key, -value, flags);
        }

        public double StringDecrement(RedisKey key, double value, CommandFlags flags = CommandFlags.None)
        {
            return StringIncrement(key, -value, flags);
        }

        public long StringLength(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            try
            {
                var item = _cache.Get<object>(key);

                if (item == null)
                {
                    return 0;
                }
                else
                {
                    return item.ToString().Length;
                }
            }
            catch (Exception)
            {
                LogError("Exception occurred while getting string length. Key: {Key}", key);
                return 0;
            }
        }

        public Task<long> StringLengthAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            return Task.Run(() =>
            {
                return StringLength(key, flags);
            });
        }


        public bool StringSet(RedisKey key, RedisValue value, TimeSpan? expiry = null, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            try
            {
                var cacheItem = new CacheItem(value.Box());
                switch (when)
                {
                    case When.Always:

                        if (expiry != null)
                        {
                            cacheItem.Expiration = new Alachisoft.NCache.Runtime.Caching.Expiration(Alachisoft.NCache.Runtime.Caching.ExpirationType.Sliding, expiry.Value);
                        }
                        _cache.Insert(key, cacheItem);
                        break;

                    case When.Exists:
                        if (_cache.Contains(key))
                        {
                            cacheItem = new CacheItem(value.Box());
                            if (expiry != null)
                            {
                                cacheItem.Expiration = new Alachisoft.NCache.Runtime.Caching.Expiration(Alachisoft.NCache.Runtime.Caching.ExpirationType.Sliding, expiry.Value);
                            }
                            _cache.Insert(key, cacheItem);
                        }
                        else
                        {
                            return false;
                        }
                        break;

                    case When.NotExists:
                        if (!_cache.Contains(key))
                        {
                            cacheItem = new CacheItem(value.Box());
                            if (expiry != null)
                            {
                                cacheItem.Expiration = new Alachisoft.NCache.Runtime.Caching.Expiration(Alachisoft.NCache.Runtime.Caching.ExpirationType.Sliding, expiry.Value);
                            }
                            _cache.Insert(key, cacheItem);
                        }
                        else
                        {
                            return false;
                        }
                        break;

                    default:
                        break;
                }
                return true;
            }
            catch (Exception)
            {
                LogError("Exception occurred while setting string value. Key: {Key}, Value: {Value}, Expiry: {Expiry}, When: {When}", key, value, expiry, when);
                return false;
            }
        }

        public bool StringSet(KeyValuePair<RedisKey, RedisValue>[] values, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            try
            {
                if (when == When.Exists)
                {
                    throw new ArgumentException("Exists is not valid in this context; the permitted values are: Always, NotExists");
                }

                RedisKey[] keys = new RedisKey[values.Count()];
                IDictionary<string, CacheItem> items = new Dictionary<string, CacheItem>();
                for (int i = 0; i < values.Count(); i++)
                {
                    keys[i] = values[i].Key;
                    items.Add(values[i].Key.ToString(), new CacheItem(values[i].Value.Box()));
                }

                switch (when)
                {
                    case When.Always:
                        _cache.InsertBulk(items);
                        break;

                    case When.Exists:
                        var exists = _cache.ContainsBulk(RedisKeysToStringList(keys));

                        if (exists.Where(s => s.Value == true).Count() > 0)
                        {
                            _cache.InsertBulk(items);
                        }
                        else
                        {
                            return false;
                        }
                        break;

                    case When.NotExists:
                        var contains = _cache.ContainsBulk(RedisKeysToStringList(keys));
                        if (contains.Where(s => s.Value == true).Count() > 0)
                        {
                            return false;
                        }
                        _cache.InsertBulk(items);
                        break;

                    default:
                        break;
                }
                return true;
            }
            catch (Exception ex)
            {
                LogError("Exception occurred while setting multiple string values. When: {When}, Exception: {Exception}", when, ex.Message);

                if (ex.Message == "Exists is not valid in this context; the permitted values are: Always, NotExists")
                {
                    throw;
                }

                return false;
            }
        }

        public Task<bool> StringSetAsync(RedisKey key, RedisValue value, TimeSpan? expiry = null, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            return Task.Run(() =>
            {
                return StringSet(key, value, expiry, when, flags);
            });
        }

        public Task<bool> StringSetAsync(KeyValuePair<RedisKey, RedisValue>[] values, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            return Task.Run(() =>
            {
                return StringSet(values, when, flags);
            });
        }

        public bool StringSetBit(RedisKey key, long offset, bool bit, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<bool> StringSetBitAsync(RedisKey key, long offset, bool bit, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public RedisValue StringSetRange(RedisKey key, long offset, RedisValue value, CommandFlags flags = CommandFlags.None)
        {
            if (offset < 0)
                throw new ArgumentOutOfRangeException(nameof(offset));
            try
            {

                string current = RedisValue.Unbox(_cache.Get<object>(key));
                if (current.Equals(string.Empty) || current == null)
                {
                    return 0;
                }
                string append = value.ToString();

                int requiredLength = (int)Math.Max(current.Length, offset + append.Length);

                char[] buffer = new string('\0', requiredLength).ToCharArray();

                current.CopyTo(0, buffer, 0, current.Length);

                append.CopyTo(0, buffer, (int)offset, append.Length);

                string result = new string(buffer);

                _cache.Insert(key, result);

                return result.Length;
            }
            catch (Exception)
            {
                LogError("Exception occurred while setting string range. Key: {Key}, Offset: {Offset}, Value: {Value}", key, offset, value);
                return 0;
            }
        }

        public Task<RedisValue> StringSetRangeAsync(RedisKey key, long offset, RedisValue value, CommandFlags flags = CommandFlags.None)
        {
            return Task.Run(() =>
            {
                return StringSetRange(key, offset, value, flags);
            });
        }

        public bool TryWait(Task task)
        {
            throw new NotSupportedException();
        }

        public void Wait(Task task)
        {
            throw new NotSupportedException();
        }

        public T Wait<T>(Task<T> task)
        {
            throw new NotSupportedException();
        }

        public void WaitAll(params Task[] tasks)
        {
            throw new NotSupportedException();
        }

        private void LogInfo(string message, params object[] args)
        {
            _logger?.LogInformation(message, args);
        }

        private void LogDebug(string message, params object[] args)
        {
            _logger?.LogDebug(message, args);
        }

        private void LogError(string message, params object[] args)
        {
            _logger?.LogError(message, args);
        }


    }
}
