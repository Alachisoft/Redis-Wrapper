using Alachisoft.NCache.Client;
using Microsoft.Extensions.Logging;
using NCache.OSS.StackExchange.Redis;
using NCache.OSS.StackExchange.Redis.Sample.BasicCacheOperations;
using NCache.OSS.StackExchange.Redis.Sample.BulkCacheOperations;
using NCache.OSS.StackExchange.Redis.Sample.CacheConnectionOperations;
using NCache.OSS.StackExchange.Redis.Sample.CacheContainsOperations;
using NCache.OSS.StackExchange.Redis.Sample.ExpirationOperations;
using NCache.OSS.StackExchange.Redis.Sample.KeyOperations;
using NCache.OSS.StackExchange.Redis.Sample.LockOperations;
using NCache.OSS.StackExchange.Redis.Sample.PubSubOperations;
using System;
using System.Configuration;

namespace BasicUsageStackExchangeRedis
{
    class Program
    {

        public static int successfulTests = 0;
        public static int failedTests = 0;
        public static INCacheDatabase db;
        public static string myObjectForCaching = "This is my Object";
        public static ICache cache;
        public static ConnectionMultiplexer mux;

        static void Main(string[] args)
        {
            try
            {
                InitializeClient();
                RunAllTests();

                Console.WriteLine($"Test completed successfully.\nSuccessful Tests: {successfulTests}\nFailed Tests: {failedTests}\nPress any key to exit...");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
        }

        private static void InitializeClient()
        {
            string cacheName = ConfigurationManager.AppSettings["CacheId"];

            Microsoft.Extensions.Logging.ILoggerFactory loggerFactory = LoggerFactory.Create(builder =>
            {
                builder
                    .AddConsole()
                    .SetMinimumLevel(Microsoft.Extensions.Logging.LogLevel.Debug);
            });

            mux = ConnectionMultiplexer.Connect(cacheName);

            cache = mux.GetNCacheInterface(cacheName);
            cache.Clear();

            db = mux.GetDatabase();
        }

        private static void RunAllTests()
        {
            RunKeyOperations();
            RunExpirationOperations();
            RunCacheContainsOperations();
            RunCacheConnectionOperations();
            RunBulkCacheOperationsTests();
            RunPubSubOperationsTests();
            RunBasicCacheOperationsTests();
            RunLockOperations();
        }

        private static void RunLockOperations()
        {
            RunLockTakeTests();
            RunLockReleaseTests();
            RunLockExtendTests();
        }

        private static void RunLockTakeTests()
        {
            LockTakeTests.LockTakeOnAlreadyLockedKey();
            LockTakeTests.LockTakeOnAlreadyLockedKeyAsync();
            LockTakeTests.LockTakeOnNonExistingKey();
            LockTakeTests.LockTakeOnNonExistingKeyAsync();
        }

        private static void RunLockReleaseTests()
        {
            LockReleaseTests.LockReleaseWithCorrectToken();
            LockReleaseTests.LockReleaseWithCorrectTokenAsync();
            LockReleaseTests.LockReleaseWithIncorrectToken();
            LockReleaseTests.LockReleaseWithIncorrectTokenAsync();
        }

        private static void RunLockExtendTests()
        {
            LockExtendTests.LockExtendWithCorrectToken();
            LockExtendTests.LockExtendWithCorrectTokenAsync();
            LockExtendTests.LockExtendWithIncorrectToken();
            LockExtendTests.LockExtendWithIncorrectTokenAsync();
        }

        private static void RunKeyOperations()
        {
            RunKeyTouchTests();
            RunKeyRenameTests();
            RunKeyRandomTests();
            RunBulkKeyTouchTests();
            RunKeyTimeToLiveTests();
        }

        private static void RunKeyTouchTests()
        {
            KeyTouchTests.TouchExistingKey();
            KeyTouchTests.TouchExistingKeyAsync();
            KeyTouchTests.TouchNonExistingKey();
            KeyTouchTests.TouchNonExistingKeyAsync();
        }

        private static void RunKeyTimeToLiveTests()
        {
            KeyTimeToLiveTests.KeyTimeToLiveOfExistingKey();
            KeyTimeToLiveTests.KeyTimeToLiveReturnsNullForKeyWithNoExpiration();
            KeyTimeToLiveTests.KeyTimeToLiveAsyncOfExistingKey();
        }
        private static void RunKeyRenameTests()
        {
            KeyRenameTests.RenameExistingKey();
            KeyRenameTests.RenameExistingKeyAsync();
            KeyRenameTests.RenameNonExistingKey();
            KeyRenameTests.RenameNonExistingKeyAsync();
        }

        private static void RunKeyRandomTests()
        {
            KeyRandomTests.GetRandomKeyFromEmptyCache();
            KeyRandomTests.GetRandomKeyFromEmptyCacheAsync();
            KeyRandomTests.GetRandomKeyFromNonEmptyCache();
            KeyRandomTests.GetRandomKeyFromNonEmptyCacheAsync();
        }

        private static void RunBulkKeyTouchTests()
        {
            BulkKeyTouchTests.TouchExistingKeysBulk();
            BulkKeyTouchTests.TouchExistingKeysBulkAsync();
            BulkKeyTouchTests.TouchNonExistingKeysBulk();
            BulkKeyTouchTests.TouchNonExistingKeysBulkAsync();
        }

        private static void RunExpirationOperations()
        {
            RunKeyPersistsTests();
            RunKeyExpireTests();
        }

        private static void RunKeyPersistsTests()
        {
            KeyPersistsTests.PersistExistingKey();
            KeyPersistsTests.PersistExistingKeyAsync();
            KeyPersistsTests.PersistNonExistingKey();
            KeyPersistsTests.PersistNonExistingKeyAsync();
        }

        private static void RunKeyExpireTests()
        {
            KeyExpireTests.SetDateTimeExpirationForExistingItem();
            KeyExpireTests.SetDateTimeExpirationForExistingItemAsync();
            KeyExpireTests.SetDateTimeExpirationForNonExistingItem();
            KeyExpireTests.SetDateTimeExpirationForNonExistingItemAsync();
            KeyExpireTests.SetTimeSpanExpirationForExistingItem();
            KeyExpireTests.SetTimeSpanExpirationForExistingItemAsync();
            KeyExpireTests.SetTimeSpanExpirationForNonExistingItem();
            KeyExpireTests.SetTimeSpanExpirationForNonExistingItemAsync();
        }

        private static void RunCacheContainsOperations()
        {
            RunKeyExistsTests();
            RunBulkKeyExistsTests();
        }

        private static void RunKeyExistsTests()
        {
            KeyExistsTests.ContainsExistingKey();
            KeyExistsTests.ContainsExistingKeyAsync();
            KeyExistsTests.ContainsNonExistingKey();
            KeyExistsTests.ContainsNonExistingKeyAsync();
        }

        private static void RunBulkKeyExistsTests()
        {
            BulkKeyExistsTests.ContainsExistingKeysBulk();
            BulkKeyExistsTests.ContainsExistingKeysBulkAsync();
            BulkKeyExistsTests.ContainsNonExistingKeysBulk();
            BulkKeyExistsTests.ContainsNonExistingKeysBulkAsync();
        }

        private static void RunCacheConnectionOperations()
        {
            CacheConnectionTests.ChechCacheConnection();
        }

        private static void RunBulkCacheOperationsTests()
        {
            RunBulkStringSetTests();
            RunBulkKeyDeleteTests();
        }

        private static void RunBulkStringSetTests()
        {
            BulkStringSetTests.AddExistingItemsBulk();
            BulkStringSetTests.AddExistingItemsBulkAsync();
            BulkStringSetTests.AddNonExistingItemsBulk();
            BulkStringSetTests.AddNonExistingItemsBulkAsync();
        }

        private static void RunBulkKeyDeleteTests()
        {
            BulkKeyDeleteTests.DeleteExistingKeysBulk();
            BulkKeyDeleteTests.DeleteExistingKeysBulkAsync();
            BulkKeyDeleteTests.DeleteNonExistingKeysBulk();
            BulkKeyDeleteTests.DeleteNonExistingKeysBulkAsync();
        }

        private static void RunPubSubOperationsTests()
        {
            PubSubTests.PublishMessageOnExistingTopic();
            PubSubTests.SubscribeOnChannel();
            PubSubTests.PublishMessageOnExistingTopicAsync();
            PubSubTests.UnsubscribeAllPreventsMessagesBeingReceivedBySubscriber();
            PubSubTests.UnsubscribeAllAsyncPreventsMessagesBeingReceivedBySubscriber();
        }

        private static void RunBasicCacheOperationsTests()
        {
            RunStringLengthTests();
            RunStringGetSetTests();
            RunStringGetRangeTests();
            RunStringSetRangeTests();
            RunStringIncrementTests();
            RunStringDecrementTests();
            RunStringSetTests();
            RunStringGetTests();
            RunKeyDeleteTests();
            RunStringAppendTests();
        }

        private static void RunStringLengthTests()
        {
            StringLengthTests.GetExistingStringLength();
            StringLengthTests.GetExistingStringLengthAsync();
            StringLengthTests.GetNonExistingStringLength();
            StringLengthTests.GetNonExistingStringLengthAsync();
            StringLengthTests.GetNonStringLength();
            StringLengthTests.GetNonStringLengthAsync();
        }

        private static void RunStringGetSetTests()
        {
            StringGetSetTests.GetExistingStringAndSetInt();
            StringGetSetTests.GetExistingStringAndSetIntAsync();
            StringGetSetTests.GetSetExistingKey();
            StringGetSetTests.GetSetExistingKeyAsync();
            StringGetSetTests.GetSetNonExistingKey();
            StringGetSetTests.GetSetNonExistingKeyAsync();
        }

        private static void RunStringGetRangeTests()
        {
            StringGetRangeTests.GetExistingStringRange();
            StringGetRangeTests.GetExistingStringRangeAsync();
            StringGetRangeTests.GetExistingStringRangeWithNegativeEnd();
            StringGetRangeTests.GetExistingStringRangeWithNegativeEndAsync();
            StringGetRangeTests.GetExistingStringRangeWithNegativeStart();
            StringGetRangeTests.GetExistingStringRangeWithNegativeStartAsync();
            StringGetRangeTests.GetExistingStringRangeWithOutOfBoundEnd();
            StringGetRangeTests.GetExistingStringRangeWithOutOfBoundEndAsync();
            StringGetRangeTests.GetExistingStringRangeWithOutOfBoundStart();
            StringGetRangeTests.GetExistingStringRangeWithOutOfBoundStartAsync();
            StringGetRangeTests.GetNonExistingStringRange();
            StringGetRangeTests.GetNonExistingStringRangeAsync();
        }

        private static void RunStringSetRangeTests()
        {
            StringSetRangeTests.SetExistingStringRangeWithZeroOffset();
            StringSetRangeTests.SetExistingStringRangeWithNonZeroOffset();
            StringSetRangeTests.SetExistingStringRangeWithZeroOffsetAsync();
            StringSetRangeTests.SetExistingStringRangeWithNonZeroOffsetAsync();
        }

        private static void RunStringIncrementTests()
        {
            StringIncrementTests.IncrementExistingInValidString();
            StringIncrementTests.IncrementExistingInValidStringAsync();
            StringIncrementTests.IncrementExistingValidString();
            StringIncrementTests.IncrementExistingValidStringAsync();
            StringIncrementTests.IncrementExistingValidStringByDoubleValue();
            StringIncrementTests.IncrementExistingValidStringByDoubleValueAsync();
            StringIncrementTests.IncrementExistingValidStringByLongValue();
            StringIncrementTests.IncrementExistingValidStringByLongValueAsync();
            StringIncrementTests.IncrementNonExistingString();
            StringIncrementTests.IncrementNonExistingStringAsync();
        }

        private static void RunStringDecrementTests()
        {
            StringDecrementTests.DecrementExistingInValidString();
            StringDecrementTests.DecrementExistingInValidStringAsync();
            StringDecrementTests.DecrementExistingValidString();
            StringDecrementTests.DecrementExistingValidStringAsync();
            StringDecrementTests.DecrementExistingValidStringByDoubleValue();
            StringDecrementTests.DecrementExistingValidStringByDoubleValueAsync();
            StringDecrementTests.DecrementExistingValidStringByLongValue();
            StringDecrementTests.DecrementExistingValidStringByLongValueAsync();
            StringDecrementTests.DecrementNonExistingString();
            StringDecrementTests.DecrementNonExistingStringAsync();
        }

        private static void RunStringSetTests()
        {
            StringSetTests.AddExistingKeyValuePair();
            StringSetTests.AddExistingKeyValuePairAsync();
            StringSetTests.AddKeyValuePair();
            StringSetTests.AddKeyValuePairAsync();
            StringSetTests.SetKeyValuePairWithExpiry();
            StringSetTests.SetKeyValuePairWithExpiryAsync();
        }

        private static void RunStringGetTests()
        {
            StringGetTests.GetExistingKey();
            StringGetTests.GetExistingKeyAsync();
            StringGetTests.GetNonExistingKey();
            StringGetTests.GetNonExistingKeyAsync();
            StringGetTests.GetExistingStringWithExpiry();
            StringGetTests.GetExistingStringWithExpiryAsync();
        }

        private static void RunKeyDeleteTests()
        {
            KeyDeleteTests.DeleteExistingKey();
            KeyDeleteTests.DeleteExistingKeyAsync();
            KeyDeleteTests.DeleteNonExistingKey();
            KeyDeleteTests.DeleteNonExistingKeyAsync();
        }

        private static void RunStringAppendTests()
        {
            StringAppendTests.AppendEmptyStringToExistingString();
            StringAppendTests.AppendEmptyStringToExistingStringAsync();
            StringAppendTests.AppendEmptyStringToNonExistingString();
            StringAppendTests.AppendEmptyStringToNonExistingStringAsync();
            StringAppendTests.AppendToExistingInt();
            StringAppendTests.AppendToExistingIntAsync();
            StringAppendTests.AppendToExistingString();
            StringAppendTests.AppendToExistingStringAsync();
            StringAppendTests.AppendToNonExistingString();
            StringAppendTests.AppendToNonExistingStringAsync();
        }



       


    }
}
