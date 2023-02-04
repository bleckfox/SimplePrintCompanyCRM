using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectHelpers;
using DatabaseCatalog.Models;
using AppContext = DatabaseCatalog.ApplicationContext;

namespace Forms
{
    public partial class CreateAndEditOrderWindow : Form
    {
        private int _id;
        private Order _orderToUpdate;

        public CreateAndEditOrderWindow()
        {
            InitializeComponent();
        }

        public CreateAndEditOrderWindow(string? id)
        {
            InitializeComponent();
            if (id != null)
                int.TryParse(id, out _id);
        }

        private void WindowLoad(object sender, EventArgs e)
        {
            using (AppContext context = new AppContext())
            {
                Order? order = context.Orders.FirstOrDefault(o => o.Id == _id);

                var managers = context.Managers.ToList();
                var materials = context.Materials.ToList();

                managerComboBox.Items.Clear();
                materialComboBox.Items.Clear();

                foreach (var manager in managers)
                {
                    string data = $"{manager.Id}, {manager.Name} {manager.Surname}";
                    managerComboBox.Items.Add(data);
                }

                foreach (var material in materials)
                {
                    string data = $"{material.Id}, {material.Name}, {material.Type}";
                    materialComboBox.Items.Add(data);
                }

                if (order != null)
                {
                    _orderToUpdate = order;
                    nameTextBox.Text = order.Name;
                    volumeNumeric.Value = order.Volume;
                    datePicker.Value = order.Date;

                    managerComboBox.SelectedText = $"{order.Manager?.Id}, {order.Manager?.Name} {order.Manager?.Surname}";
                    materialComboBox.SelectedText = $"{order.Material?.Id}, {order.Material?.Name}, {order.Material?.Type}";
                }
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            int volume = Convert.ToInt32(volumeNumeric.Value);
            DateTime date = datePicker.Value;
            int materialId = Helper.GetLinkedEntityId(materialComboBox);
            int managerId = Helper.GetLinkedEntityId(managerComboBox); ;

            using (AppContext context = new AppContext())
            {
                if (_orderToUpdate == null)
                {
                    Order order = new Order()
                    {
                        Name = name,
                        Volume = volume,
                        Date = date,
                        MaterialId = materialId,
                        Material = context.Materials.FirstOrDefault(m => m.Id == materialId),
                        ManagerId = managerId,
                        Manager = context.Managers.FirstOrDefault(m => m.Id == managerId)
                    };

                    context.Orders.Add(order);
                }
                else
                {
                    _orderToUpdate.Name = name;
                    _orderToUpdate.Volume = volume;
                    _orderToUpdate.Date = date;
                    _orderToUpdate.MaterialId = materialId;
                    _orderToUpdate.ManagerId = managerId;

                    context.Orders.Update(_orderToUpdate);
                }

                context.SaveChanges();
            }

            this.Close();
        }
    }
}
