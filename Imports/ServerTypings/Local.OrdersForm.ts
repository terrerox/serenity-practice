namespace practice1.Local {
    export interface OrdersForm {
        UserId: Serenity.LookupEditor;
        Address: Serenity.TextAreaEditor;
        ItemList: OrderDetailsEditor;
        Status: Serenity.EnumEditor;
    }

    export class OrdersForm extends Serenity.PrefixedContext {
        static formKey = 'Local.Orders';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!OrdersForm.init)  {
                OrdersForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;
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
