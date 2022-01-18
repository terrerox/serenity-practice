namespace practice1.Local {
    export enum ProductCategory {
        Seafood = 1,
        Bakery = 2,
        Meat = 3
    }
    Serenity.Decorators.registerEnumType(ProductCategory, 'practice1.Local.ProductCategory', 'Local.ProductCategory');
}
