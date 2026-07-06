using BasicUsageStackExchangeRedis;
using System;
using System.Collections.Generic;
using System.Text;
using NCache.OSS.StackExchange.Redis.Sample;

namespace NCache.OSS.StackExchange.Redis.Sample.BasicCacheOperations
{
    class StringSetRangeTests
    {
        //------------------------------------------------Sync Methods------------------------------------------------\\


        public static void SetExistingStringRangeWithZeroOffset()
        {
            try
            {
                Logger.PrintTestStartInformation("Setting range of already existing non-empty string in cache"); 
                var key = Guid.NewGuid().ToString();
                var value = "Camera is my object";

                var expectedLength = "NCache is my object".Length;

                Program.db.StringSet(key, value);
                var result = Program.db.StringSetRange(key, 0, "NCache");
                if (result == expectedLength)
                {
                    Logger.PrintSuccessfulOutcome("Successfully set range of already existing non-empty string");
                }
                else
                {
                    Logger.PrintFailureOutcome("Unable to set range of already existing non-empty string");
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

        public static void SetExistingStringRangeWithNonZeroOffset()
        {
            try
            {
                Logger.PrintTestStartInformation("Setting range of already existing non-empty string in cache with non-zero offset"); 
                var key = Guid.NewGuid().ToString();
                var value = "This is using ______";
                var expectedLength = "This is using NCache".Length;
                Program.db.StringSet(key, value);
                var result = Program.db.StringSetRange(key, 14, "NCache");
                if (result == expectedLength)
                {
                    Logger.PrintSuccessfulOutcome("Successfully set range of already existing non-empty string with non-zero offset");
                }
                else
                {
                    Logger.PrintFailureOutcome("Unable to set range of already existing non-empty string with non-zero offset");
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



        public static void SetExistingStringRangeWithNonZeroOffsetAsync()
        {
            try
            {
                Logger.PrintTestStartInformation("Setting range of already existing non-empty string in cache with non-zero offset Asynchronously");
                var key = Guid.NewGuid().ToString();
                var value = "This is using ______";
                var expectedLength = "This is using NCache".Length;
                Program.db.StringSet(key, value);
                var result = Program.db.StringSetRangeAsync(key, 14, "NCache");
                result.Wait();
                if (result.Result == expectedLength)
                {
                    Logger.PrintSuccessfulOutcome("Successfully set range of already existing non-empty string with non-zero offset Asynchronously");
                }
                else
                {
                    Logger.PrintFailureOutcome("Unable to set range of already existing non-empty string with non-zero offset Asynchronously");
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


        public static void SetExistingStringRangeWithZeroOffsetAsync()
        {
            try
            {
                Logger.PrintTestStartInformation("Setting range of already existing non-empty string in cache Asynchronously");
                var key = Guid.NewGuid().ToString();
                var value = "Camera is my object";

                var expectedLength = "NCache is my object".Length;

                Program.db.StringSet(key, value);
                var result = Program.db.StringSetRangeAsync(key, 0, "NCache");
                result.Wait();
                if (result.Result == expectedLength)
                {
                    Logger.PrintSuccessfulOutcome("Successfully set range of already existing non-empty string Asynchronously");
                }
                else
                {
                    Logger.PrintFailureOutcome("Unable to set range of already existing non-empty string Asynchronously");
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
