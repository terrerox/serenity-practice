
namespace practice1.Local {

    @Serenity.Decorators.registerClass()
    export class OrdersGrid extends Serenity.EntityGrid<OrdersRow, any> {
        protected getColumnsKey() { return OrdersColumns.columnsKey; }
        protected getDialogType() { return OrdersDialog; }
        protected getIdProperty() { return OrdersRow.idProperty; }
        protected getInsertPermission() { return OrdersRow.insertPermission; }
        protected getLocalTextPrefix() { return OrdersRow.localTextPrefix; }
        protected getService() { return OrdersService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}