namespace practice1.Local {
    export interface OrdersRow {
        Id?: number;
        UserId?: number;
        Amount?: number;
        Tax?: number;
        Address?: string;
        Status?: Common.OrderStatus;
        ItemList?: OrderDetailsRow[];
        UserUsername?: string;
        UserDisplayName?: string;
        UserEmail?: string;
        UserSource?: string;
        UserLastDirectoryUpdate?: string;
        UserUserImage?: string;
        UserInsertDate?: string;
        UserInsertUserId?: number;
        UserUpdateDate?: string;
        UserUpdateUserId?: number;
        UserIsActive?: number;
    }

    export namespace OrdersRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Address';
        export const localTextPrefix = 'Local.Orders';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            Id = "Id",
            UserId = "UserId",
            Amount = "Amount",
            Tax = "Tax",
            Address = "Address",
            Status = "Status",
            ItemList = "ItemList",
            UserUsername = "UserUsername",
            UserDisplayName = "UserDisplayName",
            UserEmail = "UserEmail",
            UserSource = "UserSource",
            UserLastDirectoryUpdate = "UserLastDirectoryUpdate",
            UserUserImage = "UserUserImage",
            UserInsertDate = "UserInsertDate",
            UserInsertUserId = "UserInsertUserId",
            UserUpdateDate = "UserUpdateDate",
            UserUpdateUserId = "UserUpdateUserId",
            UserIsActive = "UserIsActive"
        }
    }
}
