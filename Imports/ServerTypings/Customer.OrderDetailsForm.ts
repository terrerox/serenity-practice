namespace practice1.Customer {
    export interface OrderDetailsForm {
        OrderId: Serenity.IntegerEditor;
        ProductId: Serenity.IntegerEditor;
        Total: Serenity.IntegerEditor;
        Quantity: Serenity.IntegerEditor;
        ItemAmount: Serenity.IntegerEditor;
        ItemTax: Serenity.IntegerEditor;
    }

    export class OrderDetailsForm extends Serenity.PrefixedContext {
        static formKey = 'Customer.OrderDetails';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!OrderDetailsForm.init)  {
                OrderDetailsForm.init = true;

                var s = Serenity;
                var w0 = s.IntegerEditor;

                Q.initFormType(OrderDetailsForm, [
                    'OrderId', w0,
                    'ProductId', w0,
                    'Total', w0,
                    'Quantity', w0,
                    'ItemAmount', w0,
                    'ItemTax', w0
                ]);
            }
        }
    }
}
