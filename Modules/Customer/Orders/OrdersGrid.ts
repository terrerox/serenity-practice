
namespace practice1.Customer {

    @Serenity.Decorators.registerClass()
    export class OrdersGrid extends Serenity.EntityGrid<OrdersRow, any> {
        protected getColumnsKey() { return OrdersColumns.columnsKey; }
        protected getDialogType() { return OrdersDialog; }
        protected getIdProperty() { return OrdersRow.idProperty; }
        protected getInsertPermission() { return OrdersRow.insertPermission; }
        protected getLocalTextPrefix() { return OrdersRow.localTextPrefix; }
        protected getService() { return OrdersService.baseUrl; }

        constructor(container: JQuery, options) {
            super(container);
            if (!this.options.canDelete)
                this.toolbar.findButton(".add-button").remove();
        }

        getButtons() {
            var buttons = super.getButtons();
            var MyRow = OrdersRow;

            buttons.push(practice1.Common.ExcelExportHelper.createToolButton({
                grid: this,
                onViewSubmit: () => this.onViewSubmit(),
                service: OrdersService.baseUrl + '/ListExcel',
                separator: true,
                hint: "This is the Hint",
                title: "This is the Title"
            }));

            return buttons;
        }

        protected usePager() {
            return false;
        }

        protected getQuickSearchFields(): Serenity.QuickSearchField[] {
            return [
                { name: "", title: "all" },
                { name: "Amount", title: "amount" },
                { name: "Address", title: "address" }
            ];
        }
    }
}