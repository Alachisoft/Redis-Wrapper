using Alachisoft.NCache.Client;
using Alachisoft.NCache.Runtime.Caching;
using NCache.OSS.StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NCache.OSS.StackExchange.Redis
{
    internal class NCacheSubscriber : INCacheSubscriber
    {
        private readonly ICache _cache;

        private readonly List<ChannelMessageQueue> _activeQueues = new List<ChannelMessageQueue>();

        internal NCacheSubscriber(ICache cache)
        {
            _cache = cache;
        }


        public long Publish(RedisChannel channel, RedisValue message)
        {
            try
            {
                var topic = GetOrCreateTopic(channel);
                topic.Publish(new Alachisoft.NCache.Runtime.Caching.Message(message.Box()), Alachisoft.NCache.Runtime.Caching.DeliveryOption.All);
                return 1;
            }
            catch (Exception)
            {

                return 0;
            }
        }

        public Task<long> PublishAsync(RedisChannel channel, RedisValue message)
        {
            return Task.Run(() =>
            {
                return Publish(channel, message);
            });
        }

        public ChannelMessageQueue Subscribe(RedisChannel topicName)
        {
            try
            {
                var topic = GetOrCreateTopic(topicName);
                var queue = new ChannelMessageQueue(_cache, topicName);
                lock (_activeQueues)
                {
                    _activeQueues.Add(queue);
                }
                return queue;
            }
            catch (Exception)
            {
            }
            return null;
        }

        public void Unsubscribe(ChannelMessageQueue channel)
        {
            try
            {
                channel.Unsubscribe();
                lock (_activeQueues)
                {
                    _activeQueues.Remove(channel);
                }
            }
            catch (Exception)
            {
            }
        }


        public Task<ChannelMessageQueue> SubscribeAsync(RedisChannel channel)
        {
            return Task.Run(() =>
            {
                return Subscribe(channel);
            });
        }


        public Task UnsubscribeAsync(ChannelMessageQueue queue)
        {
            return Task.Run(() =>
            {
                Unsubscribe(queue);
            });
        }

        public void UnsubscribeAll()
        {
            lock (_activeQueues)
            {
                foreach (var queue in _activeQueues)
                {
                    try
                    {
                        queue.Unsubscribe();
                    }
                    catch (Exception)
                    {
                    }
                }
                _activeQueues.Clear();
            }
        }

        public Task UnsubscribeAllAsync()
        {
            return Task.Run(() =>
            {
                UnsubscribeAll();
            });
        }

        private ITopic GetOrCreateTopic(string topicName)
        {
            var topic = _cache.MessagingService.GetTopic(topicName);
            topic = topic == null ? _cache.MessagingService.CreateTopic(topicName) : topic;
            return topic;
        }

    }
}
