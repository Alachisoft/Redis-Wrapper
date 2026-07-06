using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NCache.OSS.StackExchange.Redis
{
    public interface INCacheSubscriber
    {

        // <summary>
        /// Subscribes to the given channel
        /// </summary>
        /// <param name="channel">The channel to subscribe to.</param>
        /// <returns>A <see cref="ChannelMessageQueue"/> that can be used to read messages from the channel.</returns>
        ChannelMessageQueue Subscribe(RedisChannel channel);

        // <summary>
        /// Subscribes to the given channel asynchronously
        /// </summary>
        /// <param name="channel">The channel to subscribe to.</param>
        /// <returns>A <see cref="ChannelMessageQueue"/> that can be used to read messages from the channel.</returns>
        Task<ChannelMessageQueue> SubscribeAsync(RedisChannel channel);

        /// <summary>
        /// Unsubscribes from the given channel.
        /// </summary>
        /// <param name="queue">The channel message queue to unsubscribe from.</param>
        void Unsubscribe(ChannelMessageQueue queue);


        /// <summary>
        /// Unsubscribes from the given channel asynchronously.
        /// </summary>
        /// <param name="queue">The channel message queue to unsubscribe from.</param>
        /// <returns>A task that represents the asynchronous unsubscribe operation.</returns>
        Task UnsubscribeAsync(ChannelMessageQueue queue);


        /// <summary>
        /// Unsubscribes from all channels.
        /// </summary>
        void UnsubscribeAll();

        /// <summary>
        /// Unsubscribes from all channels asynchronously.
        /// </summary>
        /// <returns>A task that represents the asynchronous unsubscribe operation.</returns>
        Task UnsubscribeAllAsync();


        /// <summary>
        /// Posts a message to the given channel.
        /// </summary>
        /// <param name="channel">The channel to publish to.</param>
        /// <param name="message">The message to send.</param>
        /// <returns>The number of clients that received the message.</returns>
        /// <remarks>https://redis.io/commands/publish</remarks>
        long Publish(RedisChannel channel, RedisValue messagee);


        /// <summary>
        /// Posts a message to the given channel.
        /// </summary>
        /// <param name="channel">The channel to publish to.</param>
        /// <param name="message">The message to send.</param>
        /// <returns>The number of clients that received the message.</returns>
        /// <remarks>https://redis.io/commands/publish</remarks>
        Task<long> PublishAsync(RedisChannel channel, RedisValue message);

    }
}
