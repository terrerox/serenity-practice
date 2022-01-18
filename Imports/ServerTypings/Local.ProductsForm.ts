namespace practice1.Local {
    export interface ProductsForm {
        Title: Serenity.StringEditor;
        Category: Serenity.EnumEditor;
        Price: Serenity.IntegerEditor;
        PrimaryImage: Serenity.ImageUploadEditor;
    }

    export class ProductsForm extends Serenity.PrefixedContext {
        static formKey = 'Local.Products';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ProductsForm.init)  {
                ProductsForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.EnumEditor;
                var w2 = s.IntegerEditor;
                var w3 = s.ImageUploadEditor;

                Q.initFormType(ProductsForm, [
                    'Title', w0,
                    'Category', w1,
                    'Price', w2,
                    'PrimaryImage', w3
                ]);
            }
        }
    }
}
