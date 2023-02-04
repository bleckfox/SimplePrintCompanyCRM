using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseCatalog.Models;
using AppContext = DatabaseCatalog.ApplicationContext;

namespace Forms
{
    public partial class CreateAndEditManager : Form
    {
        private int _id;
        private Manager _managerToUpdate;

        public CreateAndEditManager()
        {
            InitializeComponent();
        }

        public CreateAndEditManager(string? id)
        {
            InitializeComponent();
            if (id != null)
                int.TryParse(id, out _id);
        }

        private void WindowLoad(object sender, EventArgs e)
        {
            using (AppContext context = new AppContext())
            {
                Manager? manager = context.Managers.FirstOrDefault(m => m.Id == _id);

                if (manager != null)
                {
                    _managerToUpdate = manager;
                    nameTextBox.Text = manager.Name;
                    surnameTextBox.Text = manager.Surname;
                    patronimycTextBox.Text = manager.Patronymic;
                    appointmentTextBox.Text = manager.Appointment;
                }
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string surname = surnameTextBox.Text;
            string patronymic = patronimycTextBox.Text;
            string appointment = appointmentTextBox.Text;

            using (AppContext context = new AppContext())
            {
                if (_managerToUpdate == null)
                {
                    Manager manager = new Manager()
                    {
                        Name = name,
                        Surname = surname,
                        Patronymic = patronymic,
                        Appointment = appointment
                    };

                    context.Managers.Add(manager);
                }
                else
                {
                    _managerToUpdate.Name = name;
                    _managerToUpdate.Surname = surname;
                    _managerToUpdate.Patronymic = patronymic;
                    _managerToUpdate.Appointment = appointment;

                    context.Managers.Update(_managerToUpdate);
                }

                context.SaveChanges();
            }

            this.Close();
        }
    }
}
