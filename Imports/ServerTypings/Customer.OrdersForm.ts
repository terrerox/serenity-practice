namespace practice1.Customer {
    export interface OrdersForm {
        UserId: Serenity.IntegerEditor;
        Address: Serenity.TextAreaEditor;
        ItemList: OrderDetailsEditor;
        Status: Serenity.EnumEditor;
    }

    export class OrdersForm extends Serenity.PrefixedContext {
        static formKey = 'Customer.Orders';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!OrdersForm.init)  {
                OrdersForm.init = true;

                var s = Serenity;
                var w0 = s.IntegerEditor;
                var w1 = s.TextAreaEditor;
                var w2 = OrderDetailsEditor;
                var w3 = s.EnumEditor;

                Q.initFormType(OrdersForm, [
                    'UserId', w0,
                    'Address', w1,
                    'ItemList', w2,
                    'Status', w3
                ]);
            }
        }
    }
}
