using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using ProjectHelpers;
using AppContext = DatabaseCatalog.ApplicationContext;

namespace Forms
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        #region Действия при загрузке окна

        private void MainWindow_Load(object sender, EventArgs e)
        {
            FillTableData();
        }

        private void FillTableData()
        {
            using (AppContext context = new AppContext())
            {
                FillManagers(context);
                FillMaterials(context);
                FillOrders(context);
            };
        }

        private void FillManagers(AppContext context)
        {
            var managers = context.Managers.ToList();

            if (managers != null)
            {
                for (int i = 0; i < managers.Count(); i++)
                {
                    managersDataGridView.Rows.Add();
                    managersDataGridView.Rows[i].Cells[0].Value = managers[i].Id;
                    managersDataGridView.Rows[i].Cells[1].Value = managers[i].Name;
                    managersDataGridView.Rows[i].Cells[2].Value = managers[i].Surname;
                    managersDataGridView.Rows[i].Cells[3].Value = managers[i].Patronymic;
                    managersDataGridView.Rows[i].Cells[4].Value = managers[i].Appointment;
                }
            }
        }

        private void FillMaterials(AppContext context)
        {
            var materials = context.Materials.ToList();

            if (materials != null)
            {
                for (int i = 0; i < materials.Count(); i++)
                {
                    materialDataGridView.Rows.Add();
                    materialDataGridView.Rows[i].Cells[0].Value = materials[i].Id;
                    materialDataGridView.Rows[i].Cells[1].Value = materials[i].Name;
                    materialDataGridView.Rows[i].Cells[2].Value = materials[i].Date.ToShortDateString();
                    materialDataGridView.Rows[i].Cells[3].Value = materials[i].Type;
                    materialDataGridView.Rows[i].Cells[4].Value = materials[i].PaperSettings;
                }
            }
        }

        private void FillOrders(AppContext context)
        {
            var orders = context.Orders
                .Include(m => m.Material)
                .Include(m => m.Manager)
                .ToList();

            if (orders != null)
            {
                for (int i = 0; i < orders.Count(); i++)
                {
                    string materialName = $"{orders[i].Material?.Name} {orders[i].Material?.Type}, {orders[i].Material?.PaperSettings}";
                    string managerName = $"{orders[i].Manager?.Id}, {orders[i].Manager?.Name} {orders[i].Manager?.Surname}";
                    string date = $"{orders[i].Date.ToShortDateString()} {orders[i].Date.ToShortTimeString()}";

                    orderDataGridView.Rows.Add();
                    orderDataGridView.Rows[i].Cells[0].Value = orders[i].Id;
                    orderDataGridView.Rows[i].Cells[1].Value = orders[i].Name;
                    orderDataGridView.Rows[i].Cells[2].Value = date;
                    orderDataGridView.Rows[i].Cells[3].Value = orders[i].Volume;
                    orderDataGridView.Rows[i].Cells[4].Value = materialName;
                    orderDataGridView.Rows[i].Cells[5].Value = managerName;
                }
            }
        }

        #endregion

        #region Клики на кнопки

        private void OrderBtn_Click(object sender, EventArgs e)
        {
            // Если уже была открыта, закроем старый экземпляр
            if (Application.OpenForms.OfType<CreateAndEditOrderWindow>().Count() == 1)
            {
                Application.OpenForms.OfType<CreateAndEditOrderWindow>().First().Close();
            }

            string actionTitle = Helper.GetButtonActionTitle(sender);

            if (!string.IsNullOrEmpty(actionTitle))
            {
                CreateAndEditOrderWindow window = actionTitle == "Создать"
                        ? new CreateAndEditOrderWindow()
                        : new CreateAndEditOrderWindow(orderDataGridView.CurrentRow.Cells[0].Value.ToString());

                window.Show();
            }
            else
            {
                MessageBox.Show("Во время работы программы что-то пошло не так, попробуйте перезапустить программу",
                            "Упс...",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
            }

        }

        private void MaterialBtn_Click(object sender, EventArgs e)
        {
            // Если уже была открыта, закроем старый экземпляр
            if (Application.OpenForms.OfType<CreateAndEditMaterial>().Count() == 1)
            {
                Application.OpenForms.OfType<CreateAndEditMaterial>().First().Close();
            }

            string actionTitle = Helper.GetButtonActionTitle(sender);

            if (!string.IsNullOrEmpty(actionTitle))
            {
                CreateAndEditMaterial window = actionTitle == "Создать"
                    ? new CreateAndEditMaterial()
                    : new CreateAndEditMaterial(materialDataGridView.CurrentRow.Cells[0]?.Value.ToString());

                window.Show();
            }
            else
            {
                MessageBox.Show("Во время работы программы что-то пошло не так, попробуйте перезапустить программу",
                            "Упс...",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
            }
        }

        private void ManagerBtn_Click(object sender, EventArgs e)
        {
            // Если уже была открыта, закроем старый экземпляр
            if (Application.OpenForms.OfType<CreateAndEditManager>().Count() == 1)
            {
                Application.OpenForms.OfType<CreateAndEditManager>().First().Close();
            }

            string actionTitle = Helper.GetButtonActionTitle(sender);

            if (!string.IsNullOrEmpty(actionTitle))
            {
                CreateAndEditManager window = actionTitle == "Создать"
                    ? new CreateAndEditManager()
                    : new CreateAndEditManager(managersDataGridView.CurrentRow.Cells[0]?.Value.ToString());

                window.Show();
            }
            else
            {
                MessageBox.Show("Во время работы программы что-то пошло не так, попробуйте перезапустить программу",
                            "Упс...",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            string btnClickedName = Helper.GetButtonActionName(sender);

            using (AppContext context = new AppContext())
            {
                switch (btnClickedName)
                {
                    case "updateOrderBtn":
                        orderDataGridView.Rows.Clear();
                        FillOrders(context);
                        break;

                    case "updateMaterialBtn":
                        materialDataGridView.Rows.Clear();
                        FillMaterials(context);
                        break;

                    case "updateManagerBtn":
                        managersDataGridView.Rows.Clear();
                        FillManagers(context);
                        break;
                    default:
                        MessageBox.Show("Во время работы программы что-то пошло не так, попробуйте перезапустить программу",
                            "Упс...",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        break;
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            string btnClickedName = Helper.GetButtonActionName(sender);

            switch (btnClickedName)
            {
                case "deleteOrderBtn":
                    Helper.DeleteRow(orderDataGridView, "Orders");
                    break;
                case "deleteMaterialBtn":
                    Helper.DeleteRow(materialDataGridView, "Materials");
                    break;
                case "deleteManagerBtn":
                    Helper.DeleteRow(managersDataGridView, "Managers");
                    break;
                default:
                    MessageBox.Show("Во время работы программы что-то пошло не так, попробуйте перезапустить программу",
                        "Упс...",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    break;
            }
        }

        #endregion
    }
}
