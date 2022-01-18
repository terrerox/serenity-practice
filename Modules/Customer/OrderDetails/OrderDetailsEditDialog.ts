namespace practice1.Customer {

    @Serenity.Decorators.registerClass()
    export class OrderDetailsEditDialog extends
        Serenity.Extensions.GridEditorDialog<OrderDetailsRow> {
        protected getFormKey() { return OrderDetailsForm.formKey; }
        protected getNameProperty() { return OrderDetailsRow.nameProperty; }
        protected getLocalTextPrefix() { return OrderDetailsRow.localTextPrefix; }

        protected form: OrderDetailsForm;

        constructor() {
            super();
            this.form = new OrderDetailsForm(this.idPrefix);
        }
    }
}