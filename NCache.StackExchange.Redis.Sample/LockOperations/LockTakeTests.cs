using BasicUsageStackExchangeRedis;
using System;
using System.Collections.Generic;
using System.Text;
using NCache.OSS.StackExchange.Redis.Sample;

namespace NCache.OSS.StackExchange.Redis.Sample.LockOperations
{
    class LockTakeTests
    {

        //------------------------------------------------Sync Methods------------------------------------------------\\


        public static void LockTakeOnNonExistingKey()
        {
            try
            {
                Logger.PrintTestStartInformation("Taking lock on non-existing key");
                var key = Guid.NewGuid().ToString();
                var token = Guid.NewGuid().ToString();
                var result = Program.db.LockTake(key, token, TimeSpan.FromSeconds(10));
                if (result)
                {
                    Logger.PrintSuccessfulOutcome("Successfully acquired lock on non-existing key");
                }
                else
                {
                    Logger.PrintFailureOutcome("Unable to acquire lock on non-existing key");
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

        public static void LockTakeOnAlreadyLockedKey()
        {
            try
            {
                Logger.PrintTestStartInformation("Taking lock on already locked key");
                var key = Guid.NewGuid().ToString();
                var token1 = Guid.NewGuid().ToString();
                var token2 = Guid.NewGuid().ToString();

                // first lock
                Program.db.LockTake(key, token1, TimeSpan.FromSeconds(10));

                // second lock attempt should fail
                var result = Program.db.LockTake(key, token2, TimeSpan.FromSeconds(10));
                if (!result)
                {
                    Logger.PrintSuccessfulOutcome("Correctly failed to acquire lock on already locked key");
                }
                else
                {
                    Logger.PrintFailureOutcome("Incorrectly acquired lock on already locked key");
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


        public static void LockTakeOnNonExistingKeyAsync()
        {
            try
            {
                Logger.PrintTestStartInformation("Asynchronously taking lock on non-existing key");
                var key = Guid.NewGuid().ToString();
                var token = Guid.NewGuid().ToString();
                var result = Program.db.LockTakeAsync(key, token, TimeSpan.FromSeconds(10)).Result;
                if (result)
                {
                    Logger.PrintSuccessfulOutcome("Successfully acquired lock on non-existing key");
                }
                else
                {
                    Logger.PrintFailureOutcome("Unable to acquire lock on non-existing key");
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

        public static void LockTakeOnAlreadyLockedKeyAsync()
        {
            try
            {
                Logger.PrintTestStartInformation("Asynchronously taking lock on already locked key");
                var key = Guid.NewGuid().ToString();
                var token1 = Guid.NewGuid().ToString();
                var token2 = Guid.NewGuid().ToString();

                Program.db.LockTakeAsync(key, token1, TimeSpan.FromSeconds(10)).Wait();

                var result = Program.db.LockTakeAsync(key, token2, TimeSpan.FromSeconds(10)).Result;
                if (!result)
                {
                    Logger.PrintSuccessfulOutcome("Correctly failed to acquire lock on already locked key");
                }
                else
                {
                    Logger.PrintFailureOutcome("Incorrectly acquired lock on already locked key");
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
