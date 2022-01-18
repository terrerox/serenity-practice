namespace practice1.Common {
    export enum OrderStatus {
        Sent = 1,
        Received = 2
    }
    Serenity.Decorators.registerEnumType(OrderStatus, 'practice1.Common.OrderStatus', 'Common.OrderStatus');
}
