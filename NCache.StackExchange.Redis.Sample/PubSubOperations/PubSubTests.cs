using BasicUsageStackExchangeRedis;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using NCache.OSS.StackExchange.Redis.Sample;

namespace NCache.OSS.StackExchange.Redis.Sample.PubSubOperations
{
    class PubSubTests
    {

        //------------------------------------------------Sync Methods------------------------------------------------\\

        public static void PublishMessageOnExistingTopic()
        {
            try
            {
                Logger.PrintTestStartInformation("Publishing message on already existing channel in cache");

                var message = "This is a test message";
                var channelName = "ExistingTestChannel";
                var subscriber = Program.mux.GetSubscriber();

                subscriber.Publish(channelName, message);

                var result = subscriber.Publish(channelName, message);

                if (result == 1)
                {
                    Logger.PrintSuccessfulOutcome("Successfully published message on already existing channel");
                }
                else
                {
                    Logger.PrintFailureOutcome("Unable to publish message on already existing channel");
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

        public static void SubscribeOnChannel()
        {
            try
            {
                Logger.PrintTestStartInformation("Subscribing on already existing channel in cache");

                var channelName = "ExistingTestChannel";
                var subscriber = Program.mux.GetSubscriber();
                var result = subscriber.Subscribe(channelName);

                result.OnMessage((ChannelMessage msg) =>
                {
                    Logger.PrintSuccessfulOutcome("Message received \nChannel: " + msg.Channel + " \nMessage: " + msg.Message);
                });

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

        public static void PublishMessageOnExistingTopicAsync()
        {
            try
            {
                Logger.PrintTestStartInformation("Asynchronously publishing message on already existing channel in cache");

                var message = "This is a test message";
                var channelName = "ExistingTestChannel";
                var subscriber = Program.mux.GetSubscriber();
                subscriber.Publish(channelName, message);

                var result =subscriber.PublishAsync(channelName, message);

                result.Wait();

                if (result.Result == 1)
                {
                    Logger.PrintSuccessfulOutcome("Successfully published message on already existing channel");
                }
                else
                {
                    Logger.PrintFailureOutcome("Unable to publish message on already existing channel");
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

        public static void UnsubscribeAllPreventsMessagesBeingReceivedBySubscriber()
        {
            try
            {
                Logger.PrintTestStartInformation("Unsubscribing from all active channels");

                var subscriber = Program.mux.GetSubscriber();

                var subscriber1 = subscriber.Subscribe("TestChannel1");
                var subscriber2 = subscriber.Subscribe("TestChannel2");
                var subscriber3 = subscriber.Subscribe("TestChannel3");
                bool messageReceived = false;

                subscriber1.OnMessage((ChannelMessage msg) =>
                {
                    Logger.PrintSuccessfulOutcome("Initial Message received 1 \nChannel: " + msg.Channel + " \nMessage: " + msg.Message);
                    messageReceived = true;
                });

                subscriber2.OnMessage((ChannelMessage msg) =>
                {
                    Logger.PrintSuccessfulOutcome("Initial Message received 2 \nChannel: " + msg.Channel + " \nMessage: " + msg.Message);
                    messageReceived = true;

                });

                subscriber3.OnMessage((ChannelMessage msg) =>
                {
                    Logger.PrintSuccessfulOutcome("Initial Message received 3 \nChannel: " + msg.Channel + " \nMessage: " + msg.Message);
                    messageReceived = true;
                });


                subscriber.UnsubscribeAll();

                subscriber.Publish("TestChannel1", "ShouldNotArrive");
                subscriber.Publish("TestChannel2", "ShouldNotArrive");
                subscriber.Publish("TestChannel3", "ShouldNotArrive");

                System.Threading.Thread.Sleep(2000);

                if (!messageReceived)
                {
                    Logger.PrintSuccessfulOutcome("Successfully unsubscribed from all channels — no messages received after UnsubscribeAllPreventsMessagesBeingReceivedBySubscriber");
                }
                else
                {
                    Logger.PrintFailureOutcome("Message was received after UnsubscribeAllPreventsMessagesBeingReceivedBySubscriber — unsubscribe did not work correctly");
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

        public static void UnsubscribeAllAsyncPreventsMessagesBeingReceivedBySubscriber()
        {
            try
            {
                Logger.PrintTestStartInformation("Asynchronously unsubscribing from all active channels");

                var subscriber = Program.mux.GetSubscriber();

                var subscriber1 = subscriber.Subscribe("AsyncTestChannel1");
                var subscriber2 = subscriber.Subscribe("AsyncTestChannel2");

                bool messageReceived = false;

                subscriber1.OnMessage((ChannelMessage msg) =>
                {
                    Logger.PrintSuccessfulOutcome("Initial Message received 1 \nChannel: " + msg.Channel + " \nMessage: " + msg.Message);
                    messageReceived = true;
                });

                subscriber2.OnMessage((ChannelMessage msg) =>
                {
                    Logger.PrintSuccessfulOutcome("Initial Message received 2 \nChannel: " + msg.Channel + " \nMessage: " + msg.Message);
                    messageReceived = true;

                });


                var task = subscriber.UnsubscribeAllAsync();
                task.Wait();

                subscriber.Publish("AsyncTestChannel1", "ShouldNotArrive");
                subscriber.Publish("AsyncTestChannel2", "ShouldNotArrive");

                System.Threading.Thread.Sleep(2000);

                if (!messageReceived)
                {
                    Logger.PrintSuccessfulOutcome("Successfully asynchronously unsubscribed from all channels");
                }
                else
                {
                    Logger.PrintFailureOutcome("Message was received after UnsubscribeAllAsyncPreventsMessagesBeingReceivedBySubscriber — unsubscribe did not work correctly");
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
