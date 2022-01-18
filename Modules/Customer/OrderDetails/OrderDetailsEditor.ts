namespace practice1.Customer {
    @Serenity.Decorators.registerEditor()
    export class OrderDetailsEditor
        extends Serenity.Extensions.GridEditorBase<OrderDetailsRow> {
        protected getColumnsKey() { return "Local.OrderDetails"; }
        protected getDialogType() { return OrderDetailsEditDialog; }
        protected getLocalTextPrefix() { return OrderDetailsRow.localTextPrefix; }

        constructor(container: JQuery) {
            super(container);
        }

        protected validateEntity(row: OrderDetailsRow, id: number) {
            if (!super.validateEntity(row, id))
                return false;

            //row.ProductTitle = ProductsRow.getLookup()
            //    .itemById[row.ProductId].Title;

            //row.ItemTax = 20;

            return true;
        }
        protected getButtons() {
            return null;
        }
    }
}