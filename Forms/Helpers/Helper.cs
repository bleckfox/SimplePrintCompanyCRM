using AppContext = DatabaseCatalog.ApplicationContext;

namespace ProjectHelpers
{
    static class Helper
    {

        #region Получение информацию об Id для сохранения заказа

        public static int GetLinkedEntityId(ComboBox comboBox)
        {
            string item = comboBox.SelectedItem?.ToString() ?? comboBox.Text;
            return Convert.ToInt32(item.Split(",").First());
        }

        #endregion

        #region Получение информацию о кнопке, на которую кликнул пользователь

        public static string GetButtonActionTitle(object sender)
        {
            Button? button = sender as Button;
            return button.Text ?? string.Empty;
        }

        public static string GetButtonActionName(object sender)
        {
            Button? button = sender as Button;
            return button.Name ?? string.Empty;
        }

        #endregion


        #region Работа с dataGridView

        public static void DeleteRow(DataGridView data, string tableName)
        {
            if (data.Rows.Count > 0)
            {
                int rowIndex = data.CurrentRow.Index;
                int id = Convert.ToInt32(data.Rows[rowIndex].Cells[0].Value);
                data.Rows.RemoveAt(rowIndex);

                using (AppContext context = new AppContext())
                {
                    switch (tableName)
                    {
                        case "Managers":
                            var manager = context.Managers.FirstOrDefault(x => x.Id == id);

                            if (manager != null)
                                context.Managers.Remove(manager);

                            break;

                        case "Materials":
                            var material = context.Materials.FirstOrDefault(x => x.Id == id);

                            if (material != null)
                                context.Materials.Remove(material);

                            break;

                        case "Orders":
                            var order = context.Orders.FirstOrDefault(x => x.Id == id);

                            if (order != null)
                                context.Orders.Remove(order);

                            break;
                    }

                    context.SaveChanges();
                }
            }
        }

        #endregion
    }
}
