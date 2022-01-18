namespace practice1.Local {
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
        export const localTextPrefix = 'Local.OrderDetails';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

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
