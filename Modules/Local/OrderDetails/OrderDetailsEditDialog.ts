namespace practice1.Local {

    @Serenity.Decorators.registerClass()
    export class OrderDetailsEditDialog extends
        Serenity.Extensions.GridEditorDialog<OrderDetailsRow> {
        protected getFormKey() { return OrderDetailsForm.formKey; }
        protected getNameProperty() { return OrderDetailsRow.nameProperty; }
        protected getProductPrice() { return OrderDetailsRow.Fields.ProductPrice; }
        protected getLocalTextPrefix() { return OrderDetailsRow.localTextPrefix; }

        protected form: OrderDetailsForm;

        constructor() {
            super();
            this.form = new OrderDetailsForm(this.idPrefix);
            //this.form.Total.value = this.form.price.value + this.form.cost.value
        }
    }
}