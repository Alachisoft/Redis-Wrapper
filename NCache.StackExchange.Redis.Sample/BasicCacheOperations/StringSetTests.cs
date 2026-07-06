using System;
using System.Collections.Generic;
using System.Text;
using BasicUsageStackExchangeRedis;
using NCache.OSS.StackExchange.Redis.Sample;

namespace NCache.OSS.StackExchange.Redis.Sample.BasicCacheOperations
{
    class StringSetTests
    {

        //------------------------------------------------Sync Methods------------------------------------------------\\

        public static void AddKeyValuePair()
        {
            try
            {
                Logger.PrintTestStartInformation("Adding non-existing key-value pair into cache");

                var key = Guid.NewGuid().ToString();
                var result = Program.db.StringSet(key, Program.myObjectForCaching);

                if (result)
                {
                    Logger.PrintSuccessfulOutcome("Item successfully added to cache");
                }
                else
                {
                    Logger.PrintFailureOutcome("Unable to add item to cache");
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

        public static void AddExistingKeyValuePair()
        {
            try
            {
                Logger.PrintTestStartInformation("Adding already existing key-value pair into cache");

                var key = Guid.NewGuid().ToString();
                var result = Program.db.StringSet(key, Program.myObjectForCaching);

                result = Program.db.StringSet(key, Program.myObjectForCaching);

                if (result)
                {
                    Logger.PrintSuccessfulOutcome("Item successfully added to cache");
                }
                else
                {
                    Logger.PrintFailureOutcome("Unable to add item to cache");
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

        public static void SetKeyValuePairWithExpiry()
        {
            try
            {
                Logger.PrintTestStartInformation("Adding key-value pair with expiry into cache");
                var key = Guid.NewGuid().ToString();
                var result = Program.db.StringSetWithExpiry(key, Program.myObjectForCaching, TimeSpan.FromSeconds(30));
                if (result)
                {
                    Logger.PrintSuccessfulOutcome("Item successfully added to cache with expiry");
                }
                else
                {
                    Logger.PrintFailureOutcome("Unable to add item to cache with expiry");
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

        public static void SetExistingKeyWithNewValueAndExpiry()
        {
            try
            {
                Logger.PrintTestStartInformation("Adding already existing key-value pair with new value and expiry into cache");
                var key = Guid.NewGuid().ToString();
                Program.db.StringSet(key, Program.myObjectForCaching);
                var result = Program.db.StringSetWithExpiry(key, Program.myObjectForCaching, TimeSpan.FromSeconds(30));
                if (result)
                {
                    Logger.PrintSuccessfulOutcome("Item successfully updated with expiry");
                }
                else
                {
                    Logger.PrintFailureOutcome("Unable to update item in cache with expiry");
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

        public static void SetKeyValuePairWithExpiryAsync()
        {
            try
            {
                Logger.PrintTestStartInformation("Adding key-value pair with expiry Asynchronously into cache");
                var key = Guid.NewGuid().ToString();
                var result = Program.db.StringSetWithExpiryAsync(key, Program.myObjectForCaching, TimeSpan.FromSeconds(30));
                result.Wait();
                if (result.Result)
                {
                    Logger.PrintSuccessfulOutcome("Item successfully added to cache with expiry");
                }
                else
                {
                    Logger.PrintFailureOutcome("Unable to add item to cache with expiry");
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


        public static void AddKeyValuePairAsync()
        {
            try
            {
                Logger.PrintTestStartInformation("Adding non-existing key-value pair Asynchronously into cache");

                var key = Guid.NewGuid().ToString();
                var result = Program.db.StringSetAsync(key, Program.myObjectForCaching);

                result.Wait();

                if (result.Result)
                {
                    Logger.PrintSuccessfulOutcome("Item successfully added to cache");
                }
                else
                {
                    Logger.PrintFailureOutcome("Unable to add item to cache");
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

        public static void AddExistingKeyValuePairAsync()
        {
            try
            {
                Logger.PrintTestStartInformation("Adding already existing key-value pair Asynchronously into cache");

                var key = Guid.NewGuid().ToString();
                Program.db.StringSet(key, Program.myObjectForCaching);

                var result = Program.db.StringSetAsync(key, Program.myObjectForCaching);

                result.Wait();

                if (result.Result)
                {
                    Logger.PrintSuccessfulOutcome("Item successfully added to cache");
                }
                else
                {
                    Logger.PrintFailureOutcome("Unable to add item to cache");
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
