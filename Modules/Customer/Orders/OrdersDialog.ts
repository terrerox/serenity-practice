
namespace practice1.Customer {

    @Serenity.Decorators.registerClass()
    export class OrdersDialog extends Serenity.EntityDialog<OrdersRow, any> {
        protected getFormKey() { return OrdersForm.formKey; }
        protected getIdProperty() { return OrdersRow.idProperty; }
        protected getLocalTextPrefix() { return OrdersRow.localTextPrefix; }
        protected getNameProperty() { return OrdersRow.nameProperty; }
        protected getService() { return OrdersService.baseUrl; }
        protected getDeletePermission() { return OrdersRow.deletePermission; }
        protected getInsertPermission() { return OrdersRow.insertPermission; }
        protected getUpdatePermission() { return OrdersRow.updatePermission; }

        protected form = new OrdersForm(this.idPrefix);

        constructor(options) {
            super(options);

            if (!this.options.canDelete)
                this.toolbar.findButton(".delete-button").remove();
                this.toolbar.findButton(".apply-changes-button").remove();
                this.toolbar.findButton(".save-and-close-button").remove();
        }
    }
}