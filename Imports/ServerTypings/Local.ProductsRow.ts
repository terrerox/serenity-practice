namespace practice1.Local {
    export interface ProductsRow {
        Id?: number;
        Title?: string;
        Category?: ProductCategory;
        Price?: number;
        PrimaryImage?: string;
    }

    export namespace ProductsRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Title';
        export const localTextPrefix = 'Local.Products';
        export const lookupKey = 'practice1.Products';

        export function getLookup(): Q.Lookup<ProductsRow> {
            return Q.getLookup<ProductsRow>('practice1.Products');
        }
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            Id = "Id",
            Title = "Title",
            Category = "Category",
            Price = "Price",
            PrimaryImage = "PrimaryImage"
        }
    }
}
