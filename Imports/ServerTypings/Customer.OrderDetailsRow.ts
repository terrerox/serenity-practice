namespace practice1.Customer {
    export interface OrderDetailsRow {
        Id?: number;
        OrderId?: number;
        ProductId?: number;
        Total?: number;
        Quantity?: number;
        ItemAmount?: number;
        ItemTax?: number;
        OrderUserId?: number;
        OrderAmount?: number;
        OrderTax?: number;
        OrderAddress?: string;
        OrderStatus?: number;
        ProductTitle?: string;
        ProductCategory?: number;
        ProductPrice?: number;
        ProductPrimaryImage?: string;
    }

    export namespace OrderDetailsRow {
        export const idProperty = 'Id';
        export const nameProperty = 'ProductId';
        export const localTextPrefix = 'Customer.OrderDetails';
        export const deletePermission = 'Customer';
        export const insertPermission = 'Customer';
        export const readPermission = 'Customer';
        export const updatePermission = 'Customer';

        export declare const enum Fields {
            Id = "Id",
            OrderId = "OrderId",
            ProductId = "ProductId",
            Total = "Total",
            Quantity = "Quantity",
            ItemAmount = "ItemAmount",
            ItemTax = "ItemTax",
            OrderUserId = "OrderUserId",
            OrderAmount = "OrderAmount",
            OrderTax = "OrderTax",
            OrderAddress = "OrderAddress",
            OrderStatus = "OrderStatus",
            ProductTitle = "ProductTitle",
            ProductCategory = "ProductCategory",
            ProductPrice = "ProductPrice",
            ProductPrimaryImage = "ProductPrimaryImage"
        }
    }
}
