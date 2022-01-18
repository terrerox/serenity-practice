namespace practice1.Local {
    export interface OrderDetailsForm {
        ProductId: Serenity.LookupEditor;
        Quantity: Serenity.IntegerEditor;
        ProductPrice: Serenity.IntegerEditor;
        ItemTax: Serenity.IntegerEditor;
        Total: Serenity.IntegerEditor;
    }

    export class OrderDetailsForm extends Serenity.PrefixedContext {
        static formKey = 'Local.OrderDetails';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!OrderDetailsForm.init)  {
                OrderDetailsForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;
                var w1 = s.IntegerEditor;

                Q.initFormType(OrderDetailsForm, [
                    'ProductId', w0,
                    'Quantity', w1,
                    'ProductPrice', w1,
                    'ItemTax', w1,
                    'Total', w1
                ]);
            }
        }
    }
}
