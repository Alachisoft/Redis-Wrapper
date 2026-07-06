using BasicUsageStackExchangeRedis;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using NCache.OSS.StackExchange.Redis.Sample;

namespace NCache.OSS.StackExchange.Redis.Sample.KeyOperations
{
    class KeyTimeToLiveTests
    {

        //------------------------------------------------Sync Methods------------------------------------------------\\

        public static void KeyTimeToLiveOfExistingKey()
        {
            try
            {
                Logger.PrintTestStartInformation("Getting time to live of an existing key in cache");
                var key = Guid.NewGuid().ToString();
                Program.db.StringSet(key, Program.myObjectForCaching, TimeSpan.FromMinutes(5));
                TimeSpan? result = Program.db.KeyTimeToLive(key);
                if (result.HasValue)
                {
                    Logger.PrintSuccessfulOutcome($"Successfully got time to live of the key in cache. Time to live: {result}");
                }
                else
                {
                    Logger.PrintFailureOutcome("Unable to get time to live of the key in cache");
                }
            }
            catch (Exception e)
            {
                Logger.PrintDataCacheException(e);
            }
            finally
            {
                Logger.PrintBreakLine();
            }
        }

        public static void KeyTimeToLiveReturnsNullForKeyWithNoExpiration()
        {

            try
            {
                Logger.PrintTestStartInformation("Getting time to live of an existing key in cache");
                var key = Guid.NewGuid().ToString();
                Program.db.StringSet(key, Program.myObjectForCaching);
                TimeSpan? result = Program.db.KeyTimeToLive(key);
                if (result == null)
                {
                    Logger.PrintSuccessfulOutcome($"Key time to live is null. Time to live: {result}");
                }
                else
                {
                    Logger.PrintFailureOutcome("Key TTL was not null");
                }
            }
            catch (Exception e)
            {
                Logger.PrintDataCacheException(e);
            }
            finally
            {
                Logger.PrintBreakLine();
            }
        }


        //------------------------------------------------Async Methods------------------------------------------------\\

        public static void KeyTimeToLiveAsyncOfExistingKey()
        {
            try
            {
                Logger.PrintTestStartInformation("Getting time to live of an existing key in cache");
                var key = Guid.NewGuid().ToString();
                Program.db.StringSet(key, Program.myObjectForCaching, TimeSpan.FromMinutes(5));
                TimeSpan? result = Program.db.KeyTimeToLiveAsync(key).Result;
                if (result.HasValue)
                {
                    Logger.PrintSuccessfulOutcome($"Successfully got time to live of the key in cache. Time to live: {result}");
                }
                else
                {
                    Logger.PrintFailureOutcome("Unable to get time to live of the key in cache");
                }
            }
            catch (Exception e)
            {
                Logger.PrintDataCacheException(e);
            }
            finally
            {
                Logger.PrintBreakLine();

            }


        }
    }
}
