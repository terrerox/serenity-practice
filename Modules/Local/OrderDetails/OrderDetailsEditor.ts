namespace practice1.Local {
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

            row.ProductTitle = ProductsRow.getLookup()
                .itemById[row.ProductId].Title;

            row.ItemTax = row.ProductPrice + 20;
            row.Total = (row.Quantity * row.ProductPrice) + 20;

            return true;
        }
        protected getAddButtonCaption() {
            return "Add";
        }
    }
} 