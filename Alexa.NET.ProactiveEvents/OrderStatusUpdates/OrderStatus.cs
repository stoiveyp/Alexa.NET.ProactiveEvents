using System.Runtime.Serialization;

namespace Alexa.NET.ProactiveEvents.OrderStatusUpdates
{
    public enum OrderStatus
    {
        [EnumMember(Value="PREORDER_RECEIVED")]
        PreorderReceived,
        [EnumMember(Value = "ORDER_RECEIVED")]
        Received,
        [EnumMember(Value = "ORDER_PREPARING")]
        Preparing,
        [EnumMember(Value = "ORDER_SHIPPED")]
        Shipped,
        [EnumMember(Value = "ORDER_OUT_FOR_DELIVERY")]
        OutForDelivery,
        [EnumMember(Value="ORDER_DELIVERED")]
        Delivered
    }
}