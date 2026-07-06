using BasicUsageStackExchangeRedis;
using System;
using System.Collections.Generic;
using System.Text;
using NCache.OSS.StackExchange.Redis.Sample;

namespace NCache.OSS.StackExchange.Redis.Sample.LockOperations
{
    class LockExtendTests
    {

        //------------------------------------------------Sync Methods------------------------------------------------\\


        public static void LockExtendWithCorrectToken()
        {
            try
            {
                Logger.PrintTestStartInformation("Extending lock with correct token");
                var key = Guid.NewGuid().ToString();
                var token = Guid.NewGuid().ToString();

                Program.db.LockTake(key, token, TimeSpan.FromSeconds(10));
                var result = Program.db.LockExtend(key, token, TimeSpan.FromSeconds(20));
                if (result)
                {
                    Logger.PrintSuccessfulOutcome("Successfully extended lock with correct token");
                }
                else
                {
                    Logger.PrintFailureOutcome("Unable to extend lock with correct token");
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

        public static void LockExtendWithIncorrectToken()
        {
            try
            {
                Logger.PrintTestStartInformation("Extending lock with incorrect token");
                var key = Guid.NewGuid().ToString();
                var correctToken = Guid.NewGuid().ToString();
                var wrongToken = Guid.NewGuid().ToString();

                Program.db.LockTake(key, correctToken, TimeSpan.FromSeconds(10));
                var result = Program.db.LockExtend(key, wrongToken, TimeSpan.FromSeconds(20));
                if (!result)
                {
                    Logger.PrintSuccessfulOutcome("Correctly refused to extend lock with wrong token");
                }
                else
                {
                    Logger.PrintFailureOutcome("Incorrectly extended lock with wrong token");
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



        public static void LockExtendWithCorrectTokenAsync()
        {
            try
            {
                Logger.PrintTestStartInformation("Asynchronously extending lock with correct token");
                var key = Guid.NewGuid().ToString();
                var token = Guid.NewGuid().ToString();
                Program.db.LockTake(key, token, TimeSpan.FromSeconds(10));
                var result = Program.db.LockExtendAsync(key, token, TimeSpan.FromSeconds(20)).Result;
                if (result)
                {
                    Logger.PrintSuccessfulOutcome("Successfully extended lock with correct token");
                }
                else
                {
                    Logger.PrintFailureOutcome("Unable to extend lock with correct token");
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

        public static void LockExtendWithIncorrectTokenAsync()
        {
            try
            {
                Logger.PrintTestStartInformation("Asynchronously extending lock with incorrect token");
                var key = Guid.NewGuid().ToString();
                var correctToken = Guid.NewGuid().ToString();
                var wrongToken = Guid.NewGuid().ToString();
                Program.db.LockTake(key, correctToken, TimeSpan.FromSeconds(10));
                var result = Program.db.LockExtendAsync(key, wrongToken, TimeSpan.FromSeconds(20)).Result;
                if (!result)
                {
                    Logger.PrintSuccessfulOutcome("Correctly refused to extend lock with wrong token");
                }
                else
                {
                    Logger.PrintFailureOutcome("Incorrectly extended lock with wrong token");
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
