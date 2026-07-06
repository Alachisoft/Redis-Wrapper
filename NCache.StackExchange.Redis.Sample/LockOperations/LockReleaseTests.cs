using BasicUsageStackExchangeRedis;
using System;
using System.Collections.Generic;
using System.Text;
using NCache.OSS.StackExchange.Redis.Sample;

namespace NCache.OSS.StackExchange.Redis.Sample.LockOperations
{
    class LockReleaseTests
    {
        //------------------------------------------------Sync Methods------------------------------------------------\\

        public static void LockReleaseWithCorrectToken()
        {
            try
            {
                Logger.PrintTestStartInformation("Releasing lock with correct token");
                var key = Guid.NewGuid().ToString();
                var token = Guid.NewGuid().ToString();

                Program.db.LockTake(key, token, TimeSpan.FromSeconds(10));
                var result = Program.db.LockRelease(key, token);
                if (result)
                {
                    Logger.PrintSuccessfulOutcome("Successfully released lock with correct token");
                }
                else
                {
                    Logger.PrintFailureOutcome("Unable to release lock with correct token");
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

        public static void LockReleaseWithIncorrectToken()
        {
            try
            {
                Logger.PrintTestStartInformation("Releasing lock with incorrect token");
                var key = Guid.NewGuid().ToString();
                var correctToken = Guid.NewGuid().ToString();
                var wrongToken = Guid.NewGuid().ToString();

                Program.db.LockTake(key, correctToken, TimeSpan.FromSeconds(10));
                var result = Program.db.LockRelease(key, wrongToken);
                if (!result)
                {
                    Logger.PrintSuccessfulOutcome("Correctly refused to release lock with wrong token");
                }
                else
                {
                    Logger.PrintFailureOutcome("Incorrectly released lock with wrong token");
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


        public static void LockReleaseAllowsRetake()
        {
            try
            {
                Logger.PrintTestStartInformation("Verifying lock can be retaken after release");
                var key = Guid.NewGuid().ToString();
                var token1 = Guid.NewGuid().ToString();
                var token2 = Guid.NewGuid().ToString();

                Program.db.LockTake(key, token1, TimeSpan.FromSeconds(10));
                Program.db.LockRelease(key, token1);

                // After release a new caller should be able to take the lock
                var result = Program.db.LockTake(key, token2, TimeSpan.FromSeconds(10));
                if (result)
                {
                    Logger.PrintSuccessfulOutcome("Successfully retook lock after it was released");
                }
                else
                {
                    Logger.PrintFailureOutcome("Unable to retake lock after release");
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


        public static void LockReleaseWithCorrectTokenAsync()
        {
            try
            {
                Logger.PrintTestStartInformation("Releasing lock with correct token using async method");
                var key = Guid.NewGuid().ToString();
                var token = Guid.NewGuid().ToString();
                Program.db.LockTake(key, token, TimeSpan.FromSeconds(10));
                var result = Program.db.LockReleaseAsync(key, token).Result;
                if (result)
                {
                    Logger.PrintSuccessfulOutcome("Successfully released lock with correct token using async method");
                }
                else
                {
                    Logger.PrintFailureOutcome("Unable to release lock with correct token using async method");
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

        public static void LockReleaseWithIncorrectTokenAsync()
        {
            try
            {
                Logger.PrintTestStartInformation("Releasing lock with incorrect token using async method");
                var key = Guid.NewGuid().ToString();
                var correctToken = Guid.NewGuid().ToString();
                var wrongToken = Guid.NewGuid().ToString();
                Program.db.LockTake(key, correctToken, TimeSpan.FromSeconds(10));
                var result = Program.db.LockReleaseAsync(key, wrongToken).Result;
                if (!result)
                {
                    Logger.PrintSuccessfulOutcome("Correctly refused to release lock with wrong token using async method");
                }
                else
                {
                    Logger.PrintFailureOutcome("Incorrectly released lock with wrong token using async method");
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


        public void LockReleaseAllowsRetakeAsync()
        {
            try
            {
                Logger.PrintTestStartInformation("Verifying lock can be retaken after release using async method");
                var key = Guid.NewGuid().ToString();
                var token1 = Guid.NewGuid().ToString();
                var token2 = Guid.NewGuid().ToString();
                Program.db.LockTake(key, token1, TimeSpan.FromSeconds(10));
                Program.db.LockReleaseAsync(key, token1).Wait();

                // after release it should be allowed to retake lock
                var result = Program.db.LockTakeAsync(key, token2, TimeSpan.FromSeconds(10)).Result;
                if (result)
                {
                    Logger.PrintSuccessfulOutcome("Successfully retook lock after it was released using async method");
                }
                else
                {
                    Logger.PrintFailureOutcome("Unable to retake lock after release using async method");
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
